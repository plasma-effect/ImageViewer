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
    public partial class ChangeFontForm : Form
    {
        public ChangeFontForm(Font font)
        {
            InitializeComponent();
            this.fonts = new System.Drawing.Text.InstalledFontCollection().Families;
            var index = 0;
            foreach(var f in this.fonts)
            {
                this.fontNames.Items.Add(f.Name);
                if (f.Name == font.Name)
                {
                    this.fontNames.SelectedIndex = index;
                }
                ++index;
            }
            this.sizeUpDown.Value = (int)font.Size;
            this.sampleLabel.Font = font;
        }
        FontFamily[] fonts;

        private void AcceptButtonClick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void CancelButtonClick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void FontNamesSelectedIndexChanged(object sender, EventArgs e)
        {
            this.sampleLabel.Font = new Font(this.fonts[this.fontNames.SelectedIndex], (float)this.sizeUpDown.Value);
        }

        private void SizeUpDownValueChanged(object sender, EventArgs e)
        {
            this.sampleLabel.Font = new Font(this.fonts[this.fontNames.SelectedIndex], (float)this.sizeUpDown.Value);
        }

        public Font CurrentFont => this.sampleLabel.Font;
    }
}
