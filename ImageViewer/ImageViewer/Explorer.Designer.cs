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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ファイルToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.フォルダを開くToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.アルバムを開くToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recentPathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.アルバムを新規作成ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.アルバムを保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.アルバムを別名保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.閉じるToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.アルバムToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.名前順でソートToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.最終更新日時でソートToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.順番をランダムにするToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.設定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.フォントサイズの変更ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ヘルプToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.バージョン情報ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.directoryLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.albumLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.albumNameLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルToolStripMenuItem,
            this.アルバムToolStripMenuItem,
            this.設定ToolStripMenuItem,
            this.ヘルプToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1228, 42);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ファイルToolStripMenuItem
            // 
            this.ファイルToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.フォルダを開くToolStripMenuItem,
            this.アルバムを開くToolStripMenuItem,
            this.recentPathToolStripMenuItem,
            this.toolStripSeparator1,
            this.アルバムを新規作成ToolStripMenuItem,
            this.アルバムを保存ToolStripMenuItem,
            this.アルバムを別名保存ToolStripMenuItem,
            this.toolStripSeparator3,
            this.toolStripMenuItem1,
            this.toolStripSeparator2,
            this.閉じるToolStripMenuItem});
            this.ファイルToolStripMenuItem.Name = "ファイルToolStripMenuItem";
            this.ファイルToolStripMenuItem.Size = new System.Drawing.Size(103, 38);
            this.ファイルToolStripMenuItem.Text = "ファイル";
            // 
            // フォルダを開くToolStripMenuItem
            // 
            this.フォルダを開くToolStripMenuItem.Name = "フォルダを開くToolStripMenuItem";
            this.フォルダを開くToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.フォルダを開くToolStripMenuItem.Size = new System.Drawing.Size(516, 44);
            this.フォルダを開くToolStripMenuItem.Text = "フォルダを開く";
            this.フォルダを開くToolStripMenuItem.Click += new System.EventHandler(this.OpenFolderToolStripMenuItemClick);
            // 
            // アルバムを開くToolStripMenuItem
            // 
            this.アルバムを開くToolStripMenuItem.Name = "アルバムを開くToolStripMenuItem";
            this.アルバムを開くToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.アルバムを開くToolStripMenuItem.Size = new System.Drawing.Size(516, 44);
            this.アルバムを開くToolStripMenuItem.Text = "アルバムを開く";
            this.アルバムを開くToolStripMenuItem.Click += new System.EventHandler(this.OpenAlbumToolStripMenuItemClick);
            // 
            // recentPathToolStripMenuItem
            // 
            this.recentPathToolStripMenuItem.Name = "recentPathToolStripMenuItem";
            this.recentPathToolStripMenuItem.Size = new System.Drawing.Size(516, 44);
            this.recentPathToolStripMenuItem.Text = "最近開いたアルバム";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(513, 6);
            // 
            // アルバムを新規作成ToolStripMenuItem
            // 
            this.アルバムを新規作成ToolStripMenuItem.Name = "アルバムを新規作成ToolStripMenuItem";
            this.アルバムを新規作成ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.アルバムを新規作成ToolStripMenuItem.Size = new System.Drawing.Size(516, 44);
            this.アルバムを新規作成ToolStripMenuItem.Text = "アルバムを新規作成";
            this.アルバムを新規作成ToolStripMenuItem.Click += new System.EventHandler(this.NewAlbumToolStripMenuItemClick);
            // 
            // アルバムを保存ToolStripMenuItem
            // 
            this.アルバムを保存ToolStripMenuItem.Name = "アルバムを保存ToolStripMenuItem";
            this.アルバムを保存ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.アルバムを保存ToolStripMenuItem.Size = new System.Drawing.Size(516, 44);
            this.アルバムを保存ToolStripMenuItem.Text = "アルバムを保存";
            this.アルバムを保存ToolStripMenuItem.Click += new System.EventHandler(this.SaveAlbumToolStripMenuItemClick);
            // 
            // アルバムを別名保存ToolStripMenuItem
            // 
            this.アルバムを別名保存ToolStripMenuItem.Name = "アルバムを別名保存ToolStripMenuItem";
            this.アルバムを別名保存ToolStripMenuItem.Size = new System.Drawing.Size(516, 44);
            this.アルバムを別名保存ToolStripMenuItem.Text = "アルバムを別名保存";
            this.アルバムを別名保存ToolStripMenuItem.Click += new System.EventHandler(this.SaveAlbumAsAnotherNameToolStripMenuItemClick);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(513, 6);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(516, 44);
            this.toolStripMenuItem1.Text = "フォルダ内の画像を全てアルバムに追加";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.AddAllFileCurrentDirectoryToolStripMenuItemClick);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(513, 6);
            // 
            // 閉じるToolStripMenuItem
            // 
            this.閉じるToolStripMenuItem.Name = "閉じるToolStripMenuItem";
            this.閉じるToolStripMenuItem.Size = new System.Drawing.Size(516, 44);
            this.閉じるToolStripMenuItem.Text = "終了";
            this.閉じるToolStripMenuItem.Click += new System.EventHandler(this.CloseToolStripMenuItemClick);
            // 
            // アルバムToolStripMenuItem
            // 
            this.アルバムToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.名前順でソートToolStripMenuItem,
            this.最終更新日時でソートToolStripMenuItem,
            this.toolStripSeparator5,
            this.順番をランダムにするToolStripMenuItem});
            this.アルバムToolStripMenuItem.Name = "アルバムToolStripMenuItem";
            this.アルバムToolStripMenuItem.Size = new System.Drawing.Size(112, 38);
            this.アルバムToolStripMenuItem.Text = "アルバム";
            // 
            // 名前順でソートToolStripMenuItem
            // 
            this.名前順でソートToolStripMenuItem.Name = "名前順でソートToolStripMenuItem";
            this.名前順でソートToolStripMenuItem.Size = new System.Drawing.Size(361, 44);
            this.名前順でソートToolStripMenuItem.Text = "名前順でソート";
            this.名前順でソートToolStripMenuItem.Click += new System.EventHandler(this.SortByNameToolStripMenuItemClick);
            // 
            // 最終更新日時でソートToolStripMenuItem
            // 
            this.最終更新日時でソートToolStripMenuItem.Name = "最終更新日時でソートToolStripMenuItem";
            this.最終更新日時でソートToolStripMenuItem.Size = new System.Drawing.Size(361, 44);
            this.最終更新日時でソートToolStripMenuItem.Text = "最終更新日時でソート";
            this.最終更新日時でソートToolStripMenuItem.Click += new System.EventHandler(this.SortByDayToolStripMenuItemClick);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(358, 6);
            // 
            // 順番をランダムにするToolStripMenuItem
            // 
            this.順番をランダムにするToolStripMenuItem.Name = "順番をランダムにするToolStripMenuItem";
            this.順番をランダムにするToolStripMenuItem.Size = new System.Drawing.Size(361, 44);
            this.順番をランダムにするToolStripMenuItem.Text = "順番をシャッフルする";
            this.順番をランダムにするToolStripMenuItem.Click += new System.EventHandler(this.ShuffleAlbumToolStripMenuItemClick);
            // 
            // 設定ToolStripMenuItem
            // 
            this.設定ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.フォントサイズの変更ToolStripMenuItem});
            this.設定ToolStripMenuItem.Name = "設定ToolStripMenuItem";
            this.設定ToolStripMenuItem.Size = new System.Drawing.Size(83, 38);
            this.設定ToolStripMenuItem.Text = "設定";
            // 
            // フォントサイズの変更ToolStripMenuItem
            // 
            this.フォントサイズの変更ToolStripMenuItem.Name = "フォントサイズの変更ToolStripMenuItem";
            this.フォントサイズの変更ToolStripMenuItem.Size = new System.Drawing.Size(349, 44);
            this.フォントサイズの変更ToolStripMenuItem.Text = "フォント/サイズの変更";
            this.フォントサイズの変更ToolStripMenuItem.Click += new System.EventHandler(this.ChangeFontToolStripMenuItemClick);
            // 
            // ヘルプToolStripMenuItem
            // 
            this.ヘルプToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripSeparator4,
            this.バージョン情報ToolStripMenuItem});
            this.ヘルプToolStripMenuItem.Name = "ヘルプToolStripMenuItem";
            this.ヘルプToolStripMenuItem.Size = new System.Drawing.Size(93, 38);
            this.ヘルプToolStripMenuItem.Text = "ヘルプ";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(359, 44);
            this.toolStripMenuItem2.Text = "使い方ガイド";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.HowToUseClick);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(356, 6);
            // 
            // バージョン情報ToolStripMenuItem
            // 
            this.バージョン情報ToolStripMenuItem.Name = "バージョン情報ToolStripMenuItem";
            this.バージョン情報ToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.バージョン情報ToolStripMenuItem.Text = "バージョン情報";
            this.バージョン情報ToolStripMenuItem.Click += new System.EventHandler(this.VersionInformationToolStripMenuItemClick);
            // 
            // directoryLayoutPanel
            // 
            this.directoryLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.directoryLayoutPanel.AutoScroll = true;
            this.directoryLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.directoryLayoutPanel.ColumnCount = 1;
            this.directoryLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.directoryLayoutPanel.Location = new System.Drawing.Point(12, 43);
            this.directoryLayoutPanel.Name = "directoryLayoutPanel";
            this.directoryLayoutPanel.RowCount = 1;
            this.directoryLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.directoryLayoutPanel.Size = new System.Drawing.Size(692, 674);
            this.directoryLayoutPanel.TabIndex = 1;
            // 
            // albumLayoutPanel
            // 
            this.albumLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.albumLayoutPanel.AutoScroll = true;
            this.albumLayoutPanel.ColumnCount = 1;
            this.albumLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.albumLayoutPanel.Location = new System.Drawing.Point(716, 79);
            this.albumLayoutPanel.Name = "albumLayoutPanel";
            this.albumLayoutPanel.RowCount = 1;
            this.albumLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.albumLayoutPanel.Size = new System.Drawing.Size(500, 638);
            this.albumLayoutPanel.TabIndex = 2;
            // 
            // albumNameLabel
            // 
            this.albumNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.albumNameLabel.AutoSize = true;
            this.albumNameLabel.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.albumNameLabel.Location = new System.Drawing.Point(710, 43);
            this.albumNameLabel.Name = "albumNameLabel";
            this.albumNameLabel.Size = new System.Drawing.Size(199, 33);
            this.albumNameLabel.TabIndex = 3;
            this.albumNameLabel.Text = "新しいアルバム";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.TimerTick);
            // 
            // FileExplorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 729);
            this.Controls.Add(this.albumNameLabel);
            this.Controls.Add(this.albumLayoutPanel);
            this.Controls.Add(this.directoryLayoutPanel);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FileExplorer";
            this.Text = "Explorer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FileExplorerFormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FileExplorerClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FileExplorerKeyDown);
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
        private System.Windows.Forms.TableLayoutPanel directoryLayoutPanel;
        private System.Windows.Forms.ToolStripMenuItem 設定ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem フォントサイズの変更ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ヘルプToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel albumLayoutPanel;
        private System.Windows.Forms.Label albumNameLabel;
        private System.Windows.Forms.ToolStripMenuItem バージョン情報ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem アルバムToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 名前順でソートToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 最終更新日時でソートToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem 順番をランダムにするToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recentPathToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
    }
}

