namespace ImageViewer
{
    partial class SubDirectory
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
            this.フォルダを開くToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.フォルダ全てをアルバムに追加ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ContextMenuStrip = this.contextMenuStrip1;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 33);
            this.label1.TabIndex = 0;
            this.label1.Click += new System.EventHandler(this.LabelClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.フォルダを開くToolStripMenuItem,
            this.フォルダ全てをアルバムに追加ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(366, 80);
            // 
            // フォルダを開くToolStripMenuItem
            // 
            this.フォルダを開くToolStripMenuItem.Name = "フォルダを開くToolStripMenuItem";
            this.フォルダを開くToolStripMenuItem.Size = new System.Drawing.Size(365, 38);
            this.フォルダを開くToolStripMenuItem.Text = "フォルダを開く";
            this.フォルダを開くToolStripMenuItem.Click += new System.EventHandler(this.OpenDirectoryClick);
            // 
            // フォルダ全てをアルバムに追加ToolStripMenuItem
            // 
            this.フォルダ全てをアルバムに追加ToolStripMenuItem.Name = "フォルダ全てをアルバムに追加ToolStripMenuItem";
            this.フォルダ全てをアルバムに追加ToolStripMenuItem.Size = new System.Drawing.Size(365, 38);
            this.フォルダ全てをアルバムに追加ToolStripMenuItem.Text = "フォルダ全てをアルバムに追加";
            this.フォルダ全てをアルバムに追加ToolStripMenuItem.Click += new System.EventHandler(this.AddAllContentClick);
            // 
            // SubDirectory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.label1);
            this.Name = "SubDirectory";
            this.Size = new System.Drawing.Size(500, 150);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem フォルダを開くToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem フォルダ全てをアルバムに追加ToolStripMenuItem;
    }
}
