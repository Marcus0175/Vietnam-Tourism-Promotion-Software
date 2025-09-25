namespace App.Views
{
    partial class DangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangNhap));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            lbDangKy = new Label();
            textBoxEmail = new TextBox();
            textBoxMatKhau = new TextBox();
            btnDangNhap = new Button();
            label4 = new Label();
            label6 = new Label();
            pictureBox2 = new PictureBox();
            labelLoiEmail = new Label();
            labelLoiMatKhau = new Label();
            label9 = new Label();
            label10 = new Label();
            checkBoxHienMatKhau = new CheckBox();
            label5 = new Label();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(489, 1);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(490, 631);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(152, 149);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(169, 37);
            label1.TabIndex = 1;
            label1.Text = "Xin chào !";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(111, 219);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(195, 18);
            label2.TabIndex = 2;
            label2.Text = "Bạn đã có tài khoản chưa?";
            // 
            // lbDangKy
            // 
            lbDangKy.AutoSize = true;
            lbDangKy.Cursor = Cursors.Hand;
            lbDangKy.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbDangKy.ForeColor = Color.DodgerBlue;
            lbDangKy.Location = new Point(330, 219);
            lbDangKy.Margin = new Padding(4, 0, 4, 0);
            lbDangKy.Name = "lbDangKy";
            lbDangKy.Size = new Size(65, 18);
            lbDangKy.TabIndex = 3;
            lbDangKy.Text = "Đăng ký";
            lbDangKy.Click += lbDangKy_Click;
            // 
            // textBoxEmail
            // 
            textBoxEmail.BorderStyle = BorderStyle.None;
            textBoxEmail.Font = new Font("Arial", 14F);
            textBoxEmail.Location = new Point(47, 286);
            textBoxEmail.Margin = new Padding(0, 10, 0, 0);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.PlaceholderText = "Email";
            textBoxEmail.Size = new Size(410, 22);
            textBoxEmail.TabIndex = 4;
            textBoxEmail.TextChanged += textBoxEmail_TextChanged;
            // 
            // textBoxMatKhau
            // 
            textBoxMatKhau.BorderStyle = BorderStyle.None;
            textBoxMatKhau.Font = new Font("Arial", 14F);
            textBoxMatKhau.Location = new Point(47, 353);
            textBoxMatKhau.Margin = new Padding(0, 10, 0, 0);
            textBoxMatKhau.Name = "textBoxMatKhau";
            textBoxMatKhau.PlaceholderText = "Mật khẩu";
            textBoxMatKhau.Size = new Size(410, 22);
            textBoxMatKhau.TabIndex = 5;
            textBoxMatKhau.UseSystemPasswordChar = true;
            // 
            // btnDangNhap
            // 
            btnDangNhap.BackColor = Color.DeepSkyBlue;
            btnDangNhap.BackgroundImageLayout = ImageLayout.None;
            btnDangNhap.Cursor = Cursors.Hand;
            btnDangNhap.FlatStyle = FlatStyle.Flat;
            btnDangNhap.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDangNhap.ForeColor = SystemColors.ButtonHighlight;
            btnDangNhap.Location = new Point(183, 446);
            btnDangNhap.Margin = new Padding(0);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(122, 45);
            btnDangNhap.TabIndex = 6;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = false;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(62, 291);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(0, 17);
            label4.TabIndex = 7;
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(218, 514);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(44, 18);
            label6.TabIndex = 9;
            label6.Text = "Hoặc";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(183, 14);
            pictureBox2.Margin = new Padding(4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(132, 115);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 19;
            pictureBox2.TabStop = false;
            // 
            // labelLoiEmail
            // 
            labelLoiEmail.AutoSize = true;
            labelLoiEmail.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            labelLoiEmail.ForeColor = Color.Red;
            labelLoiEmail.Location = new Point(47, 321);
            labelLoiEmail.Margin = new Padding(2, 0, 2, 0);
            labelLoiEmail.Name = "labelLoiEmail";
            labelLoiEmail.Size = new Size(114, 15);
            labelLoiEmail.TabIndex = 20;
            labelLoiEmail.Text = "*Email không tồn tại";
            // 
            // labelLoiMatKhau
            // 
            labelLoiMatKhau.AutoSize = true;
            labelLoiMatKhau.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            labelLoiMatKhau.ForeColor = Color.Red;
            labelLoiMatKhau.Location = new Point(47, 388);
            labelLoiMatKhau.Margin = new Padding(2, 0, 2, 0);
            labelLoiMatKhau.Name = "labelLoiMatKhau";
            labelLoiMatKhau.Size = new Size(151, 15);
            labelLoiMatKhau.TabIndex = 21;
            labelLoiMatKhau.Text = "*Mật khẩu không chính xác";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(432, 312);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(0, 15);
            label9.TabIndex = 22;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.DodgerBlue;
            label10.Location = new Point(191, 546);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(103, 16);
            label10.TabIndex = 23;
            label10.Text = "Quên mật khẩu?";
            label10.Click += label10_Click;
            // 
            // checkBoxHienMatKhau
            // 
            checkBoxHienMatKhau.AutoSize = true;
            checkBoxHienMatKhau.Location = new Point(47, 420);
            checkBoxHienMatKhau.Margin = new Padding(2);
            checkBoxHienMatKhau.Name = "checkBoxHienMatKhau";
            checkBoxHienMatKhau.Size = new Size(104, 19);
            checkBoxHienMatKhau.TabIndex = 24;
            checkBoxHienMatKhau.Text = "Hiện mật khẩu";
            checkBoxHienMatKhau.UseVisualStyleBackColor = true;
            checkBoxHienMatKhau.CheckedChanged += checkBoxHienMatKhau_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ActiveBorder;
            label5.Location = new Point(1, 604);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(136, 21);
            label5.TabIndex = 28;
            label5.Text = "© 2024-2024 NHÓM 10";
            label5.UseCompatibleTextRendering = true;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Red;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Malgun Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(937, 1);
            btnCancel.Margin = new Padding(4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(33, 26);
            btnCancel.TabIndex = 35;
            btnCancel.Text = "X";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // DangNhap
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(970, 624);
            Controls.Add(btnCancel);
            Controls.Add(label5);
            Controls.Add(checkBoxHienMatKhau);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(labelLoiMatKhau);
            Controls.Add(labelLoiEmail);
            Controls.Add(pictureBox2);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(btnDangNhap);
            Controls.Add(textBoxMatKhau);
            Controls.Add(textBoxEmail);
            Controls.Add(lbDangKy);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "DangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            Load += DangNhap_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbDangKy;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxMatKhau;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Label labelLoiEmail;
        private Label labelLoiMatKhau;
        private Label label9;
        private Label label10;
        private CheckBox checkBoxHienMatKhau;
        private Label label5;
        private Button btnCancel;
    }
}

