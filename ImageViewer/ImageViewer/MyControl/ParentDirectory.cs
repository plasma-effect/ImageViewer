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
    public partial class ParentDirectory : UserControl, IDirectoryContent
    {
        public ParentDirectory(FileExplorer explorer)
        {
            this.explorer = explorer;
            InitializeComponent();
        }

        FileExplorer explorer;

        public void ContentSelect()
        {
            this.explorer.ClickParent();
        }

        public void SetFont(Font font)
        {
            this.label1.Font = font;
            this.Height = this.label1.Height;
            this.Width = this.label1.Width;
        }

        public void UnSelect()
        {

        }

        private void LabelClick(object sender, EventArgs e)
        {
            ContentSelect();
        }
    }
}
