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
    public partial class FileExplorer : Form
    {
        public FileExplorer()
        {
            InitializeComponent();
        }

        ImageViewer viewer;
        private void FileExplorerLoad(object sender, EventArgs e)
        {
            this.viewer = new ImageViewer(this);
            this.viewer.Show();
        }

        private void FileExplorerClosed(object sender, FormClosedEventArgs e)
        {
            this.viewer.Close();
            this.viewer.Dispose();
        }
    }
}
