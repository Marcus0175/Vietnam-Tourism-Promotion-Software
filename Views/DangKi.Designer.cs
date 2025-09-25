namespace App.Views
{
    partial class DangKi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangKi));
            lbDangNhap = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            btnDangKy = new Button();
            textBoxMatKhau = new TextBox();
            textBoxEmail = new TextBox();
            pictureBox2 = new PictureBox();
            textBoxXacNhanMatKhau = new TextBox();
            checkBoxHienMatKhau = new CheckBox();
            textBoxMaXacNhan = new TextBox();
            btnGuiMa = new Button();
            labelEmailKhongHopLe = new Label();
            labelMatKhauKhongTrungKhop = new Label();
            label5 = new Label();
            labelMaXacNhanKhongChinhXac = new Label();
            labelMaXacNhanDaGui = new Label();
            labelMatKhauTrong = new Label();
            btnCancel = new Button();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // lbDangNhap
            // 
            lbDangNhap.AutoSize = true;
            lbDangNhap.Cursor = Cursors.Hand;
            lbDangNhap.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbDangNhap.ForeColor = Color.DodgerBlue;
            lbDangNhap.Location = new Point(330, 219);
            lbDangNhap.Margin = new Padding(4, 0, 4, 0);
            lbDangNhap.Name = "lbDangNhap";
            lbDangNhap.Size = new Size(84, 18);
            lbDangNhap.TabIndex = 6;
            lbDangNhap.Text = "Đăng nhập";
            lbDangNhap.Click += lbDangNhap_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(111, 219);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(195, 18);
            label2.TabIndex = 5;
            label2.Text = "Bạn đã có tài khoản chưa?";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(152, 149);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(169, 37);
            label1.TabIndex = 4;
            label1.Text = "Xin chào !";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(495, -1);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(499, 781);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(76, 284);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(0, 17);
            label4.TabIndex = 14;
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnDangKy
            // 
            btnDangKy.BackColor = Color.DeepSkyBlue;
            btnDangKy.BackgroundImageLayout = ImageLayout.None;
            btnDangKy.Cursor = Cursors.Hand;
            btnDangKy.FlatAppearance.BorderSize = 0;
            btnDangKy.FlatStyle = FlatStyle.Flat;
            btnDangKy.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDangKy.ForeColor = SystemColors.ButtonHighlight;
            btnDangKy.Location = new Point(188, 589);
            btnDangKy.Margin = new Padding(0);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(122, 45);
            btnDangKy.TabIndex = 13;
            btnDangKy.Text = "Đăng ký";
            btnDangKy.UseVisualStyleBackColor = false;
            btnDangKy.Click += btnDangKy_Click;
            // 
            // textBoxMatKhau
            // 
            textBoxMatKhau.BorderStyle = BorderStyle.None;
            textBoxMatKhau.Font = new Font("Arial", 14F);
            textBoxMatKhau.Location = new Point(61, 324);
            textBoxMatKhau.Margin = new Padding(0, 10, 0, 0);
            textBoxMatKhau.Name = "textBoxMatKhau";
            textBoxMatKhau.PlaceholderText = "Mật khẩu";
            textBoxMatKhau.Size = new Size(410, 22);
            textBoxMatKhau.TabIndex = 12;
            textBoxMatKhau.UseSystemPasswordChar = true;
            // 
            // textBoxEmail
            // 
            textBoxEmail.BackColor = Color.White;
            textBoxEmail.BorderStyle = BorderStyle.None;
            textBoxEmail.Font = new Font("Arial", 14F);
            textBoxEmail.Location = new Point(61, 264);
            textBoxEmail.Margin = new Padding(0, 10, 0, 0);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.PlaceholderText = "Email đăng kí";
            textBoxEmail.Size = new Size(410, 22);
            textBoxEmail.TabIndex = 11;
            textBoxEmail.TextChanged += textBoxEmail_TextChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(188, 14);
            pictureBox2.Margin = new Padding(4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(132, 115);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            // 
            // textBoxXacNhanMatKhau
            // 
            textBoxXacNhanMatKhau.BorderStyle = BorderStyle.None;
            textBoxXacNhanMatKhau.Font = new Font("Arial", 14F);
            textBoxXacNhanMatKhau.Location = new Point(61, 393);
            textBoxXacNhanMatKhau.Margin = new Padding(0, 10, 0, 0);
            textBoxXacNhanMatKhau.Name = "textBoxXacNhanMatKhau";
            textBoxXacNhanMatKhau.PlaceholderText = "Xác nhận mật khẩu";
            textBoxXacNhanMatKhau.Size = new Size(410, 22);
            textBoxXacNhanMatKhau.TabIndex = 19;
            textBoxXacNhanMatKhau.UseSystemPasswordChar = true;
            textBoxXacNhanMatKhau.TextChanged += textBoxXacNhanMatKhau_TextChanged;
            // 
            // checkBoxHienMatKhau
            // 
            checkBoxHienMatKhau.AutoSize = true;
            checkBoxHienMatKhau.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBoxHienMatKhau.Location = new Point(61, 548);
            checkBoxHienMatKhau.Margin = new Padding(4);
            checkBoxHienMatKhau.Name = "checkBoxHienMatKhau";
            checkBoxHienMatKhau.Size = new Size(120, 21);
            checkBoxHienMatKhau.TabIndex = 21;
            checkBoxHienMatKhau.Text = "Hiện mật khẩu";
            checkBoxHienMatKhau.UseVisualStyleBackColor = true;
            checkBoxHienMatKhau.CheckedChanged += checkBoxHienMatKhau_CheckedChanged;
            // 
            // textBoxMaXacNhan
            // 
            textBoxMaXacNhan.BorderStyle = BorderStyle.None;
            textBoxMaXacNhan.Font = new Font("Arial", 14F);
            textBoxMaXacNhan.Location = new Point(61, 469);
            textBoxMaXacNhan.Margin = new Padding(0, 10, 0, 0);
            textBoxMaXacNhan.Name = "textBoxMaXacNhan";
            textBoxMaXacNhan.PlaceholderText = "Mã xác nhận";
            textBoxMaXacNhan.Size = new Size(179, 22);
            textBoxMaXacNhan.TabIndex = 22;
            textBoxMaXacNhan.TextAlign = HorizontalAlignment.Center;
            textBoxMaXacNhan.TextChanged += textBoxMaXacNhan_TextChanged;
            textBoxMaXacNhan.KeyPress += textBoxMaXacNhan_KeyPress;
            // 
            // btnGuiMa
            // 
            btnGuiMa.BackColor = Color.DeepSkyBlue;
            btnGuiMa.BackgroundImageLayout = ImageLayout.None;
            btnGuiMa.Cursor = Cursors.Hand;
            btnGuiMa.FlatAppearance.BorderSize = 0;
            btnGuiMa.FlatStyle = FlatStyle.Flat;
            btnGuiMa.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuiMa.ForeColor = SystemColors.ButtonHighlight;
            btnGuiMa.Location = new Point(258, 469);
            btnGuiMa.Margin = new Padding(0);
            btnGuiMa.Name = "btnGuiMa";
            btnGuiMa.Size = new Size(81, 31);
            btnGuiMa.TabIndex = 23;
            btnGuiMa.Text = "Gửi mã";
            btnGuiMa.UseVisualStyleBackColor = false;
            btnGuiMa.Click += btnGuiMa_Click;
            // 
            // labelEmailKhongHopLe
            // 
            labelEmailKhongHopLe.AutoSize = true;
            labelEmailKhongHopLe.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            labelEmailKhongHopLe.ForeColor = Color.Red;
            labelEmailKhongHopLe.Location = new Point(61, 299);
            labelEmailKhongHopLe.Margin = new Padding(2, 0, 2, 0);
            labelEmailKhongHopLe.Name = "labelEmailKhongHopLe";
            labelEmailKhongHopLe.Size = new Size(113, 15);
            labelEmailKhongHopLe.TabIndex = 24;
            labelEmailKhongHopLe.Text = "*Email không hợp lệ";
            // 
            // labelMatKhauKhongTrungKhop
            // 
            labelMatKhauKhongTrungKhop.AutoSize = true;
            labelMatKhauKhongTrungKhop.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            labelMatKhauKhongTrungKhop.ForeColor = Color.Red;
            labelMatKhauKhongTrungKhop.Location = new Point(61, 434);
            labelMatKhauKhongTrungKhop.Margin = new Padding(2, 0, 2, 0);
            labelMatKhauKhongTrungKhop.Name = "labelMatKhauKhongTrungKhop";
            labelMatKhauKhongTrungKhop.Size = new Size(161, 15);
            labelMatKhauKhongTrungKhop.TabIndex = 25;
            labelMatKhauKhongTrungKhop.Text = "*Mật khẩu không trùng khớp";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ActiveBorder;
            label5.Location = new Point(-1, 765);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(130, 15);
            label5.TabIndex = 27;
            label5.Text = "© 2024-2024 NHÓM 10";
            // 
            // labelMaXacNhanKhongChinhXac
            // 
            labelMaXacNhanKhongChinhXac.AutoSize = true;
            labelMaXacNhanKhongChinhXac.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            labelMaXacNhanKhongChinhXac.ForeColor = Color.Red;
            labelMaXacNhanKhongChinhXac.Location = new Point(61, 500);
            labelMaXacNhanKhongChinhXac.Margin = new Padding(2, 0, 2, 0);
            labelMaXacNhanKhongChinhXac.Name = "labelMaXacNhanKhongChinhXac";
            labelMaXacNhanKhongChinhXac.Size = new Size(168, 15);
            labelMaXacNhanKhongChinhXac.TabIndex = 26;
            labelMaXacNhanKhongChinhXac.Text = "*Mã xác nhận không chính xác";
            // 
            // labelMaXacNhanDaGui
            // 
            labelMaXacNhanDaGui.AutoSize = true;
            labelMaXacNhanDaGui.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            labelMaXacNhanDaGui.ForeColor = Color.Black;
            labelMaXacNhanDaGui.Location = new Point(61, 500);
            labelMaXacNhanDaGui.Margin = new Padding(2, 0, 2, 0);
            labelMaXacNhanDaGui.Name = "labelMaXacNhanDaGui";
            labelMaXacNhanDaGui.Size = new Size(278, 45);
            labelMaXacNhanDaGui.TabIndex = 28;
            labelMaXacNhanDaGui.Text = "Mã xác nhận đã được gửi\nNếu không thấy email, vui lòng kiểm tra mục spam \nhoặc kiểm tra lại địa chỉ email của bạn";
            // 
            // labelMatKhauTrong
            // 
            labelMatKhauTrong.AutoSize = true;
            labelMatKhauTrong.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            labelMatKhauTrong.ForeColor = Color.Red;
            labelMatKhauTrong.Location = new Point(61, 368);
            labelMatKhauTrong.Margin = new Padding(2, 0, 2, 0);
            labelMatKhauTrong.Name = "labelMatKhauTrong";
            labelMatKhauTrong.Size = new Size(176, 15);
            labelMatKhauTrong.TabIndex = 29;
            labelMatKhauTrong.Text = "*Không được để trống mật khẩu";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Red;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Malgun Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(938, -1);
            btnCancel.Margin = new Padding(4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(33, 26);
            btnCancel.TabIndex = 35;
            btnCancel.Text = "X";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ActiveBorder;
            label3.Location = new Point(2, 643);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(136, 21);
            label3.TabIndex = 36;
            label3.Text = "© 2024-2024 NHÓM 10";
            label3.UseCompatibleTextRendering = true;
            // 
            // DangKi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(970, 665);
            Controls.Add(label3);
            Controls.Add(btnCancel);
            Controls.Add(labelMatKhauTrong);
            Controls.Add(labelMaXacNhanDaGui);
            Controls.Add(label5);
            Controls.Add(labelMaXacNhanKhongChinhXac);
            Controls.Add(labelMatKhauKhongTrungKhop);
            Controls.Add(labelEmailKhongHopLe);
            Controls.Add(btnGuiMa);
            Controls.Add(textBoxMaXacNhan);
            Controls.Add(checkBoxHienMatKhau);
            Controls.Add(textBoxXacNhanMatKhau);
            Controls.Add(pictureBox2);
            Controls.Add(label4);
            Controls.Add(btnDangKy);
            Controls.Add(textBoxMatKhau);
            Controls.Add(textBoxEmail);
            Controls.Add(pictureBox1);
            Controls.Add(lbDangNhap);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "DangKi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dangki";
            Load += dangKiLoad;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void TextBoxMaXacNhan_KeyPress(object sender, KeyPressEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void DangKi_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label lbDangNhap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.TextBox textBoxMatKhau;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBoxXacNhanMatKhau;
        private System.Windows.Forms.CheckBox checkBoxHienMatKhau;
        private TextBox textBoxMaXacNhan;
        private Button btnGuiMa;
        private Label labelEmailKhongHopLe;
        private Label labelMatKhauKhongTrungKhop;
        private Label label5;
        private Label labelMaXacNhanKhongChinhXac;
        private Label labelMaXacNhanDaGui;
        private Label labelMatKhauTrong;
        private Button btnCancel;
        private Label label3;
    }
}