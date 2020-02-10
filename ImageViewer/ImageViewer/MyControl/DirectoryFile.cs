using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ImageViewer
{
    public partial class DirectoryFile : UserControl,IDirectoryContent
    {
        public DirectoryFile(int index, FileExplorer explorer, string name)
        {
            this.index = index;
            this.explorer = explorer;
            InitializeComponent();
            this.label1.Text = name;
        }

        int index;
        FileExplorer explorer;

        private void ShowClick(object sender, EventArgs e)
        {

        }

        private void AddAlbumClick(object sender, EventArgs e)
        {

        }

        public void ContentSelect()
        {
            this.explorer.ClickDirectoryFile(this.index);
            this.label1.ForeColor = Color.White;
            this.BackColor = Color.Blue;
        }

        public void UnSelect()
        {
            this.label1.ForeColor = SystemColors.ControlText;
            this.BackColor = SystemColors.Control;
        }

        public void SetFont(Font font)
        {
            this.label1.Font = font;
            this.Height = this.label1.Height;
            this.Width = this.label1.Width;
        }

        private void LabelClick(object sender, EventArgs e)
        {
            ContentSelect();
        }
    }
}
