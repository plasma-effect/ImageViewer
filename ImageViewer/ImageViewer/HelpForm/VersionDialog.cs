using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageViewer.HelpForm
{
    public partial class VersionDialog : Form
    {
        public VersionDialog()
        {
            InitializeComponent();
        }

        private void VersionDialogLoad(object sender, EventArgs e)
        {
            this.versionLabel.Text += Application.ProductVersion;
        }

        private void LicenceLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                this.linkLabel1.LinkVisited = true;
                System.Diagnostics.Process.Start("https://github.com/plasma-effect/ImageViewer/blob/master/LICENSE");
            }
            catch (Exception)
            {
                MessageBox.Show("クリックしたリンクが開けませんでした", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
