namespace PhotoMaker.PanelControls
{
    partial class PainterPanelControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PainterPanelControl));
            this.PenButton = new System.Windows.Forms.Button();
            this.PaletteButton = new System.Windows.Forms.Button();
            this.PasteButton = new System.Windows.Forms.Button();
            this.CopyButton = new System.Windows.Forms.Button();
            this.CutButton = new System.Windows.Forms.Button();
            this.LineWidthTrackBar = new System.Windows.Forms.TrackBar();
            this.LineWidthLabel = new System.Windows.Forms.Label();
            this.DashStyleLabel = new System.Windows.Forms.Label();
            this.DotButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.DashButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.SolidButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.DashDotButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.DashDotDotButton = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.LineWidthTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // PenButton
            // 
            this.PenButton.BackColor = System.Drawing.Color.Transparent;
            this.PenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PenButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PenButton.ForeColor = System.Drawing.Color.White;
            this.PenButton.Image = global::PhotoMaker.Properties.Resources.pen_ico_30;
            this.PenButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PenButton.Location = new System.Drawing.Point(3, 106);
            this.PenButton.Name = "PenButton";
            this.PenButton.Size = new System.Drawing.Size(46, 46);
            this.PenButton.TabIndex = 4;
            this.PenButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PenButton.UseVisualStyleBackColor = false;
            this.PenButton.MouseEnter += new System.EventHandler(this.PenButton_MouseEnter);
            this.PenButton.MouseLeave += new System.EventHandler(this.PenButton_MouseLeave);
            // 
            // PaletteButton
            // 
            this.PaletteButton.BackColor = System.Drawing.Color.Transparent;
            this.PaletteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PaletteButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaletteButton.ForeColor = System.Drawing.Color.White;
            this.PaletteButton.Image = global::PhotoMaker.Properties.Resources.palette_icon_30;
            this.PaletteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PaletteButton.Location = new System.Drawing.Point(55, 106);
            this.PaletteButton.Name = "PaletteButton";
            this.PaletteButton.Size = new System.Drawing.Size(99, 46);
            this.PaletteButton.TabIndex = 3;
            this.PaletteButton.Text = "Palette";
            this.PaletteButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PaletteButton.UseVisualStyleBackColor = false;
            this.PaletteButton.MouseEnter += new System.EventHandler(this.PaletteButton_MouseEnter);
            this.PaletteButton.MouseLeave += new System.EventHandler(this.PaletteButton_MouseLeave);
            // 
            // PasteButton
            // 
            this.PasteButton.BackColor = System.Drawing.Color.Transparent;
            this.PasteButton.BackgroundImage = global::PhotoMaker.Properties.Resources.paste_icon_46;
            this.PasteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PasteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PasteButton.ForeColor = System.Drawing.Color.White;
            this.PasteButton.Location = new System.Drawing.Point(108, 54);
            this.PasteButton.Name = "PasteButton";
            this.PasteButton.Size = new System.Drawing.Size(46, 46);
            this.PasteButton.TabIndex = 2;
            this.PasteButton.UseVisualStyleBackColor = false;
            this.PasteButton.MouseEnter += new System.EventHandler(this.PasteButton_MouseEnter);
            this.PasteButton.MouseLeave += new System.EventHandler(this.PasteButton_MouseLeave);
            // 
            // CopyButton
            // 
            this.CopyButton.BackColor = System.Drawing.Color.Transparent;
            this.CopyButton.BackgroundImage = global::PhotoMaker.Properties.Resources.copy_icon_46;
            this.CopyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CopyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CopyButton.ForeColor = System.Drawing.Color.Transparent;
            this.CopyButton.Location = new System.Drawing.Point(55, 54);
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.Size = new System.Drawing.Size(46, 46);
            this.CopyButton.TabIndex = 1;
            this.CopyButton.UseVisualStyleBackColor = false;
            this.CopyButton.MouseEnter += new System.EventHandler(this.CopyButton_MouseEnter);
            this.CopyButton.MouseLeave += new System.EventHandler(this.CopyButton_MouseLeave);
            // 
            // CutButton
            // 
            this.CutButton.BackColor = System.Drawing.Color.Transparent;
            this.CutButton.BackgroundImage = global::PhotoMaker.Properties.Resources.cut_icon_46;
            this.CutButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CutButton.ForeColor = System.Drawing.Color.White;
            this.CutButton.Location = new System.Drawing.Point(3, 54);
            this.CutButton.Name = "CutButton";
            this.CutButton.Size = new System.Drawing.Size(46, 46);
            this.CutButton.TabIndex = 0;
            this.CutButton.UseVisualStyleBackColor = false;
            this.CutButton.Click += new System.EventHandler(this.CutButton_Click);
            this.CutButton.MouseEnter += new System.EventHandler(this.CutButton_MouseEnter);
            this.CutButton.MouseLeave += new System.EventHandler(this.CutButton_MouseLeave);
            // 
            // LineWidthTrackBar
            // 
            this.LineWidthTrackBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(170)))), ((int)(((byte)(245)))));
            this.LineWidthTrackBar.LargeChange = 1;
            this.LineWidthTrackBar.Location = new System.Drawing.Point(3, 181);
            this.LineWidthTrackBar.Maximum = 4;
            this.LineWidthTrackBar.Name = "LineWidthTrackBar";
            this.LineWidthTrackBar.Size = new System.Drawing.Size(151, 45);
            this.LineWidthTrackBar.TabIndex = 1;
            // 
            // LineWidthLabel
            // 
            this.LineWidthLabel.AutoSize = true;
            this.LineWidthLabel.BackColor = System.Drawing.Color.Transparent;
            this.LineWidthLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LineWidthLabel.ForeColor = System.Drawing.Color.White;
            this.LineWidthLabel.Location = new System.Drawing.Point(3, 155);
            this.LineWidthLabel.Name = "LineWidthLabel";
            this.LineWidthLabel.Size = new System.Drawing.Size(94, 23);
            this.LineWidthLabel.TabIndex = 6;
            this.LineWidthLabel.Text = "Line Width";
            // 
            // DashStyleLabel
            // 
            this.DashStyleLabel.AutoSize = true;
            this.DashStyleLabel.BackColor = System.Drawing.Color.Transparent;
            this.DashStyleLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashStyleLabel.ForeColor = System.Drawing.Color.White;
            this.DashStyleLabel.Location = new System.Drawing.Point(3, 229);
            this.DashStyleLabel.Name = "DashStyleLabel";
            this.DashStyleLabel.Size = new System.Drawing.Size(96, 23);
            this.DashStyleLabel.TabIndex = 7;
            this.DashStyleLabel.Text = "Dash Style";
            // 
            // DotButton
            // 
            this.DotButton.ActiveBorderThickness = 1;
            this.DotButton.ActiveCornerRadius = 20;
            this.DotButton.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(170)))), ((int)(((byte)(245)))));
            this.DotButton.ActiveForecolor = System.Drawing.Color.Black;
            this.DotButton.ActiveLineColor = System.Drawing.Color.Black;
            this.DotButton.BackColor = System.Drawing.Color.Transparent;
            this.DotButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DotButton.BackgroundImage")));
            this.DotButton.ButtonText = "‧‧‧‧‧‧‧‧‧‧‧‧‧‧‧‧‧‧‧‧‧‧‧‧‧‧‧‧‧‧‧‧‧‧‧";
            this.DotButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DotButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DotButton.ForeColor = System.Drawing.Color.White;
            this.DotButton.IdleBorderThickness = 1;
            this.DotButton.IdleCornerRadius = 20;
            this.DotButton.IdleFillColor = System.Drawing.Color.Transparent;
            this.DotButton.IdleForecolor = System.Drawing.Color.White;
            this.DotButton.IdleLineColor = System.Drawing.Color.White;
            this.DotButton.Location = new System.Drawing.Point(3, 257);
            this.DotButton.Margin = new System.Windows.Forms.Padding(5);
            this.DotButton.Name = "DotButton";
            this.DotButton.Size = new System.Drawing.Size(149, 28);
            this.DotButton.TabIndex = 8;
            this.DotButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DashButton
            // 
            this.DashButton.ActiveBorderThickness = 1;
            this.DashButton.ActiveCornerRadius = 20;
            this.DashButton.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(170)))), ((int)(((byte)(245)))));
            this.DashButton.ActiveForecolor = System.Drawing.Color.Black;
            this.DashButton.ActiveLineColor = System.Drawing.Color.Black;
            this.DashButton.BackColor = System.Drawing.Color.Transparent;
            this.DashButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DashButton.BackgroundImage")));
            this.DashButton.ButtonText = "---------------------------";
            this.DashButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DashButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashButton.ForeColor = System.Drawing.Color.White;
            this.DashButton.IdleBorderThickness = 1;
            this.DashButton.IdleCornerRadius = 20;
            this.DashButton.IdleFillColor = System.Drawing.Color.Transparent;
            this.DashButton.IdleForecolor = System.Drawing.Color.White;
            this.DashButton.IdleLineColor = System.Drawing.Color.White;
            this.DashButton.Location = new System.Drawing.Point(3, 295);
            this.DashButton.Margin = new System.Windows.Forms.Padding(5);
            this.DashButton.Name = "DashButton";
            this.DashButton.Size = new System.Drawing.Size(149, 28);
            this.DashButton.TabIndex = 9;
            this.DashButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SolidButton
            // 
            this.SolidButton.ActiveBorderThickness = 1;
            this.SolidButton.ActiveCornerRadius = 20;
            this.SolidButton.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(170)))), ((int)(((byte)(245)))));
            this.SolidButton.ActiveForecolor = System.Drawing.Color.Black;
            this.SolidButton.ActiveLineColor = System.Drawing.Color.Black;
            this.SolidButton.BackColor = System.Drawing.Color.Transparent;
            this.SolidButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SolidButton.BackgroundImage")));
            this.SolidButton.ButtonText = "_______________________";
            this.SolidButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SolidButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SolidButton.ForeColor = System.Drawing.Color.White;
            this.SolidButton.IdleBorderThickness = 1;
            this.SolidButton.IdleCornerRadius = 20;
            this.SolidButton.IdleFillColor = System.Drawing.Color.Transparent;
            this.SolidButton.IdleForecolor = System.Drawing.Color.White;
            this.SolidButton.IdleLineColor = System.Drawing.Color.White;
            this.SolidButton.Location = new System.Drawing.Point(3, 333);
            this.SolidButton.Margin = new System.Windows.Forms.Padding(5);
            this.SolidButton.Name = "SolidButton";
            this.SolidButton.Size = new System.Drawing.Size(149, 28);
            this.SolidButton.TabIndex = 10;
            this.SolidButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DashDotButton
            // 
            this.DashDotButton.ActiveBorderThickness = 1;
            this.DashDotButton.ActiveCornerRadius = 20;
            this.DashDotButton.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(170)))), ((int)(((byte)(245)))));
            this.DashDotButton.ActiveForecolor = System.Drawing.Color.Black;
            this.DashDotButton.ActiveLineColor = System.Drawing.Color.Black;
            this.DashDotButton.BackColor = System.Drawing.Color.Transparent;
            this.DashDotButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DashDotButton.BackgroundImage")));
            this.DashDotButton.ButtonText = "-‧-‧-‧-‧-‧-‧-‧-‧-‧-‧-‧-‧-‧-‧-";
            this.DashDotButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DashDotButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashDotButton.ForeColor = System.Drawing.Color.White;
            this.DashDotButton.IdleBorderThickness = 1;
            this.DashDotButton.IdleCornerRadius = 20;
            this.DashDotButton.IdleFillColor = System.Drawing.Color.Transparent;
            this.DashDotButton.IdleForecolor = System.Drawing.Color.White;
            this.DashDotButton.IdleLineColor = System.Drawing.Color.White;
            this.DashDotButton.Location = new System.Drawing.Point(3, 371);
            this.DashDotButton.Margin = new System.Windows.Forms.Padding(5);
            this.DashDotButton.Name = "DashDotButton";
            this.DashDotButton.Size = new System.Drawing.Size(149, 28);
            this.DashDotButton.TabIndex = 11;
            this.DashDotButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DashDotDotButton
            // 
            this.DashDotDotButton.ActiveBorderThickness = 1;
            this.DashDotDotButton.ActiveCornerRadius = 20;
            this.DashDotDotButton.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(170)))), ((int)(((byte)(245)))));
            this.DashDotDotButton.ActiveForecolor = System.Drawing.Color.Black;
            this.DashDotDotButton.ActiveLineColor = System.Drawing.Color.Black;
            this.DashDotDotButton.BackColor = System.Drawing.Color.Transparent;
            this.DashDotDotButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DashDotDotButton.BackgroundImage")));
            this.DashDotDotButton.ButtonText = "-‧‧-‧‧-‧‧-‧‧-‧‧-‧‧-‧‧-‧‧-‧‧-‧‧-";
            this.DashDotDotButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DashDotDotButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashDotDotButton.ForeColor = System.Drawing.Color.White;
            this.DashDotDotButton.IdleBorderThickness = 1;
            this.DashDotDotButton.IdleCornerRadius = 20;
            this.DashDotDotButton.IdleFillColor = System.Drawing.Color.Transparent;
            this.DashDotDotButton.IdleForecolor = System.Drawing.Color.White;
            this.DashDotDotButton.IdleLineColor = System.Drawing.Color.White;
            this.DashDotDotButton.Location = new System.Drawing.Point(3, 409);
            this.DashDotDotButton.Margin = new System.Windows.Forms.Padding(5);
            this.DashDotDotButton.Name = "DashDotDotButton";
            this.DashDotDotButton.Size = new System.Drawing.Size(149, 28);
            this.DashDotDotButton.TabIndex = 12;
            this.DashDotDotButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PainterPanelControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.DashDotDotButton);
            this.Controls.Add(this.DashDotButton);
            this.Controls.Add(this.SolidButton);
            this.Controls.Add(this.DashButton);
            this.Controls.Add(this.DotButton);
            this.Controls.Add(this.DashStyleLabel);
            this.Controls.Add(this.LineWidthLabel);
            this.Controls.Add(this.LineWidthTrackBar);
            this.Controls.Add(this.PenButton);
            this.Controls.Add(this.PaletteButton);
            this.Controls.Add(this.PasteButton);
            this.Controls.Add(this.CopyButton);
            this.Controls.Add(this.CutButton);
            this.Name = "PainterPanelControl";
            this.Size = new System.Drawing.Size(157, 538);
            this.Load += new System.EventHandler(this.PainterPanelControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LineWidthTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CutButton;
        private System.Windows.Forms.Button CopyButton;
        private System.Windows.Forms.Button PasteButton;
        private System.Windows.Forms.Button PaletteButton;
        private System.Windows.Forms.Button PenButton;
        private System.Windows.Forms.TrackBar LineWidthTrackBar;
        private System.Windows.Forms.Label LineWidthLabel;
        private System.Windows.Forms.Label DashStyleLabel;
        private Bunifu.Framework.UI.BunifuThinButton2 DotButton;
        private Bunifu.Framework.UI.BunifuThinButton2 DashButton;
        private Bunifu.Framework.UI.BunifuThinButton2 SolidButton;
        private Bunifu.Framework.UI.BunifuThinButton2 DashDotButton;
        private Bunifu.Framework.UI.BunifuThinButton2 DashDotDotButton;
    }
}
