namespace ImageViewer
{
    partial class ChangeFontForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.acceptButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.fontNames = new System.Windows.Forms.ComboBox();
            this.sizeUpDown = new System.Windows.Forms.NumericUpDown();
            this.sampleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sizeUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // acceptButton
            // 
            this.acceptButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.acceptButton.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.acceptButton.Location = new System.Drawing.Point(362, 157);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(200, 60);
            this.acceptButton.TabIndex = 0;
            this.acceptButton.Text = "OK";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.AcceptButtonClick);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cancelButton.Location = new System.Drawing.Point(156, 157);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(200, 60);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "キャンセル";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButtonClick);
            // 
            // fontNames
            // 
            this.fontNames.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.fontNames.FormattingEnabled = true;
            this.fontNames.Location = new System.Drawing.Point(12, 12);
            this.fontNames.Name = "fontNames";
            this.fontNames.Size = new System.Drawing.Size(424, 41);
            this.fontNames.TabIndex = 2;
            this.fontNames.SelectedIndexChanged += new System.EventHandler(this.FontNamesSelectedIndexChanged);
            // 
            // sizeUpDown
            // 
            this.sizeUpDown.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.sizeUpDown.Location = new System.Drawing.Point(442, 12);
            this.sizeUpDown.Maximum = new decimal(new int[] {
            72,
            0,
            0,
            0});
            this.sizeUpDown.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.sizeUpDown.Name = "sizeUpDown";
            this.sizeUpDown.Size = new System.Drawing.Size(120, 39);
            this.sizeUpDown.TabIndex = 3;
            this.sizeUpDown.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.sizeUpDown.ValueChanged += new System.EventHandler(this.SizeUpDownValueChanged);
            // 
            // sampleLabel
            // 
            this.sampleLabel.AutoSize = true;
            this.sampleLabel.Location = new System.Drawing.Point(8, 56);
            this.sampleLabel.Name = "sampleLabel";
            this.sampleLabel.Size = new System.Drawing.Size(159, 24);
            this.sampleLabel.TabIndex = 4;
            this.sampleLabel.Text = "サンプルテキスト";
            // 
            // ChangeFontForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 229);
            this.Controls.Add(this.sampleLabel);
            this.Controls.Add(this.sizeUpDown);
            this.Controls.Add(this.fontNames);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.acceptButton);
            this.Name = "ChangeFontForm";
            this.Text = "ChangeFontForm";
            ((System.ComponentModel.ISupportInitialize)(this.sizeUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ComboBox fontNames;
        private System.Windows.Forms.NumericUpDown sizeUpDown;
        private System.Windows.Forms.Label sampleLabel;
    }
}