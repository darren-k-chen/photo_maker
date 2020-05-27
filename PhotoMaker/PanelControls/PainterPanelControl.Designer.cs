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
            this.LineWidthTrackBar = new System.Windows.Forms.TrackBar();
            this.LineWidthLabel = new System.Windows.Forms.Label();
            this.DashStyleLabel = new System.Windows.Forms.Label();
            this.LineButton = new System.Windows.Forms.Button();
            this.EllipseButton = new System.Windows.Forms.Button();
            this.RectangleButton = new System.Windows.Forms.Button();
            this.FitButton = new System.Windows.Forms.Button();
            this.ZoomOUT_Button = new System.Windows.Forms.Button();
            this.ZoomIN_Button = new System.Windows.Forms.Button();
            this.DashDotDotButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.DashDotButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.SolidButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.DashButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.DotButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.PenButton = new System.Windows.Forms.Button();
            this.PaletteButton = new System.Windows.Forms.Button();
            this.PasteButton = new System.Windows.Forms.Button();
            this.CopyButton = new System.Windows.Forms.Button();
            this.CutButton = new System.Windows.Forms.Button();
            this.BigCutButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.BigCopyButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.BigPasteButton = new Bunifu.Framework.UI.BunifuTileButton();
            ((System.ComponentModel.ISupportInitialize)(this.LineWidthTrackBar)).BeginInit();
            this.SuspendLayout();
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
            this.LineWidthTrackBar.Visible = false;
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
            this.LineWidthLabel.Visible = false;
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
            this.DashStyleLabel.Visible = false;
            // 
            // LineButton
            // 
            this.LineButton.BackColor = System.Drawing.Color.Transparent;
            this.LineButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LineButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LineButton.ForeColor = System.Drawing.Color.White;
            this.LineButton.Image = global::PhotoMaker.Properties.Resources.line_icon;
            this.LineButton.Location = new System.Drawing.Point(3, 445);
            this.LineButton.Name = "LineButton";
            this.LineButton.Size = new System.Drawing.Size(46, 46);
            this.LineButton.TabIndex = 18;
            this.LineButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LineButton.UseVisualStyleBackColor = false;
            this.LineButton.Visible = false;
            this.LineButton.MouseEnter += new System.EventHandler(this.LineButton_MouseEnter);
            this.LineButton.MouseLeave += new System.EventHandler(this.LineButton_MouseLeave);
            // 
            // EllipseButton
            // 
            this.EllipseButton.BackColor = System.Drawing.Color.Transparent;
            this.EllipseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EllipseButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EllipseButton.ForeColor = System.Drawing.Color.White;
            this.EllipseButton.Image = global::PhotoMaker.Properties.Resources.circle_icon;
            this.EllipseButton.Location = new System.Drawing.Point(55, 445);
            this.EllipseButton.Name = "EllipseButton";
            this.EllipseButton.Size = new System.Drawing.Size(46, 46);
            this.EllipseButton.TabIndex = 17;
            this.EllipseButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EllipseButton.UseVisualStyleBackColor = false;
            this.EllipseButton.Visible = false;
            this.EllipseButton.MouseEnter += new System.EventHandler(this.EllipseButton_MouseEnter);
            this.EllipseButton.MouseLeave += new System.EventHandler(this.EllipseButton_MouseLeave);
            // 
            // RectangleButton
            // 
            this.RectangleButton.BackColor = System.Drawing.Color.Transparent;
            this.RectangleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RectangleButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RectangleButton.ForeColor = System.Drawing.Color.White;
            this.RectangleButton.Image = global::PhotoMaker.Properties.Resources.rectangle_icon;
            this.RectangleButton.Location = new System.Drawing.Point(108, 445);
            this.RectangleButton.Name = "RectangleButton";
            this.RectangleButton.Size = new System.Drawing.Size(46, 46);
            this.RectangleButton.TabIndex = 16;
            this.RectangleButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RectangleButton.UseVisualStyleBackColor = false;
            this.RectangleButton.Visible = false;
            this.RectangleButton.Click += new System.EventHandler(this.RectangleButton_Click);
            this.RectangleButton.MouseEnter += new System.EventHandler(this.RectangleButton_MouseEnter);
            this.RectangleButton.MouseLeave += new System.EventHandler(this.RectangleButton_MouseLeave);
            // 
            // FitButton
            // 
            this.FitButton.BackColor = System.Drawing.Color.Transparent;
            this.FitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FitButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FitButton.ForeColor = System.Drawing.Color.White;
            this.FitButton.Image = global::PhotoMaker.Properties.Resources.fit_image_icon_30;
            this.FitButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FitButton.Location = new System.Drawing.Point(3, 3);
            this.FitButton.Name = "FitButton";
            this.FitButton.Size = new System.Drawing.Size(46, 46);
            this.FitButton.TabIndex = 15;
            this.FitButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.FitButton.UseVisualStyleBackColor = false;
            this.FitButton.Visible = false;
            this.FitButton.Click += new System.EventHandler(this.FitButton_Click);
            this.FitButton.MouseEnter += new System.EventHandler(this.FitButton_MouseEnter);
            this.FitButton.MouseLeave += new System.EventHandler(this.FitButton_MouseLeave);
            // 
            // ZoomOUT_Button
            // 
            this.ZoomOUT_Button.BackColor = System.Drawing.Color.Transparent;
            this.ZoomOUT_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ZoomOUT_Button.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZoomOUT_Button.ForeColor = System.Drawing.Color.White;
            this.ZoomOUT_Button.Image = global::PhotoMaker.Properties.Resources.zoom_out_icon_30;
            this.ZoomOUT_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ZoomOUT_Button.Location = new System.Drawing.Point(55, 3);
            this.ZoomOUT_Button.Name = "ZoomOUT_Button";
            this.ZoomOUT_Button.Size = new System.Drawing.Size(46, 46);
            this.ZoomOUT_Button.TabIndex = 14;
            this.ZoomOUT_Button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ZoomOUT_Button.UseVisualStyleBackColor = false;
            this.ZoomOUT_Button.Visible = false;
            this.ZoomOUT_Button.Click += new System.EventHandler(this.ZoomOUT_Button_Click);
            this.ZoomOUT_Button.MouseEnter += new System.EventHandler(this.ZoomOUT_Button_MouseEnter);
            this.ZoomOUT_Button.MouseLeave += new System.EventHandler(this.ZoomOUT_Button_MouseLeave);
            // 
            // ZoomIN_Button
            // 
            this.ZoomIN_Button.BackColor = System.Drawing.Color.Transparent;
            this.ZoomIN_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ZoomIN_Button.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZoomIN_Button.ForeColor = System.Drawing.Color.White;
            this.ZoomIN_Button.Image = global::PhotoMaker.Properties.Resources.zoom_in_icon_30;
            this.ZoomIN_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ZoomIN_Button.Location = new System.Drawing.Point(108, 3);
            this.ZoomIN_Button.Name = "ZoomIN_Button";
            this.ZoomIN_Button.Size = new System.Drawing.Size(46, 46);
            this.ZoomIN_Button.TabIndex = 13;
            this.ZoomIN_Button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ZoomIN_Button.UseVisualStyleBackColor = false;
            this.ZoomIN_Button.Visible = false;
            this.ZoomIN_Button.Click += new System.EventHandler(this.ZoomIN_Button_Click);
            this.ZoomIN_Button.MouseEnter += new System.EventHandler(this.ZoomIN_Button_MouseEnter);
            this.ZoomIN_Button.MouseLeave += new System.EventHandler(this.ZoomIN_Button_MouseLeave);
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
            this.DashDotDotButton.Visible = false;
            this.DashDotDotButton.Click += new System.EventHandler(this.DashDotDotButton_Click);
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
            this.DashDotButton.Visible = false;
            this.DashDotButton.Click += new System.EventHandler(this.DashDotButton_Click);
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
            this.SolidButton.Visible = false;
            this.SolidButton.Click += new System.EventHandler(this.SolidButton_Click);
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
            this.DashButton.Visible = false;
            this.DashButton.Click += new System.EventHandler(this.DashButton_Click);
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
            this.DotButton.Visible = false;
            this.DotButton.Click += new System.EventHandler(this.DotButton_Click);
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
            this.PenButton.Visible = false;
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
            this.PaletteButton.Visible = false;
            this.PaletteButton.Click += new System.EventHandler(this.PaletteButton_Click);
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
            this.PasteButton.Visible = false;
            this.PasteButton.Click += new System.EventHandler(this.PasteButton_Click);
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
            this.CopyButton.Visible = false;
            this.CopyButton.Click += new System.EventHandler(this.CopyButton_Click);
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
            this.CutButton.Visible = false;
            this.CutButton.Click += new System.EventHandler(this.CutButton_Click);
            this.CutButton.MouseEnter += new System.EventHandler(this.CutButton_MouseEnter);
            this.CutButton.MouseLeave += new System.EventHandler(this.CutButton_MouseLeave);
            // 
            // BigCutButton
            // 
            this.BigCutButton.BackColor = System.Drawing.Color.Transparent;
            this.BigCutButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BigCutButton.color = System.Drawing.Color.Transparent;
            this.BigCutButton.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(170)))), ((int)(((byte)(245)))));
            this.BigCutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BigCutButton.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BigCutButton.ForeColor = System.Drawing.Color.White;
            this.BigCutButton.Image = global::PhotoMaker.Properties.Resources.cut_icon_46;
            this.BigCutButton.ImagePosition = 23;
            this.BigCutButton.ImageZoom = 50;
            this.BigCutButton.LabelPosition = 48;
            this.BigCutButton.LabelText = "CUT";
            this.BigCutButton.Location = new System.Drawing.Point(6, 7);
            this.BigCutButton.Margin = new System.Windows.Forms.Padding(6);
            this.BigCutButton.Name = "BigCutButton";
            this.BigCutButton.Size = new System.Drawing.Size(145, 145);
            this.BigCutButton.TabIndex = 19;
            this.BigCutButton.Click += new System.EventHandler(this.BigCutButton_Click);
            this.BigCutButton.MouseEnter += new System.EventHandler(this.BigCutButton_MouseEnter);
            this.BigCutButton.MouseLeave += new System.EventHandler(this.BigCutButton_MouseLeave);
            // 
            // BigCopyButton
            // 
            this.BigCopyButton.BackColor = System.Drawing.Color.Transparent;
            this.BigCopyButton.color = System.Drawing.Color.Transparent;
            this.BigCopyButton.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(170)))), ((int)(((byte)(245)))));
            this.BigCopyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BigCopyButton.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BigCopyButton.ForeColor = System.Drawing.Color.White;
            this.BigCopyButton.Image = global::PhotoMaker.Properties.Resources.copy_icon_46;
            this.BigCopyButton.ImagePosition = 23;
            this.BigCopyButton.ImageZoom = 50;
            this.BigCopyButton.LabelPosition = 48;
            this.BigCopyButton.LabelText = "COPY";
            this.BigCopyButton.Location = new System.Drawing.Point(7, 165);
            this.BigCopyButton.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.BigCopyButton.Name = "BigCopyButton";
            this.BigCopyButton.Size = new System.Drawing.Size(145, 145);
            this.BigCopyButton.TabIndex = 20;
            this.BigCopyButton.Click += new System.EventHandler(this.BigCopyButton_Click);
            this.BigCopyButton.MouseEnter += new System.EventHandler(this.BigCopyButton_MouseEnter);
            this.BigCopyButton.MouseLeave += new System.EventHandler(this.BigCopyButton_MouseLeave);
            // 
            // BigPasteButton
            // 
            this.BigPasteButton.BackColor = System.Drawing.Color.Transparent;
            this.BigPasteButton.color = System.Drawing.Color.Transparent;
            this.BigPasteButton.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(170)))), ((int)(((byte)(245)))));
            this.BigPasteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BigPasteButton.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BigPasteButton.ForeColor = System.Drawing.Color.White;
            this.BigPasteButton.Image = global::PhotoMaker.Properties.Resources.paste_icon_46;
            this.BigPasteButton.ImagePosition = 23;
            this.BigPasteButton.ImageZoom = 50;
            this.BigPasteButton.LabelPosition = 48;
            this.BigPasteButton.LabelText = "Paste";
            this.BigPasteButton.Location = new System.Drawing.Point(6, 324);
            this.BigPasteButton.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.BigPasteButton.Name = "BigPasteButton";
            this.BigPasteButton.Size = new System.Drawing.Size(145, 145);
            this.BigPasteButton.TabIndex = 21;
            this.BigPasteButton.Click += new System.EventHandler(this.BigPasteButton_Click);
            this.BigPasteButton.MouseEnter += new System.EventHandler(this.BigPasteButton_MouseEnter);
            this.BigPasteButton.MouseLeave += new System.EventHandler(this.BigPasteButton_MouseLeave);
            // 
            // PainterPanelControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.BigPasteButton);
            this.Controls.Add(this.BigCopyButton);
            this.Controls.Add(this.BigCutButton);
            this.Controls.Add(this.LineButton);
            this.Controls.Add(this.EllipseButton);
            this.Controls.Add(this.RectangleButton);
            this.Controls.Add(this.FitButton);
            this.Controls.Add(this.ZoomOUT_Button);
            this.Controls.Add(this.ZoomIN_Button);
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
        private System.Windows.Forms.Button ZoomIN_Button;
        private System.Windows.Forms.Button ZoomOUT_Button;
        private System.Windows.Forms.Button FitButton;
        private System.Windows.Forms.Button RectangleButton;
        private System.Windows.Forms.Button EllipseButton;
        private System.Windows.Forms.Button LineButton;
        private Bunifu.Framework.UI.BunifuTileButton BigCutButton;
        private Bunifu.Framework.UI.BunifuTileButton BigCopyButton;
        private Bunifu.Framework.UI.BunifuTileButton BigPasteButton;
    }
}
