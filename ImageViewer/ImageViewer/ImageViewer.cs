using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageViewer
{
    public partial class ImageViewer : Form
    {
        public ImageViewer(FileExplorer explorer)
        {
            this.explorer = explorer;
            InitializeComponent();
        }
        FileExplorer explorer;

        private void ImageViewerKeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
