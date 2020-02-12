using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageViewer
{ 
    public partial class AlbumFile : UserControl
    {
        public AlbumFile(int index, FileExplorer explorer, string name, Font font)
        {
            InitializeComponent();
            this.Index = index;
            this.explorer = explorer;
            this.label1.Text = name;
            SetFont(font);
        }
        FileExplorer explorer;
        public int Index { get; set; }

        private void AlbumFileLabelClick(object sender, EventArgs e)
        {
            ContentSelect();
        }

        private void ShowClick(object sender, EventArgs e)
        {
            ContentSelect();
        }

        private void RemoveFromAlbumClick(object sender, EventArgs e)
        {
            this.explorer.RemoveAlbumFile(this.Index);
        }

        public void ContentSelect()
        {
            this.explorer.ClickAlbumFile(this.Index);
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

        public string FileName 
        {
            set
            {
                this.label1.Text = value;
                this.Width = this.label1.Width;
            }
            get
            {
                return this.label1.Text;
            }
        }

    }
}
