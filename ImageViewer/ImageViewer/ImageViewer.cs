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

        protected override bool IsInputKey(Keys keyData)
        {
            if (keyData == Keys.Right || keyData == Keys.Left || keyData == Keys.Up || keyData == Keys.Down)
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
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.Down)
            {
                this.explorer.PressViewArrow(1);
            }
            else if (e.KeyCode == Keys.Left || e.KeyCode == Keys.Up)
            {
                this.explorer.PressViewArrow(-1);
            }
            else
            {
                base.OnKeyDown(e);
            }
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
                this.Text = "ImageViewer";
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
                var prev = this.pictureBox.Image;
                this.pictureBox.Image = image;
                if (prev != null)
                {
                    prev.Dispose();
                }
                this.Text = Path.GetFileName(path);
            }
            catch (OutOfMemoryException)
            {
                throw new ArgumentException($"{path}は対応していない形式です、表をリロードします");
            }
        }

        private void ImageViewerFormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
