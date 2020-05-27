namespace PhotoMaker.UserControls
{
    partial class FilePanelControl
    {
        /// <summary> 
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilePanelControl));
            this.CloseFileButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.OpenFileButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.SaveFileButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.QuitButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.SuspendLayout();
            // 
            // CloseFileButton
            // 
            this.CloseFileButton.BackColor = System.Drawing.Color.Transparent;
            this.CloseFileButton.color = System.Drawing.Color.Transparent;
            this.CloseFileButton.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(170)))), ((int)(((byte)(245)))));
            this.CloseFileButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseFileButton.Enabled = false;
            this.CloseFileButton.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseFileButton.ForeColor = System.Drawing.Color.White;
            this.CloseFileButton.Image = global::PhotoMaker.Properties.Resources.close_file_white_icon;
            this.CloseFileButton.ImagePosition = 23;
            this.CloseFileButton.ImageZoom = 50;
            this.CloseFileButton.LabelPosition = 48;
            this.CloseFileButton.LabelText = "Delete";
            this.CloseFileButton.Location = new System.Drawing.Point(5, 325);
            this.CloseFileButton.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.CloseFileButton.Name = "CloseFileButton";
            this.CloseFileButton.Size = new System.Drawing.Size(145, 145);
            this.CloseFileButton.TabIndex = 2;
            this.CloseFileButton.Click += new System.EventHandler(this.CloseFileButton_Click);
            this.CloseFileButton.MouseEnter += new System.EventHandler(this.CloseFileButton_MouseEnter);
            this.CloseFileButton.MouseLeave += new System.EventHandler(this.CloseFileButton_MouseLeave);
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.BackColor = System.Drawing.Color.Transparent;
            this.OpenFileButton.color = System.Drawing.Color.Transparent;
            this.OpenFileButton.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(170)))), ((int)(((byte)(245)))));
            this.OpenFileButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpenFileButton.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenFileButton.ForeColor = System.Drawing.Color.White;
            this.OpenFileButton.Image = global::PhotoMaker.Properties.Resources.open_file_white_icon;
            this.OpenFileButton.ImagePosition = 23;
            this.OpenFileButton.ImageZoom = 50;
            this.OpenFileButton.LabelPosition = 48;
            this.OpenFileButton.LabelText = "Open";
            this.OpenFileButton.Location = new System.Drawing.Point(5, 7);
            this.OpenFileButton.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Size = new System.Drawing.Size(145, 145);
            this.OpenFileButton.TabIndex = 1;
            this.OpenFileButton.Click += new System.EventHandler(this.OpenFileButton_Click);
            this.OpenFileButton.MouseEnter += new System.EventHandler(this.OpenFileButton_MouseEnter);
            this.OpenFileButton.MouseLeave += new System.EventHandler(this.OpenFileButton_MouseLeave);
            // 
            // SaveFileButton
            // 
            this.SaveFileButton.BackColor = System.Drawing.Color.Transparent;
            this.SaveFileButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.SaveFileButton.color = System.Drawing.Color.Transparent;
            this.SaveFileButton.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(170)))), ((int)(((byte)(245)))));
            this.SaveFileButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveFileButton.Enabled = false;
            this.SaveFileButton.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveFileButton.ForeColor = System.Drawing.Color.White;
            this.SaveFileButton.Image = global::PhotoMaker.Properties.Resources.save_file_white_icon;
            this.SaveFileButton.ImagePosition = 23;
            this.SaveFileButton.ImageZoom = 50;
            this.SaveFileButton.LabelPosition = 48;
            this.SaveFileButton.LabelText = "Save";
            this.SaveFileButton.Location = new System.Drawing.Point(5, 166);
            this.SaveFileButton.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.SaveFileButton.Name = "SaveFileButton";
            this.SaveFileButton.Size = new System.Drawing.Size(145, 145);
            this.SaveFileButton.TabIndex = 0;
            this.SaveFileButton.Click += new System.EventHandler(this.SaveFileButton_Click);
            this.SaveFileButton.MouseEnter += new System.EventHandler(this.SaveFileButton_MouseEnter);
            this.SaveFileButton.MouseLeave += new System.EventHandler(this.SaveFileButton_MouseLeave);
            // 
            // QuitButton
            // 
            this.QuitButton.ActiveBorderThickness = 1;
            this.QuitButton.ActiveCornerRadius = 20;
            this.QuitButton.ActiveFillColor = System.Drawing.Color.Red;
            this.QuitButton.ActiveForecolor = System.Drawing.Color.White;
            this.QuitButton.ActiveLineColor = System.Drawing.Color.White;
            this.QuitButton.BackColor = System.Drawing.Color.Transparent;
            this.QuitButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("QuitButton.BackgroundImage")));
            this.QuitButton.ButtonText = "QUIT";
            this.QuitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.QuitButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuitButton.ForeColor = System.Drawing.Color.White;
            this.QuitButton.IdleBorderThickness = 1;
            this.QuitButton.IdleCornerRadius = 20;
            this.QuitButton.IdleFillColor = System.Drawing.Color.Transparent;
            this.QuitButton.IdleForecolor = System.Drawing.Color.White;
            this.QuitButton.IdleLineColor = System.Drawing.Color.White;
            this.QuitButton.Location = new System.Drawing.Point(6, 483);
            this.QuitButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(145, 49);
            this.QuitButton.TabIndex = 3;
            this.QuitButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // FilePanelControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.CloseFileButton);
            this.Controls.Add(this.OpenFileButton);
            this.Controls.Add(this.SaveFileButton);
            this.Name = "FilePanelControl";
            this.Size = new System.Drawing.Size(157, 538);
            this.Load += new System.EventHandler(this.FilePanelControl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuTileButton SaveFileButton;
        private Bunifu.Framework.UI.BunifuTileButton CloseFileButton;
        public Bunifu.Framework.UI.BunifuThinButton2 QuitButton;
        public Bunifu.Framework.UI.BunifuTileButton OpenFileButton;
    }
}
