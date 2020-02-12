using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.Json;
using static System.Linq.Enumerable;

namespace ImageViewer
{
    public partial class FileExplorer : Form
    {
        public FileExplorer(string path)
        {
            InitializeComponent();
            if(path is null)
            {
                path = Application.ExecutablePath;
            }
            this.directory = new DirectoryInfo(Path.GetDirectoryName(path));
            this.directoryList = new List<(string path, IDirectoryContent content)>();
            this.albumList = new List<(string path, AlbumFile content)>();
        }

        static readonly string[] targetExtention = new string[]
            {
                ".bmp",".gif",".jpeg", ".jpg", ".jpe",".jfif", ".jfi", ".jif",".png",".tiff",".tif"
            };

        ImageViewer viewer;

        #region EventFunctions
        private void FileExplorerLoad(object sender, EventArgs e)
        {
            this.viewer = new ImageViewer(this);
            this.viewer.Show();
            SetDirectory(this.directory.FullName);
            FontChange(Properties.Settings.Default.controlFont);
            SetRecentPath();
        }
        private void FileExplorerClosed(object sender, FormClosedEventArgs e)
        {
            this.viewer.Close();
            this.viewer.Dispose();
        }
        private void OpenFolderToolStripMenuItemClick(object sender, EventArgs e)
        {
            try
            {
                using (var fbd = new FolderBrowserDialog())
                {
                    fbd.Description = "フォルダを選択してください";
                    fbd.RootFolder = Environment.SpecialFolder.MyComputer;
                    fbd.ShowNewFolderButton = false;
                    if (fbd.ShowDialog(this) == DialogResult.OK)
                    {
                        SetDirectory(fbd.SelectedPath);
                    }
                }
            }
            catch(Exception exp)
            {
                MessageBox.Show($@"エラーが発生しました、操作を中止します
-------------------------------------
{exp}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CloseToolStripMenuItemClick(object sender, EventArgs e)
        {
            Close();
        }
        private void VersionInformationToolStripMenuItemClick(object sender, EventArgs e)
        {
            using(var form = new HelpForm.VersionDialog())
            {
                form.ShowDialog();
            }
        }
        private void ChangeFontToolStripMenuItemClick(object sender, EventArgs e)
        {
            using(var form = new ChangeFontForm(this.font))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    FontChange(form.CurrentFont);
                }
            }
        }
        private void AddAllFileCurrentDirectoryToolStripMenuItemClick(object sender, EventArgs e)
        {
            AddDirectoryToAlbum(this.directory.FullName);
        }
        private void OpenAlbumToolStripMenuItemClick(object sender, EventArgs e)
        {
            OpenAlbum();
        }
        private void NewAlbumToolStripMenuItemClick(object sender, EventArgs e)
        {
            CreateNewAlbum();
        }
        private void SaveAlbumToolStripMenuItemClick(object sender, EventArgs e)
        {
            SaveAlbum();
        }
        private void SaveAlbumAsAnotherNameToolStripMenuItemClick(object sender, EventArgs e)
        {
            SaveAlbumAsAnotherName();
        }
        private void FileExplorerFormClosing(object sender, FormClosingEventArgs e)
        {
            if (!CheckChange())
            {
                e.Cancel = true;
                return;
            }
        }
        protected override bool IsInputKey(Keys keyData)
        {
            if (keyData == Keys.Up || keyData == Keys.Down)
            {
                return true;
            }
            else
            {
                return base.IsInputKey(keyData);
            }
        }
        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.KeyData == (Keys.Shift | Keys.Down))
            {
                if (this.currentFileA != null)
                {
                    SwapAlbumIndex(this.currentFileA.Index, this.currentFileA.Index + 1);
                }
            }
            else if (e.KeyData == (Keys.Shift | Keys.Up))
            {
                if (this.currentFileA != null)
                {
                    SwapAlbumIndex(this.currentFileA.Index, this.currentFileA.Index - 1);
                }
            }
            else if (e.KeyCode == Keys.Down)
            {
                PressViewArrow(1);
            }
            else if (e.KeyCode == Keys.Up)
            {
                PressViewArrow(-1);
            }
            else if (e.KeyCode == Keys.S && e.Control)
            {
                if (this.Changed)
                {
                    SaveAlbum();
                }
            }
            else if (e.KeyCode == Keys.N && e.Control)
            {
                CreateNewAlbum();
            }
            else
            {
                base.OnKeyDown(e);
            }
        }
        private void SortByNameToolStripMenuItemClick(object sender, EventArgs e)
        {
            this.albumList.Sort((a, b) => a.content.FileName.CompareTo(b.content.FileName));
            this.Changed = true;
            ReloadAlbum();
        }
        private void SortByDayToolStripMenuItemClick(object sender, EventArgs e)
        {
            var timeList = new List<(DateTime time, int index)>();
            foreach (var ((path, _), index) in this.albumList.Indexed())
            {
                timeList.Add((File.GetLastWriteTime(path), index));
            }
            timeList.Sort((a, b) => a.time.CompareTo(b.time));
            var newList = new List<(string path, AlbumFile content)>();
            foreach (var (_, index) in timeList)
            {
                var d = this.albumList[index];
                d.content.Index = newList.Count;
                newList.Add(d);
            }
            this.albumList = newList;
            this.Changed = true;
            ReloadAlbum();
        }
        private void ShuffleAlbumToolStripMenuItemClick(object sender, EventArgs e)
        {
            var guids = Enumerable.Range(0, this.albumList.Count).Select(i => (Guid.NewGuid(), i)).ToList();
            guids.Sort();
            var newList = new List<(string path, AlbumFile content)>();
            foreach (var (_, index) in guids)
            {
                var d = this.albumList[index];
                d.content.Index = newList.Count;
                newList.Add(d);
            }
            this.albumList = newList;
            this.Changed = true;
            ReloadAlbum();
        }
        #endregion

        #region SettingRelated
        Font font;
        private void FontChange(Font font)
        {
            var diff = this.albumNameLabel.Height;
            this.albumNameLabel.Font = font;
            this.font = font;
            diff -= this.albumNameLabel.Height;
            this.albumLayoutPanel.Location = new Point(
                this.albumLayoutPanel.Location.X,
                this.albumLayoutPanel.Location.Y - diff);
            this.albumLayoutPanel.Height -= diff;
            foreach(var (_, content) in this.directoryList)
            {
                content.SetFont(this.font);
            }
            foreach(var (_,content) in this.albumList)
            {
                content.SetFont(this.font);
            }
            Properties.Settings.Default.controlFont = this.font;
        }
        private string EmptyToNull(string str)
        {
            return str == "" ? null : str;
        }
        private void SetRecentPath()
        {
            {
                if (EmptyToNull(Properties.Settings.Default.recentPath0) is string path)
                {
                    var item = new ToolStripMenuItem(path);
                    item.Click += (sender, e) => OpenAlbum(path);
                }
            }
            {
                if (EmptyToNull(Properties.Settings.Default.recentPath1) is string path)
                {
                    var item = new ToolStripMenuItem(path);
                    item.Click += (sender, e) => OpenAlbum(path);
                }
            }
            {
                if (EmptyToNull(Properties.Settings.Default.recentPath2) is string path)
                {
                    var item = new ToolStripMenuItem(path);
                    item.Click += (sender, e) => OpenAlbum(path);
                }
            }
            {
                if (EmptyToNull(Properties.Settings.Default.recentPath3) is string path)
                {
                    var item = new ToolStripMenuItem(path);
                    item.Click += (sender, e) => OpenAlbum(path);
                }
            }
            {
                if (EmptyToNull(Properties.Settings.Default.recentPath4) is string path)
                {
                    var item = new ToolStripMenuItem(path);
                    item.Click += (sender, e) => OpenAlbum(path);
                }
            }
            {
                if (EmptyToNull(Properties.Settings.Default.recentPath5) is string path)
                {
                    var item = new ToolStripMenuItem(path);
                    item.Click += (sender, e) => OpenAlbum(path);
                }
            }
            {
                if (EmptyToNull(Properties.Settings.Default.recentPath6) is string path)
                {
                    var item = new ToolStripMenuItem(path);
                    item.Click += (sender, e) => OpenAlbum(path);
                }
            }
            {
                if (EmptyToNull(Properties.Settings.Default.recentPath7) is string path)
                {
                    var item = new ToolStripMenuItem(path);
                    item.Click += (sender, e) => OpenAlbum(path);
                }
            }
            {
                if (EmptyToNull(Properties.Settings.Default.recentPath8) is string path)
                {
                    var item = new ToolStripMenuItem(path);
                    item.Click += (sender, e) => OpenAlbum(path);
                }
            }
            {
                if (EmptyToNull(Properties.Settings.Default.recentPath9) is string path)
                {
                    var item = new ToolStripMenuItem(path);
                    item.Click += (sender, e) => OpenAlbum(path);
                }
            }
        }
        private void SaveRecentPath()
        {
            if (0 < this.recentPathToolStripMenuItem.DropDownItems.Count)
            {
                Properties.Settings.Default.recentPath0 = this.recentPathToolStripMenuItem.DropDownItems[0].Text;
            }
            if (1 < this.recentPathToolStripMenuItem.DropDownItems.Count)
            {
                Properties.Settings.Default.recentPath1 = this.recentPathToolStripMenuItem.DropDownItems[1].Text;
            }
            if (2 < this.recentPathToolStripMenuItem.DropDownItems.Count)
            {
                Properties.Settings.Default.recentPath2 = this.recentPathToolStripMenuItem.DropDownItems[2].Text;
            }
            if (3 < this.recentPathToolStripMenuItem.DropDownItems.Count)
            {
                Properties.Settings.Default.recentPath3 = this.recentPathToolStripMenuItem.DropDownItems[3].Text;
            }
            if (4 < this.recentPathToolStripMenuItem.DropDownItems.Count)
            {
                Properties.Settings.Default.recentPath4 = this.recentPathToolStripMenuItem.DropDownItems[4].Text;
            }
            if (5 < this.recentPathToolStripMenuItem.DropDownItems.Count)
            {
                Properties.Settings.Default.recentPath5 = this.recentPathToolStripMenuItem.DropDownItems[5].Text;
            }
            if (6 < this.recentPathToolStripMenuItem.DropDownItems.Count)
            {
                Properties.Settings.Default.recentPath6 = this.recentPathToolStripMenuItem.DropDownItems[6].Text;
            }
            if (7 < this.recentPathToolStripMenuItem.DropDownItems.Count)
            {
                Properties.Settings.Default.recentPath7 = this.recentPathToolStripMenuItem.DropDownItems[7].Text;
            }
            if (8 < this.recentPathToolStripMenuItem.DropDownItems.Count)
            {
                Properties.Settings.Default.recentPath8 = this.recentPathToolStripMenuItem.DropDownItems[8].Text;
            }
            if (9 < this.recentPathToolStripMenuItem.DropDownItems.Count)
            {
                Properties.Settings.Default.recentPath9 = this.recentPathToolStripMenuItem.DropDownItems[9].Text;
            }
        }
        #endregion

        #region DirectoryRelated
        DirectoryInfo directory;
        List<(string path, IDirectoryContent content)> directoryList;
        DirectoryFile currentFileD;
        private void ClearCurrentViewDirectory(bool clear)
        {
            if (this.currentFileD != null)
            {
                this.currentFileD.UnSelect();
                this.currentFileD = null;
                if (clear)
                {
                    this.viewer.View(null);
                }
            }
        }
        private void SetDirectory(string path)
        {
            var directory = new DirectoryInfo(path);
            var subDirectories = directory.GetDirectories();
            var files = directory.GetFiles();

            this.directory = directory;
            this.directoryList.Clear();
            this.directoryLayoutPanel.Controls.Clear();
            this.directoryLayoutPanel.RowCount = 0;
            var index = 0;
            if (this.directory.Parent != null)
            {
                var parent = new ParentDirectory(this, this.font);
                this.directoryLayoutPanel.Controls.Add(parent);
                this.directoryList.Add((null, parent));
                ++index;
            }
            foreach(var dir in subDirectories)
            {
                var d = new SubDirectory(index++, this, dir.Name, dir.FullName, this.font);
                this.directoryLayoutPanel.Controls.Add(d);
                this.directoryList.Add((dir.FullName, d));
            }
            foreach(var file in files)
            {
                if (targetExtention.Contains(file.Extension))
                {
                    var f = new DirectoryFile(index++, this, file.Name, this.font);
                    this.directoryLayoutPanel.Controls.Add(f);
                    this.directoryList.Add((file.FullName, f));
                }
            }
            ClearCurrentViewDirectory(true);
            this.directoryLayoutPanel.ScrollControlIntoView(this.directoryList[0].content as UserControl);
            this.Text = this.directory.FullName;
        }
        public void ClickParent()
        {
            SetDirectory(this.directory.Parent.FullName);
        }
        public void ClickSubDirectory(int index)
        {
            if (!Directory.Exists(this.directoryList[index].path))
            {
                MessageBox.Show($@"""{this.directoryList[index].path}""は存在しません、表をリセットします", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            SetDirectory(this.directoryList[index].path);
        }
        public void ClickDirectoryFile(int index)
        {
            ClearCurrentViewDirectory(false);
            ClearCurrentViewAlbum(false);

            try
            {
                this.viewer.View(this.directoryList[index].path);
                this.currentFileD = this.directoryList[index].content as DirectoryFile;
                this.directoryLayoutPanel.ScrollControlIntoView(this.currentFileD);
            }
            catch (FileNotFoundException exp)
            {
                MessageBox.Show(exp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SetDirectory(this.directory.FullName);
            }
            catch(ArgumentException exp)
            {
                MessageBox.Show(exp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SetDirectory(this.directory.FullName);
            }
            catch(Exception exp)
            {
                MessageBox.Show($@"原因不明のエラーが発生しました、強制終了します
----------------------------------------------
{exp.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }
        #endregion

        #region AlbumRelated
        string albumPath;
        string AlbumPath
        {
            set
            {
                this.albumPath = value;
                var item = new ToolStripMenuItem(value);
                item.Click += (sender, e) => OpenAlbum(value);
                foreach (var i in Range(0, this.recentPathToolStripMenuItem.DropDownItems.Count))
                {
                    if (this.recentPathToolStripMenuItem.DropDownItems[i].Text == value)
                    {
                        this.recentPathToolStripMenuItem.DropDownItems.RemoveAt(i);
                        break;
                    }
                }
                if (this.recentPathToolStripMenuItem.DropDownItems.Count == 10)
                {
                    this.recentPathToolStripMenuItem.DropDownItems.RemoveAt(9);
                }
                this.recentPathToolStripMenuItem.DropDownItems.Insert(0, item);
                SaveRecentPath();
            }
            get
            {
                return this.albumPath;
            }
        }
        bool changed;
        bool Changed
        {
            set
            {
                if (!this.changed && value)
                {
                    this.albumNameLabel.Text += "*";
                }
                this.changed = value;
            }
            get
            {
                return this.changed;
            }
        }

        List<(string path, AlbumFile content)> albumList;
        AlbumFile currentFileA;
        private void ClearCurrentViewAlbum(bool clear)
        {
            if (this.currentFileA != null)
            {
                this.currentFileA.UnSelect();
                this.currentFileA = null;
                if (clear)
                {
                    this.viewer.View(null);
                }
            }
        }
        private void ReloadAlbum()
        {
            this.albumLayoutPanel.Controls.Clear();
            this.albumLayoutPanel.RowCount = 0;
            foreach (var ((_, content), index) in this.albumList.Indexed())
            {
                content.Index = index;
                content.UnSelect();
                this.albumLayoutPanel.Controls.Add(content);
            }
        }
        public void ClickAlbumFile(int index)
        {
            ClearCurrentViewDirectory(false);
            ClearCurrentViewAlbum(false);
            try
            {
                this.viewer.View(this.albumList[index].path);
                this.currentFileA = this.albumList[index].content;
                this.albumLayoutPanel.ScrollControlIntoView(this.currentFileA);
            }
            catch (FileNotFoundException exp)
            {
                MessageBox.Show(exp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.albumList.RemoveAt(index);
                ReloadAlbum();
            }
            catch (ArgumentException exp)
            {
                MessageBox.Show(exp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.albumList.RemoveAt(index);
                ReloadAlbum();
            }
            catch (Exception exp)
            {
                MessageBox.Show($@"原因不明のエラーが発生しました、強制終了します
----------------------------------------------
{exp.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }
        public void RemoveAlbumFile(int index)
        {
            if(this.currentFileA != null && this.currentFileA.Index == index)
            {
                this.viewer.View(null);
                this.currentFileA = null;
            }
            this.albumList.RemoveAt(index);
            ReloadAlbum();
            this.Changed = true;
        }
        public bool CheckExistInAlbum(string path)
        {
            foreach(var (p, _) in this.albumList)
            {
                if (p == path)
                {
                    return true;
                }
            }
            return false;
        }
        public void AddFileToAlbum(int index)
        {
            if (CheckExistInAlbum(this.directoryList[index].path))
            {
                MessageBox.Show($@"""{this.directoryList[index].path}""はすでにアルバムに入っています", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var album = new AlbumFile(this.albumList.Count, this, Path.GetFileName(this.directoryList[index].path), this.font);
            this.albumList.Add((this.directoryList[index].path, album));
            this.albumLayoutPanel.Controls.Add(album);
            this.albumLayoutPanel.ScrollControlIntoView(album);
            this.Changed = true;
        }
        public void AddDirectoryToAlbum(string path)
        {
            try
            {
                var files = Directory.GetFiles(path);
                AlbumFile last = null;
                foreach (var f in files)
                {
                    if (targetExtention.Contains(Path.GetExtension(f)) && !CheckExistInAlbum(f))
                    {
                        var album = new AlbumFile(this.albumList.Count, this, Path.GetFileName(f), this.font);
                        this.albumList.Add((f, album));
                        this.albumLayoutPanel.Controls.Add(album);
                        last = album;
                        this.Changed = true;
                    }
                }
                if (last != null)
                {
                    this.albumLayoutPanel.ScrollControlIntoView(last);
                }
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("アクセス権限がありません、操作を中止します", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool CheckChange()
        {
            if (this.Changed)
            {
                var dialog = MessageBox.Show(@"内容が変更されています、保存しますか？
キャンセルで操作を中断できます", "確認", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (dialog == DialogResult.Yes)
                {
                    return SaveAlbum();
                }
                else if (dialog == DialogResult.Cancel)
                {
                    return false;
                }
            }
            return true;
        }
        public void CreateNewAlbum()
        {
            if (!CheckChange())
            {
                return;
            }
            this.albumList.Clear();
            this.albumLayoutPanel.Controls.Clear();
            this.albumLayoutPanel.RowCount = 0;
            this.albumNameLabel.Text = "新しいアルバム";
            this.AlbumPath = null;
            this.Changed = false;
            if (this.currentFileA != null)
            {
                this.viewer.View(null);
                this.currentFileA = null;
            }
        }
        public void OpenAlbum(string path = null)
        {
            if (!CheckChange())
            {
                return;
            }
            if (path is null)
            {
                using (var ofd = new OpenFileDialog()
                {
                    InitialDirectory = this.directory.FullName,
                    Filter = "アルバムファイル(*.alb)|*.alb|すべてのファイル(*.*)|*.*",
                    Title = "開く"
                })
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        path = ofd.FileName;
                    }
                    else
                    {
                        return;
                    }
                }
            }
            try
            {
                using (var stream = new StreamReader(path))
                {
                    if (JsonSerializer.Deserialize<List<string>>(stream.ReadToEnd()) is List<string> filelist)
                    {
                        this.albumList.Clear();
                        this.albumLayoutPanel.Controls.Clear();
                        this.albumLayoutPanel.RowCount = 0;
                        this.AlbumPath = path;
                        this.albumNameLabel.Text = Path.GetFileNameWithoutExtension(path);
                        this.Changed = false;
                        if (this.currentFileA != null)
                        {
                            this.viewer.View(null);
                            this.currentFileA = null;
                        }
                        var existInvalid = false;
                        foreach (var file in filelist)
                        {
                            if (!File.Exists(file) || !targetExtention.Contains(Path.GetExtension(file)))
                            {
                                existInvalid = true;
                                continue;
                            }
                            var album = new AlbumFile(this.albumList.Count, this, Path.GetFileName(file), this.font);
                            this.albumList.Add((file, album));
                            this.albumLayoutPanel.Controls.Add(album);
                        }
                        if (existInvalid)
                        {
                            this.Changed = true;
                            MessageBox.Show("無効なファイルのデータを削除しました", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        if (this.albumList.Count != 0)
                        {
                            this.albumLayoutPanel.ScrollControlIntoView(this.albumList[0].content);
                        }
                    }
                    else
                    {
                        throw new InvalidDataException("適切なアルバムファイルではありません");
                    }
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public bool SaveAlbum()
        {
            if (this.AlbumPath == null)
            {
                SaveAlbumAsAnotherName();
                return this.AlbumPath != null;
            }
            var list = new List<string>();
            foreach (var (path, _) in this.albumList)
            {
                list.Add(path);
            }
            using (var stream = new StreamWriter(this.AlbumPath))
            {
                stream.WriteLine(JsonSerializer.Serialize(list));
                this.Changed = false;
                this.albumNameLabel.Text = Path.GetFileNameWithoutExtension(this.AlbumPath);
            }
            return true;
        }
        public void SaveAlbumAsAnotherName()
        {
            using(var sfd = new SaveFileDialog() 
            {
                InitialDirectory = this.directory.FullName,
                Filter = "アルバムファイル(*.alb)|*.alb|すべてのファイル(*.*)|*.*",
                Title = "名前を付けて保存"
            })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    this.AlbumPath = sfd.FileName;
                    SaveAlbum();
                }
            }

        }
        public void SwapAlbumIndex(int a, int b)
        {
            if (0 <= a && a < this.albumList.Count &&
                0 <= b && b < this.albumList.Count &&
                a != b)
            {
                var tmp0 = this.albumList[a].path;
                this.albumList[a] = (this.albumList[b].path, this.albumList[a].content);
                this.albumList[b] = (tmp0, this.albumList[b].content);
                var tmp1 = this.albumList[a].content.FileName;
                this.albumList[a].content.FileName = this.albumList[b].content.FileName;
                this.albumList[b].content.FileName = tmp1;
                this.albumList[b].content.ContentSelect();
                this.Changed = true;
            }
        }
        #endregion

        #region ViewFunctions
        public void PressViewArrow(int shift)
        {
            if (this.currentFileD != null)
            {
                var i = this.currentFileD.Index + shift;
                if (0 <= i && i < this.directoryList.Count && this.directoryList[i].content is DirectoryFile df)
                {
                    df.ContentSelect();
                }
            }
            else if (this.currentFileA != null)
            {
                var i = this.currentFileA.Index + shift;
                if (0 <= i && i < this.albumList.Count)
                {
                    this.albumList[i].content.ContentSelect();
                }
            }
        }
        #endregion
    }
}
