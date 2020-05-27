namespace PhotoMaker.PanelControls
{
    partial class ProcessPanelControl
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProcessPanelControl));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.LightGrayScaleButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.FilterRedButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.FilterBlueButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.FilterGreenButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.MeanGrayScaleButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.BinarizationButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.NegativeButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "negative_white_icon.png");
            this.imageList1.Images.SetKeyName(1, "negative_black_icon.png");
            // 
            // LightGrayScaleButton
            // 
            this.LightGrayScaleButton.ActiveBorderThickness = 1;
            this.LightGrayScaleButton.ActiveCornerRadius = 20;
            this.LightGrayScaleButton.ActiveFillColor = System.Drawing.Color.DimGray;
            this.LightGrayScaleButton.ActiveForecolor = System.Drawing.Color.White;
            this.LightGrayScaleButton.ActiveLineColor = System.Drawing.Color.White;
            this.LightGrayScaleButton.BackColor = System.Drawing.Color.Transparent;
            this.LightGrayScaleButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LightGrayScaleButton.BackgroundImage")));
            this.LightGrayScaleButton.ButtonText = "Light GS";
            this.LightGrayScaleButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LightGrayScaleButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LightGrayScaleButton.ForeColor = System.Drawing.Color.White;
            this.LightGrayScaleButton.IdleBorderThickness = 1;
            this.LightGrayScaleButton.IdleCornerRadius = 20;
            this.LightGrayScaleButton.IdleFillColor = System.Drawing.Color.Transparent;
            this.LightGrayScaleButton.IdleForecolor = System.Drawing.Color.White;
            this.LightGrayScaleButton.IdleLineColor = System.Drawing.Color.White;
            this.LightGrayScaleButton.Location = new System.Drawing.Point(6, 364);
            this.LightGrayScaleButton.Margin = new System.Windows.Forms.Padding(5);
            this.LightGrayScaleButton.Name = "LightGrayScaleButton";
            this.LightGrayScaleButton.Size = new System.Drawing.Size(145, 35);
            this.LightGrayScaleButton.TabIndex = 6;
            this.LightGrayScaleButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LightGrayScaleButton.Click += new System.EventHandler(this.LightGrayScaleButton_Click);
            // 
            // FilterRedButton
            // 
            this.FilterRedButton.ActiveBorderThickness = 1;
            this.FilterRedButton.ActiveCornerRadius = 20;
            this.FilterRedButton.ActiveFillColor = System.Drawing.Color.Red;
            this.FilterRedButton.ActiveForecolor = System.Drawing.Color.White;
            this.FilterRedButton.ActiveLineColor = System.Drawing.Color.White;
            this.FilterRedButton.BackColor = System.Drawing.Color.Transparent;
            this.FilterRedButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FilterRedButton.BackgroundImage")));
            this.FilterRedButton.ButtonText = "Filter-R";
            this.FilterRedButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FilterRedButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilterRedButton.ForeColor = System.Drawing.Color.Transparent;
            this.FilterRedButton.IdleBorderThickness = 1;
            this.FilterRedButton.IdleCornerRadius = 20;
            this.FilterRedButton.IdleFillColor = System.Drawing.Color.Transparent;
            this.FilterRedButton.IdleForecolor = System.Drawing.Color.White;
            this.FilterRedButton.IdleLineColor = System.Drawing.Color.White;
            this.FilterRedButton.Location = new System.Drawing.Point(6, 409);
            this.FilterRedButton.Margin = new System.Windows.Forms.Padding(5);
            this.FilterRedButton.Name = "FilterRedButton";
            this.FilterRedButton.Size = new System.Drawing.Size(145, 35);
            this.FilterRedButton.TabIndex = 5;
            this.FilterRedButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FilterRedButton.Click += new System.EventHandler(this.FilterRedButton_Click);
            // 
            // FilterBlueButton
            // 
            this.FilterBlueButton.ActiveBorderThickness = 1;
            this.FilterBlueButton.ActiveCornerRadius = 20;
            this.FilterBlueButton.ActiveFillColor = System.Drawing.Color.Blue;
            this.FilterBlueButton.ActiveForecolor = System.Drawing.Color.White;
            this.FilterBlueButton.ActiveLineColor = System.Drawing.Color.White;
            this.FilterBlueButton.BackColor = System.Drawing.Color.Transparent;
            this.FilterBlueButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FilterBlueButton.BackgroundImage")));
            this.FilterBlueButton.ButtonText = "Filter-B";
            this.FilterBlueButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FilterBlueButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilterBlueButton.ForeColor = System.Drawing.Color.White;
            this.FilterBlueButton.IdleBorderThickness = 1;
            this.FilterBlueButton.IdleCornerRadius = 20;
            this.FilterBlueButton.IdleFillColor = System.Drawing.Color.Transparent;
            this.FilterBlueButton.IdleForecolor = System.Drawing.Color.White;
            this.FilterBlueButton.IdleLineColor = System.Drawing.Color.White;
            this.FilterBlueButton.Location = new System.Drawing.Point(6, 499);
            this.FilterBlueButton.Margin = new System.Windows.Forms.Padding(5);
            this.FilterBlueButton.Name = "FilterBlueButton";
            this.FilterBlueButton.Size = new System.Drawing.Size(145, 35);
            this.FilterBlueButton.TabIndex = 4;
            this.FilterBlueButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FilterBlueButton.Click += new System.EventHandler(this.FilterBlueButton_Click);
            // 
            // FilterGreenButton
            // 
            this.FilterGreenButton.ActiveBorderThickness = 1;
            this.FilterGreenButton.ActiveCornerRadius = 20;
            this.FilterGreenButton.ActiveFillColor = System.Drawing.Color.Green;
            this.FilterGreenButton.ActiveForecolor = System.Drawing.Color.White;
            this.FilterGreenButton.ActiveLineColor = System.Drawing.Color.White;
            this.FilterGreenButton.BackColor = System.Drawing.Color.Transparent;
            this.FilterGreenButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FilterGreenButton.BackgroundImage")));
            this.FilterGreenButton.ButtonText = "Filter-G";
            this.FilterGreenButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FilterGreenButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilterGreenButton.ForeColor = System.Drawing.Color.White;
            this.FilterGreenButton.IdleBorderThickness = 1;
            this.FilterGreenButton.IdleCornerRadius = 20;
            this.FilterGreenButton.IdleFillColor = System.Drawing.Color.Transparent;
            this.FilterGreenButton.IdleForecolor = System.Drawing.Color.White;
            this.FilterGreenButton.IdleLineColor = System.Drawing.Color.White;
            this.FilterGreenButton.Location = new System.Drawing.Point(6, 454);
            this.FilterGreenButton.Margin = new System.Windows.Forms.Padding(5);
            this.FilterGreenButton.Name = "FilterGreenButton";
            this.FilterGreenButton.Size = new System.Drawing.Size(145, 35);
            this.FilterGreenButton.TabIndex = 3;
            this.FilterGreenButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FilterGreenButton.Click += new System.EventHandler(this.FilterGreenButton_Click);
            // 
            // MeanGrayScaleButton
            // 
            this.MeanGrayScaleButton.ActiveBorderThickness = 1;
            this.MeanGrayScaleButton.ActiveCornerRadius = 20;
            this.MeanGrayScaleButton.ActiveFillColor = System.Drawing.Color.DimGray;
            this.MeanGrayScaleButton.ActiveForecolor = System.Drawing.Color.White;
            this.MeanGrayScaleButton.ActiveLineColor = System.Drawing.Color.White;
            this.MeanGrayScaleButton.BackColor = System.Drawing.Color.Transparent;
            this.MeanGrayScaleButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MeanGrayScaleButton.BackgroundImage")));
            this.MeanGrayScaleButton.ButtonText = "Mean GS";
            this.MeanGrayScaleButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MeanGrayScaleButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MeanGrayScaleButton.ForeColor = System.Drawing.Color.White;
            this.MeanGrayScaleButton.IdleBorderThickness = 1;
            this.MeanGrayScaleButton.IdleCornerRadius = 20;
            this.MeanGrayScaleButton.IdleFillColor = System.Drawing.Color.Transparent;
            this.MeanGrayScaleButton.IdleForecolor = System.Drawing.Color.White;
            this.MeanGrayScaleButton.IdleLineColor = System.Drawing.Color.White;
            this.MeanGrayScaleButton.Location = new System.Drawing.Point(6, 319);
            this.MeanGrayScaleButton.Margin = new System.Windows.Forms.Padding(5);
            this.MeanGrayScaleButton.Name = "MeanGrayScaleButton";
            this.MeanGrayScaleButton.Size = new System.Drawing.Size(145, 35);
            this.MeanGrayScaleButton.TabIndex = 2;
            this.MeanGrayScaleButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MeanGrayScaleButton.Click += new System.EventHandler(this.MeanGrayScaleButton_Click);
            // 
            // BinarizationButton
            // 
            this.BinarizationButton.BackColor = System.Drawing.Color.Transparent;
            this.BinarizationButton.color = System.Drawing.Color.Transparent;
            this.BinarizationButton.colorActive = System.Drawing.Color.Black;
            this.BinarizationButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BinarizationButton.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BinarizationButton.ForeColor = System.Drawing.Color.White;
            this.BinarizationButton.Image = ((System.Drawing.Image)(resources.GetObject("BinarizationButton.Image")));
            this.BinarizationButton.ImagePosition = 23;
            this.BinarizationButton.ImageZoom = 50;
            this.BinarizationButton.LabelPosition = 48;
            this.BinarizationButton.LabelText = "Binarization";
            this.BinarizationButton.Location = new System.Drawing.Point(6, 6);
            this.BinarizationButton.Margin = new System.Windows.Forms.Padding(6);
            this.BinarizationButton.Name = "BinarizationButton";
            this.BinarizationButton.Size = new System.Drawing.Size(145, 145);
            this.BinarizationButton.TabIndex = 1;
            this.BinarizationButton.Click += new System.EventHandler(this.BinarizationButton_Click);
            // 
            // NegativeButton
            // 
            this.NegativeButton.BackColor = System.Drawing.Color.Transparent;
            this.NegativeButton.color = System.Drawing.Color.Transparent;
            this.NegativeButton.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(170)))), ((int)(((byte)(245)))));
            this.NegativeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NegativeButton.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NegativeButton.ForeColor = System.Drawing.Color.White;
            this.NegativeButton.Image = global::PhotoMaker.Properties.Resources.negative_black_icon;
            this.NegativeButton.ImagePosition = 23;
            this.NegativeButton.ImageZoom = 50;
            this.NegativeButton.LabelPosition = 48;
            this.NegativeButton.LabelText = "Negative";
            this.NegativeButton.Location = new System.Drawing.Point(6, 163);
            this.NegativeButton.Margin = new System.Windows.Forms.Padding(6);
            this.NegativeButton.Name = "NegativeButton";
            this.NegativeButton.Size = new System.Drawing.Size(145, 145);
            this.NegativeButton.TabIndex = 0;
            this.NegativeButton.Click += new System.EventHandler(this.NegativeButton_Click);
            this.NegativeButton.MouseEnter += new System.EventHandler(this.NegativeButton_MouseEnter);
            this.NegativeButton.MouseLeave += new System.EventHandler(this.NegativeButton_MouseLeave);
            // 
            // ProcessPanelControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.LightGrayScaleButton);
            this.Controls.Add(this.FilterRedButton);
            this.Controls.Add(this.FilterBlueButton);
            this.Controls.Add(this.FilterGreenButton);
            this.Controls.Add(this.MeanGrayScaleButton);
            this.Controls.Add(this.BinarizationButton);
            this.Controls.Add(this.NegativeButton);
            this.Name = "ProcessPanelControl";
            this.Size = new System.Drawing.Size(157, 538);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuTileButton NegativeButton;
        private Bunifu.Framework.UI.BunifuTileButton BinarizationButton;
        private Bunifu.Framework.UI.BunifuThinButton2 MeanGrayScaleButton;
        private Bunifu.Framework.UI.BunifuThinButton2 FilterGreenButton;
        private Bunifu.Framework.UI.BunifuThinButton2 FilterBlueButton;
        private Bunifu.Framework.UI.BunifuThinButton2 FilterRedButton;
        private Bunifu.Framework.UI.BunifuThinButton2 LightGrayScaleButton;
        private System.Windows.Forms.ImageList imageList1;
    }
}
