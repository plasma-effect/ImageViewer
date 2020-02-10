namespace ImageViewer
{
    partial class DirectoryFile
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.表示するToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.アルバムに追加ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.ContextMenuStrip = this.contextMenuStrip1;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(429, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "C:\\Users\\mk_ve\\source\\repos";
            this.label1.UseMnemonic = false;
            this.label1.Click += new System.EventHandler(this.LabelClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.表示するToolStripMenuItem,
            this.アルバムに追加ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(235, 80);
            // 
            // 表示するToolStripMenuItem
            // 
            this.表示するToolStripMenuItem.Name = "表示するToolStripMenuItem";
            this.表示するToolStripMenuItem.Size = new System.Drawing.Size(234, 38);
            this.表示するToolStripMenuItem.Text = "表示する";
            this.表示するToolStripMenuItem.Click += new System.EventHandler(this.ShowClick);
            // 
            // アルバムに追加ToolStripMenuItem
            // 
            this.アルバムに追加ToolStripMenuItem.Name = "アルバムに追加ToolStripMenuItem";
            this.アルバムに追加ToolStripMenuItem.Size = new System.Drawing.Size(234, 38);
            this.アルバムに追加ToolStripMenuItem.Text = "アルバムに追加";
            this.アルバムに追加ToolStripMenuItem.Click += new System.EventHandler(this.AddAlbumClick);
            // 
            // DirectoryFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.label1);
            this.Name = "DirectoryFile";
            this.Size = new System.Drawing.Size(443, 33);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 表示するToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem アルバムに追加ToolStripMenuItem;
    }
}
