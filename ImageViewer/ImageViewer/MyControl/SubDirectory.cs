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
    public partial class SubDirectory : UserControl,IDirectoryContent
    {
        public SubDirectory(int index, FileExplorer explorer, string name)
        {
            this.index = index;
            this.explorer = explorer;
            InitializeComponent();
            this.label1.Text = name;
            this.Width = this.label1.Width;
        }
        int index;
        FileExplorer explorer;

        private void OpenDirectoryClick(object sender, EventArgs e)
        {
            ContentSelect();
        }

        private void AddAllContentClick(object sender, EventArgs e)
        {

        }

        public void ContentSelect()
        {
            try
            {
                this.explorer.ClickSubDirectory(this.index);
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("アクセス権限がありません、操作を中止します", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
