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

        public void View(string path)
        {
            if (path == null)
            {
                if (this.pictureBox.Image != null)
                {
                    this.pictureBox.Image.Dispose();
                }
                this.pictureBox.Image = null;
                return;
            }

            if (!File.Exists(path))
            {
                throw new FileNotFoundException($"{path}が見つかりません、表をリロードします");
            }

            Image image;
            try
            {
                image = Image.FromFile(path);
                if(this.pictureBox.Image != null)
                {
                    this.pictureBox.Image.Dispose();
                }
                this.pictureBox.Image = image;
            }
            catch (OutOfMemoryException)
            {
                throw new ArgumentException($"{path}は対応していない形式です、表をリロードします");
            }
        }
    }
}
