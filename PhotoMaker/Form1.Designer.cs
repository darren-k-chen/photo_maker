namespace PhotoMaker
{
    partial class PhotoMakerForm
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

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhotoMakerForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.painterPanelControl2 = new PhotoMaker.PanelControls.PainterPanelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.GithubButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.HideButton = new System.Windows.Forms.Button();
            this.PainterButton = new System.Windows.Forms.Button();
            this.ProcessButton = new System.Windows.Forms.Button();
            this.FileButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.processPanelControl2 = new PhotoMaker.PanelControls.ProcessPanelControl();
            this.filePanelControl1 = new PhotoMaker.UserControls.FilePanelControl();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(211)))));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.filePanelControl1);
            this.panel2.Controls.Add(this.processPanelControl2);
            this.panel2.Controls.Add(this.painterPanelControl2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(157, 538);
            this.panel2.TabIndex = 1;
            // 
            // painterPanelControl2
            // 
            this.painterPanelControl2.BackColor = System.Drawing.Color.Gray;
            this.painterPanelControl2.Location = new System.Drawing.Point(0, 0);
            this.painterPanelControl2.Name = "painterPanelControl2";
            this.painterPanelControl2.Size = new System.Drawing.Size(157, 538);
            this.painterPanelControl2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(211)))));
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.HideButton);
            this.panel1.Controls.Add(this.PainterButton);
            this.panel1.Controls.Add(this.ProcessButton);
            this.panel1.Controls.Add(this.FileButton);
            this.panel1.Controls.Add(this.CloseButton);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1160, 62);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.GithubButton);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(714, 17);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(323, 45);
            this.panel4.TabIndex = 10;
            // 
            // GithubButton
            // 
            this.GithubButton.BackColor = System.Drawing.Color.Transparent;
            this.GithubButton.FlatAppearance.BorderSize = 0;
            this.GithubButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GithubButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GithubButton.ForeColor = System.Drawing.Color.Black;
            this.GithubButton.Image = global::PhotoMaker.Properties.Resources.Github_mark_24;
            this.GithubButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GithubButton.Location = new System.Drawing.Point(3, 3);
            this.GithubButton.Name = "GithubButton";
            this.GithubButton.Size = new System.Drawing.Size(124, 27);
            this.GithubButton.TabIndex = 8;
            this.GithubButton.Text = " K.J. Chen";
            this.GithubButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GithubButton.UseVisualStyleBackColor = false;
            this.GithubButton.Click += new System.EventHandler(this.GithubButton_Click);
            this.GithubButton.MouseEnter += new System.EventHandler(this.GithubButton_MouseEnter);
            this.GithubButton.MouseLeave += new System.EventHandler(this.GithubButton_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(119, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = " © | All Rights Reserved";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // HideButton
            // 
            this.HideButton.BackColor = System.Drawing.Color.Transparent;
            this.HideButton.FlatAppearance.BorderSize = 0;
            this.HideButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HideButton.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.HideButton.ForeColor = System.Drawing.Color.White;
            this.HideButton.Location = new System.Drawing.Point(1043, 0);
            this.HideButton.Name = "HideButton";
            this.HideButton.Size = new System.Drawing.Size(62, 62);
            this.HideButton.TabIndex = 9;
            this.HideButton.Text = "–";
            this.HideButton.UseVisualStyleBackColor = false;
            this.HideButton.Click += new System.EventHandler(this.HideButton_Click);
            // 
            // PainterButton
            // 
            this.PainterButton.BackColor = System.Drawing.Color.Transparent;
            this.PainterButton.FlatAppearance.BorderSize = 0;
            this.PainterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PainterButton.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PainterButton.ForeColor = System.Drawing.Color.White;
            this.PainterButton.Location = new System.Drawing.Point(533, 17);
            this.PainterButton.Name = "PainterButton";
            this.PainterButton.Size = new System.Drawing.Size(175, 45);
            this.PainterButton.TabIndex = 5;
            this.PainterButton.Text = "PAINTER";
            this.PainterButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.PainterButton.UseVisualStyleBackColor = false;
            this.PainterButton.Click += new System.EventHandler(this.PainterButton_Click);
            this.PainterButton.MouseEnter += new System.EventHandler(this.PainterButton_MouseEnter);
            this.PainterButton.MouseLeave += new System.EventHandler(this.PainterButton_MouseLeave);
            // 
            // ProcessButton
            // 
            this.ProcessButton.BackColor = System.Drawing.Color.Transparent;
            this.ProcessButton.FlatAppearance.BorderSize = 0;
            this.ProcessButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProcessButton.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProcessButton.ForeColor = System.Drawing.Color.White;
            this.ProcessButton.Location = new System.Drawing.Point(360, 17);
            this.ProcessButton.Name = "ProcessButton";
            this.ProcessButton.Size = new System.Drawing.Size(175, 45);
            this.ProcessButton.TabIndex = 4;
            this.ProcessButton.Text = "PROCESS";
            this.ProcessButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ProcessButton.UseVisualStyleBackColor = false;
            this.ProcessButton.Click += new System.EventHandler(this.ProcessButton_Click);
            this.ProcessButton.MouseEnter += new System.EventHandler(this.ProcessButton_MouseEnter);
            this.ProcessButton.MouseLeave += new System.EventHandler(this.ProcessButton_MouseLeave);
            // 
            // FileButton
            // 
            this.FileButton.BackColor = System.Drawing.Color.Transparent;
            this.FileButton.FlatAppearance.BorderSize = 0;
            this.FileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FileButton.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileButton.ForeColor = System.Drawing.Color.White;
            this.FileButton.Location = new System.Drawing.Point(187, 17);
            this.FileButton.Name = "FileButton";
            this.FileButton.Size = new System.Drawing.Size(175, 45);
            this.FileButton.TabIndex = 1;
            this.FileButton.Text = "FILE";
            this.FileButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.FileButton.UseVisualStyleBackColor = false;
            this.FileButton.Click += new System.EventHandler(this.FileButton_Click);
            this.FileButton.MouseEnter += new System.EventHandler(this.FileButton_MouseEnter);
            this.FileButton.MouseLeave += new System.EventHandler(this.FileButton_MouseLeave);
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.Transparent;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CloseButton.ForeColor = System.Drawing.Color.White;
            this.CloseButton.Location = new System.Drawing.Point(1100, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(62, 62);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.Text = "×";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            this.CloseButton.MouseEnter += new System.EventHandler(this.CloseButton_MouseEnter);
            this.CloseButton.MouseLeave += new System.EventHandler(this.CloseButton_MouseLeave);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.ForeColor = System.Drawing.Color.Blue;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(157, 62);
            this.panel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Photomaker";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Black;
            this.imageList1.Images.SetKeyName(0, "Github_light_mark_24.png");
            this.imageList1.Images.SetKeyName(1, "Github_mark_24.png");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(157, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1003, 538);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // processPanelControl2
            // 
            this.processPanelControl2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.processPanelControl2.Location = new System.Drawing.Point(0, 0);
            this.processPanelControl2.Name = "processPanelControl2";
            this.processPanelControl2.Size = new System.Drawing.Size(157, 538);
            this.processPanelControl2.TabIndex = 1;
            // 
            // filePanelControl1
            // 
            this.filePanelControl1.BackColor = System.Drawing.Color.Transparent;
            this.filePanelControl1.Location = new System.Drawing.Point(0, 3);
            this.filePanelControl1.Name = "filePanelControl1";
            this.filePanelControl1.Size = new System.Drawing.Size(157, 538);
            this.filePanelControl1.TabIndex = 2;
            // 
            // PhotoMakerForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1160, 600);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PhotoMakerForm";
            this.Text = "PhotoMaker";
            this.Load += new System.EventHandler(this.PhotoMakerForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private DragControl dragControl1;
        private DragControl dragControl2;
        private System.Windows.Forms.Button FileButton;
        private System.Windows.Forms.Button PainterButton;
        private System.Windows.Forms.Button ProcessButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button GithubButton;
        private System.Windows.Forms.Button HideButton;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ImageList imageList1;
        private DragControl dragControl3;
        private DragControl dragControl4;
        private UserControls.FilePanelControl filePanelControl2;
        private PanelControls.ProcessPanelControl processPanelControl1;
        public System.Windows.Forms.PictureBox pictureBox1;
        private PanelControls.PainterPanelControl painterPanelControl1;
        private System.Windows.Forms.Button CloseButton;
        private PanelControls.PainterPanelControl painterPanelControl2;
        private UserControls.FilePanelControl filePanelControl1;
        private PanelControls.ProcessPanelControl processPanelControl2;
    }
}

