namespace App.Views
{
    partial class QuenMatKhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuenMatKhau));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            btnGuiMa = new Button();
            label4 = new Label();
            label5 = new Label();
            textBox2 = new TextBox();
            labelKhongTimThayTaiKhoan = new Label();
            labelMaXacNhanKhongChinhXac = new Label();
            labelDaGuiMaXacNhan = new Label();
            btnXacNhan = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(478, 0);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(497, 647);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(175, 92);
            pictureBox2.Margin = new Padding(4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(132, 115);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 20;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(118, 239);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(275, 37);
            label1.TabIndex = 21;
            label1.Text = "Quên mật khẩu ?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(89, 286);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(336, 32);
            label2.TabIndex = 22;
            label2.Text = "Hãy nhập email của bạn và bạn sẽ nhận được mã để đặt\r\n                               mật khẩu mới ";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Arial", 14F);
            textBox1.Location = new Point(33, 354);
            textBox1.Margin = new Padding(4);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Email";
            textBox1.Size = new Size(410, 29);
            textBox1.TabIndex = 23;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // btnGuiMa
            // 
            btnGuiMa.BackColor = Color.DodgerBlue;
            btnGuiMa.FlatStyle = FlatStyle.Flat;
            btnGuiMa.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuiMa.ForeColor = Color.White;
            btnGuiMa.Location = new Point(329, 463);
            btnGuiMa.Margin = new Padding(4);
            btnGuiMa.Name = "btnGuiMa";
            btnGuiMa.Size = new Size(114, 36);
            btnGuiMa.TabIndex = 25;
            btnGuiMa.Text = "Gửi mã OTP";
            btnGuiMa.UseVisualStyleBackColor = false;
            btnGuiMa.Click += btnGuiMa_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.MenuHighlight;
            label4.Location = new Point(188, 601);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(119, 16);
            label4.TabIndex = 26;
            label4.Text = "Quay lại đăng nhập";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Red;
            label5.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(948, 0);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(23, 22);
            label5.TabIndex = 27;
            label5.Text = "X";
            label5.Click += label5_Click;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Arial", 14F);
            textBox2.Location = new Point(33, 463);
            textBox2.Margin = new Padding(4);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Mã xác nhận";
            textBox2.Size = new Size(274, 29);
            textBox2.TabIndex = 28;
            textBox2.TextChanged += textBox2_TextChanged;
            textBox2.KeyPress += textBox2_KeyPress;
            // 
            // labelKhongTimThayTaiKhoan
            // 
            labelKhongTimThayTaiKhoan.AutoSize = true;
            labelKhongTimThayTaiKhoan.BackColor = SystemColors.Window;
            labelKhongTimThayTaiKhoan.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            labelKhongTimThayTaiKhoan.ForeColor = Color.Red;
            labelKhongTimThayTaiKhoan.Location = new Point(33, 387);
            labelKhongTimThayTaiKhoan.Margin = new Padding(2, 0, 2, 0);
            labelKhongTimThayTaiKhoan.Name = "labelKhongTimThayTaiKhoan";
            labelKhongTimThayTaiKhoan.Size = new Size(146, 15);
            labelKhongTimThayTaiKhoan.TabIndex = 30;
            labelKhongTimThayTaiKhoan.Text = "*Không tìm thấy tài khoản";
            // 
            // labelMaXacNhanKhongChinhXac
            // 
            labelMaXacNhanKhongChinhXac.AutoSize = true;
            labelMaXacNhanKhongChinhXac.BackColor = SystemColors.Window;
            labelMaXacNhanKhongChinhXac.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            labelMaXacNhanKhongChinhXac.ForeColor = Color.Red;
            labelMaXacNhanKhongChinhXac.Location = new Point(33, 500);
            labelMaXacNhanKhongChinhXac.Margin = new Padding(2, 0, 2, 0);
            labelMaXacNhanKhongChinhXac.Name = "labelMaXacNhanKhongChinhXac";
            labelMaXacNhanKhongChinhXac.Size = new Size(168, 15);
            labelMaXacNhanKhongChinhXac.TabIndex = 31;
            labelMaXacNhanKhongChinhXac.Text = "*Mã xác nhận không chính xác";
            // 
            // labelDaGuiMaXacNhan
            // 
            labelDaGuiMaXacNhan.AutoSize = true;
            labelDaGuiMaXacNhan.BackColor = SystemColors.Window;
            labelDaGuiMaXacNhan.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            labelDaGuiMaXacNhan.ForeColor = SystemColors.ControlText;
            labelDaGuiMaXacNhan.Location = new Point(33, 515);
            labelDaGuiMaXacNhan.Margin = new Padding(2, 0, 2, 0);
            labelDaGuiMaXacNhan.Name = "labelDaGuiMaXacNhan";
            labelDaGuiMaXacNhan.Size = new Size(240, 15);
            labelDaGuiMaXacNhan.TabIndex = 32;
            labelDaGuiMaXacNhan.Text = "Đã gửi mã xác nhận, vui lòng kiểm tra email";
            // 
            // btnXacNhan
            // 
            btnXacNhan.BackColor = Color.DodgerBlue;
            btnXacNhan.FlatStyle = FlatStyle.Flat;
            btnXacNhan.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXacNhan.ForeColor = Color.White;
            btnXacNhan.Location = new Point(202, 549);
            btnXacNhan.Margin = new Padding(4);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.Size = new Size(91, 48);
            btnXacNhan.TabIndex = 33;
            btnXacNhan.Text = "Xác nhận";
            btnXacNhan.UseVisualStyleBackColor = false;
            btnXacNhan.Click += btnXacNhan_Click;
            // 
            // QuenMatKhau
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(971, 632);
            Controls.Add(btnXacNhan);
            Controls.Add(labelDaGuiMaXacNhan);
            Controls.Add(labelMaXacNhanKhongChinhXac);
            Controls.Add(labelKhongTimThayTaiKhoan);
            Controls.Add(textBox2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btnGuiMa);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "QuenMatKhau";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quenmk";
            Load += Quenmk_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnGuiMa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private TextBox textBox2;
        private Label labelKhongTimThayTaiKhoan;
        private Label labelMaXacNhanKhongChinhXac;
        private Label labelDaGuiMaXacNhan;
        private Button btnXacNhan;
    }
}