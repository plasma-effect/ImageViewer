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
        }
        static readonly string[] targetExtention = new string[]
            {
                ".bmp",".gif",".jpeg", ".jpg", ".jpe",".jfif", ".jfi", ".jif",".png",".tiff",".tif"
            };

        ImageViewer viewer;
        DirectoryInfo directory;
        List<(string path, IDirectoryContent content)> directoryList;
        Font font;
        DirectoryFile currentFileD;

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
        }

        private void SetDirectory(string path)
        {
            var directory = new DirectoryInfo(path);
            var subDirectories = directory.GetDirectories();
            var files = directory.GetFiles();

            this.directory = directory;
            this.directoryList = new List<(string path, IDirectoryContent content)>();
            this.directoryLayoutPanel.Controls.Clear();
            this.directoryLayoutPanel.RowCount = 0;
            var index = 0;
            if (this.directory.Parent != null)
            {
                var parent = new ParentDirectory(this);
                parent.SetFont(this.font);
                this.directoryLayoutPanel.Controls.Add(parent);
                this.directoryList.Add((null, parent));
                ++index;
            }
            foreach(var dir in subDirectories)
            {
                var d = new SubDirectory(index++, this, dir.Name);
                d.SetFont(this.font);
                this.directoryLayoutPanel.Controls.Add(d);
                this.directoryList.Add((dir.FullName, d));
            }
            foreach(var file in files)
            {
                if (targetExtention.Contains(file.Extension))
                {
                    var f = new DirectoryFile(index++, this, file.Name);
                    f.SetFont(this.font);
                    this.directoryLayoutPanel.Controls.Add(f);
                    this.directoryList.Add((file.FullName, f));
                }
            }
            this.viewer.View(null);
            this.currentFileD = null;
            this.directoryLayoutPanel.ScrollControlIntoView(this.directoryList[0].content as UserControl);
            this.Text = this.directory.FullName;
        }

        private void FileExplorerLoad(object sender, EventArgs e)
        {
            this.viewer = new ImageViewer(this);
            this.viewer.Show();
            SetDirectory(this.directory.FullName);
            FontChange(Properties.Settings.Default.controlFont);
        }

        private void FileExplorerClosed(object sender, FormClosedEventArgs e)
        {
            this.viewer.Close();
            this.viewer.Dispose();
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
            if (this.currentFileD != null)
            {
                this.currentFileD.UnSelect();
            }

            try
            {
                this.viewer.View(this.directoryList[index].path);
                this.currentFileD = this.directoryList[index].content as DirectoryFile;
            }
            catch (FileNotFoundException exp)
            {
                MessageBox.Show(exp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SetDirectory(this.directoryList[index].path);
            }
            catch(ArgumentException exp)
            {
                MessageBox.Show(exp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SetDirectory(this.directoryList[index].path);
            }
            catch(Exception exp)
            {
                MessageBox.Show($@"原因不明のエラーが発生しました、強制終了します
----------------------------------------------
{exp.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        public void ClickAlbumFile(int index)
        {
            throw new NotImplementedException();
        }

        public void PressViewArrow(int shift)
        {
            if(this.currentFileD != null)
            {
                var i = this.currentFileD.Index + shift;
                if (0 <= i && i < this.directoryList.Count && this.directoryList[i].content is DirectoryFile df)
                {
                    df.ContentSelect();
                }
            }
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
    }
}
