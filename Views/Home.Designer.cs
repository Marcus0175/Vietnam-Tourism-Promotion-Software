namespace App.Views
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            pictureBox2 = new PictureBox();
            menuStrip1 = new MenuStrip();
            btnDangNhap = new Button();
            btnDangKy = new Button();
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            btnKhamPha = new Button();
            ptbTrangChu = new PictureBox();
            btnTrangChu = new Label();
            btnCancel = new Button();
            pictureBox1 = new PictureBox();
            lbTroGiup = new Label();
            chatbot = new PictureBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbTrangChu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chatbot).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(90, 79);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Transparent;
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Location = new Point(470, 17);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(202, 24);
            menuStrip1.TabIndex = 17;
            menuStrip1.Text = "menuStrip1";
            // 
            // btnDangNhap
            // 
            btnDangNhap.BackColor = Color.Transparent;
            btnDangNhap.Cursor = Cursors.Hand;
            btnDangNhap.FlatStyle = FlatStyle.Flat;
            btnDangNhap.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDangNhap.ForeColor = Color.Black;
            btnDangNhap.Location = new Point(564, 15);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(162, 36);
            btnDangNhap.TabIndex = 18;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.TextAlign = ContentAlignment.MiddleRight;
            btnDangNhap.UseVisualStyleBackColor = false;
            btnDangNhap.Click += button2_Click;
            // 
            // btnDangKy
            // 
            btnDangKy.BackColor = Color.DodgerBlue;
            btnDangKy.Cursor = Cursors.Hand;
            btnDangKy.FlatAppearance.BorderSize = 0;
            btnDangKy.FlatStyle = FlatStyle.Flat;
            btnDangKy.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDangKy.ForeColor = Color.White;
            btnDangKy.Location = new Point(732, 15);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(104, 36);
            btnDangKy.TabIndex = 19;
            btnDangKy.Text = "Đăng ký\r\n";
            btnDangKy.UseVisualStyleBackColor = false;
            btnDangKy.Click += btnDangKy_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Location = new Point(0, 78);
            panel1.Name = "panel1";
            panel1.Size = new Size(875, 1);
            panel1.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Orange;
            label1.Location = new Point(39, 190);
            label1.Name = "label1";
            label1.Size = new Size(266, 88);
            label1.TabIndex = 21;
            label1.Text = "Khám phá\r\nĐông Nam Bộ\r\n";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gainsboro;
            panel2.Location = new Point(27, 281);
            panel2.Name = "panel2";
            panel2.Size = new Size(360, 1);
            panel2.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(27, 306);
            label2.Name = "label2";
            label2.Size = new Size(512, 88);
            label2.TabIndex = 23;
            label2.Text = resources.GetString("label2.Text");
            // 
            // btnKhamPha
            // 
            btnKhamPha.BackColor = Color.DodgerBlue;
            btnKhamPha.Cursor = Cursors.Hand;
            btnKhamPha.FlatAppearance.BorderSize = 0;
            btnKhamPha.FlatStyle = FlatStyle.Flat;
            btnKhamPha.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKhamPha.ForeColor = Color.White;
            btnKhamPha.Location = new Point(164, 407);
            btnKhamPha.Name = "btnKhamPha";
            btnKhamPha.Size = new Size(141, 54);
            btnKhamPha.TabIndex = 24;
            btnKhamPha.Text = "Khám phá";
            btnKhamPha.UseVisualStyleBackColor = false;
            btnKhamPha.Click += button5_Click;
            // 
            // ptbTrangChu
            // 
            ptbTrangChu.BackColor = Color.Transparent;
            ptbTrangChu.BackgroundImageLayout = ImageLayout.Center;
            ptbTrangChu.Image = (Image)resources.GetObject("ptbTrangChu.Image");
            ptbTrangChu.Location = new Point(310, 23);
            ptbTrangChu.Margin = new Padding(3, 2, 3, 2);
            ptbTrangChu.Name = "ptbTrangChu";
            ptbTrangChu.Size = new Size(33, 22);
            ptbTrangChu.SizeMode = PictureBoxSizeMode.Zoom;
            ptbTrangChu.TabIndex = 50;
            ptbTrangChu.TabStop = false;
            // 
            // btnTrangChu
            // 
            btnTrangChu.AutoSize = true;
            btnTrangChu.BackColor = Color.Transparent;
            btnTrangChu.Cursor = Cursors.Hand;
            btnTrangChu.FlatStyle = FlatStyle.Flat;
            btnTrangChu.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTrangChu.Location = new Point(348, 23);
            btnTrangChu.Name = "btnTrangChu";
            btnTrangChu.Size = new Size(105, 22);
            btnTrangChu.TabIndex = 51;
            btnTrangChu.Text = "Trang chủ";
            btnTrangChu.Click += label3_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Transparent;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Malgun Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(842, 0);
            btnCancel.Margin = new Padding(4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(33, 26);
            btnCancel.TabIndex = 106;
            btnCancel.Text = "X";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(570, 19);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(29, 26);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 107;
            pictureBox1.TabStop = false;
            // 
            // lbTroGiup
            // 
            lbTroGiup.AutoSize = true;
            lbTroGiup.BackColor = Color.Transparent;
            lbTroGiup.Cursor = Cursors.Hand;
            lbTroGiup.FlatStyle = FlatStyle.Flat;
            lbTroGiup.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTroGiup.Location = new Point(466, 23);
            lbTroGiup.Name = "lbTroGiup";
            lbTroGiup.Size = new Size(90, 22);
            lbTroGiup.TabIndex = 108;
            lbTroGiup.Text = "Trợ giúp";
            lbTroGiup.Click += lbTroGiup_Click_1;
            // 
            // chatbot
            // 
            chatbot.BackColor = Color.Transparent;
            chatbot.Cursor = Cursors.Hand;
            chatbot.Image = (Image)resources.GetObject("chatbot.Image");
            chatbot.Location = new Point(802, 446);
            chatbot.Margin = new Padding(3, 2, 3, 2);
            chatbot.Name = "chatbot";
            chatbot.Size = new Size(44, 40);
            chatbot.SizeMode = PictureBoxSizeMode.Zoom;
            chatbot.TabIndex = 109;
            chatbot.TabStop = false;
            chatbot.Click += chatbot_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.ForeColor = SystemColors.ActiveBorder;
            label5.Location = new Point(0, 481);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(136, 21);
            label5.TabIndex = 110;
            label5.Text = "© 2024-2024 NHÓM 10";
            label5.UseCompatibleTextRendering = true;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(872, 511);
            Controls.Add(label5);
            Controls.Add(chatbot);
            Controls.Add(lbTroGiup);
            Controls.Add(pictureBox1);
            Controls.Add(btnCancel);
            Controls.Add(btnTrangChu);
            Controls.Add(ptbTrangChu);
            Controls.Add(btnKhamPha);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(btnDangKy);
            Controls.Add(btnDangNhap);
            Controls.Add(menuStrip1);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            Load += Home_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbTrangChu).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)chatbot).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox2;
        private MenuStrip menuStrip1;
        private Button btnDangNhap;
        private Button btnDangKy;
        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private Button btnKhamPha;
        private PictureBox ptbTrangChu;
        private Label btnTrangChu;
        private Button btnCancel;
        private PictureBox pictureBox1;
        private Label lbTroGiup;
        private PictureBox chatbot;
        private Label label5;
    }
}