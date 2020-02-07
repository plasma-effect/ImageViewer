namespace ImageViewer
{
    partial class FileExplorer
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

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ファイルToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.フォルダを開くToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.アルバムを開くToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.アルバムを新規作成ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.アルバムを保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.アルバムを別名保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.閉じるToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(774, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ファイルToolStripMenuItem
            // 
            this.ファイルToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.フォルダを開くToolStripMenuItem,
            this.アルバムを開くToolStripMenuItem,
            this.toolStripSeparator1,
            this.アルバムを新規作成ToolStripMenuItem,
            this.アルバムを保存ToolStripMenuItem,
            this.アルバムを別名保存ToolStripMenuItem,
            this.toolStripSeparator2,
            this.閉じるToolStripMenuItem});
            this.ファイルToolStripMenuItem.Name = "ファイルToolStripMenuItem";
            this.ファイルToolStripMenuItem.Size = new System.Drawing.Size(103, 36);
            this.ファイルToolStripMenuItem.Text = "ファイル";
            // 
            // フォルダを開くToolStripMenuItem
            // 
            this.フォルダを開くToolStripMenuItem.Name = "フォルダを開くToolStripMenuItem";
            this.フォルダを開くToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.フォルダを開くToolStripMenuItem.Text = "フォルダを開く";
            // 
            // アルバムを開くToolStripMenuItem
            // 
            this.アルバムを開くToolStripMenuItem.Name = "アルバムを開くToolStripMenuItem";
            this.アルバムを開くToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.アルバムを開くToolStripMenuItem.Text = "アルバムを開く";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(356, 6);
            // 
            // アルバムを新規作成ToolStripMenuItem
            // 
            this.アルバムを新規作成ToolStripMenuItem.Name = "アルバムを新規作成ToolStripMenuItem";
            this.アルバムを新規作成ToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.アルバムを新規作成ToolStripMenuItem.Text = "アルバムを新規作成";
            // 
            // アルバムを保存ToolStripMenuItem
            // 
            this.アルバムを保存ToolStripMenuItem.Name = "アルバムを保存ToolStripMenuItem";
            this.アルバムを保存ToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.アルバムを保存ToolStripMenuItem.Text = "アルバムを保存";
            // 
            // アルバムを別名保存ToolStripMenuItem
            // 
            this.アルバムを別名保存ToolStripMenuItem.Name = "アルバムを別名保存ToolStripMenuItem";
            this.アルバムを別名保存ToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.アルバムを別名保存ToolStripMenuItem.Text = "アルバムを別名保存";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(356, 6);
            // 
            // 閉じるToolStripMenuItem
            // 
            this.閉じるToolStripMenuItem.Name = "閉じるToolStripMenuItem";
            this.閉じるToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.閉じるToolStripMenuItem.Text = "終了";
            // 
            // FileExplorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 729);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FileExplorer";
            this.Text = "Explorer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FileExplorerClosed);
            this.Load += new System.EventHandler(this.FileExplorerLoad);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ファイルToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem フォルダを開くToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem アルバムを開くToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem アルバムを新規作成ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem アルバムを保存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem アルバムを別名保存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem 閉じるToolStripMenuItem;
    }
}

