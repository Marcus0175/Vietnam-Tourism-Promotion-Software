namespace App.Views;

partial class DatMatKhauMoi
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatMatKhauMoi));
        pictureBox1 = new PictureBox();
        pictureBox2 = new PictureBox();
        label1 = new Label();
        label2 = new Label();
        textBox1 = new TextBox();
        panel1 = new Panel();
        labelMatKhauKhongKhop = new Label();
        textBox2 = new TextBox();
        btnDatLaiMatKhau = new Button();
        label10 = new Label();
        btnCancel = new Button();
        label9 = new Label();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
        panel1.SuspendLayout();
        SuspendLayout();
        // 
        // pictureBox1
        // 
        pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
        pictureBox1.Location = new Point(498, 0);
        pictureBox1.Margin = new Padding(4);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(472, 711);
        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureBox1.TabIndex = 2;
        pictureBox1.TabStop = false;
        // 
        // pictureBox2
        // 
        pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
        pictureBox2.Location = new Point(180, 116);
        pictureBox2.Margin = new Padding(4);
        pictureBox2.Name = "pictureBox2";
        pictureBox2.Size = new Size(132, 115);
        pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureBox2.TabIndex = 30;
        pictureBox2.TabStop = false;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label1.Location = new Point(110, 270);
        label1.Margin = new Padding(4, 0, 4, 0);
        label1.Name = "label1";
        label1.Size = new Size(288, 37);
        label1.TabIndex = 31;
        label1.Text = "Đặt mật khẩu mới";
        label1.Click += label1_Click;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label2.Location = new Point(165, 326);
        label2.Margin = new Padding(4, 0, 4, 0);
        label2.Name = "label2";
        label2.Size = new Size(175, 16);
        label2.TabIndex = 32;
        label2.Text = "Vui lòng nhập mật khẩu mới.\r\n";
        // 
        // textBox1
        // 
        textBox1.Font = new Font("Arial", 14F);
        textBox1.Location = new Point(14, 24);
        textBox1.Margin = new Padding(4);
        textBox1.Name = "textBox1";
        textBox1.PlaceholderText = "Mật khẩu mới";
        textBox1.Size = new Size(410, 29);
        textBox1.TabIndex = 33;
        textBox1.TextChanged += textBox1_TextChanged;
        // 
        // panel1
        // 
        panel1.BackColor = Color.WhiteSmoke;
        panel1.Controls.Add(labelMatKhauKhongKhop);
        panel1.Controls.Add(textBox2);
        panel1.Controls.Add(textBox1);
        panel1.Location = new Point(36, 362);
        panel1.Margin = new Padding(4);
        panel1.Name = "panel1";
        panel1.Size = new Size(438, 164);
        panel1.TabIndex = 39;
        panel1.Paint += panel1_Paint;
        // 
        // labelMatKhauKhongKhop
        // 
        labelMatKhauKhongKhop.AutoSize = true;
        labelMatKhauKhongKhop.Font = new Font("Arial", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
        labelMatKhauKhongKhop.ForeColor = Color.Red;
        labelMatKhauKhongKhop.Location = new Point(14, 138);
        labelMatKhauKhongKhop.Margin = new Padding(4, 0, 4, 0);
        labelMatKhauKhongKhop.Name = "labelMatKhauKhongKhop";
        labelMatKhauKhongKhop.Size = new Size(131, 15);
        labelMatKhauKhongKhop.TabIndex = 41;
        labelMatKhauKhongKhop.Text = "*Mật khẩu không khớp";
        // 
        // textBox2
        // 
        textBox2.Font = new Font("Arial", 14F);
        textBox2.Location = new Point(14, 110);
        textBox2.Margin = new Padding(4);
        textBox2.Name = "textBox2";
        textBox2.PlaceholderText = "Xác nhận mật khẩu";
        textBox2.Size = new Size(410, 29);
        textBox2.TabIndex = 39;
        textBox2.TextChanged += textBox2_TextChanged;
        // 
        // btnDatLaiMatKhau
        // 
        btnDatLaiMatKhau.BackColor = Color.DodgerBlue;
        btnDatLaiMatKhau.Cursor = Cursors.Hand;
        btnDatLaiMatKhau.FlatStyle = FlatStyle.Flat;
        btnDatLaiMatKhau.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btnDatLaiMatKhau.ForeColor = Color.White;
        btnDatLaiMatKhau.Location = new Point(180, 534);
        btnDatLaiMatKhau.Margin = new Padding(4);
        btnDatLaiMatKhau.Name = "btnDatLaiMatKhau";
        btnDatLaiMatKhau.Size = new Size(132, 36);
        btnDatLaiMatKhau.TabIndex = 40;
        btnDatLaiMatKhau.Text = "Đặt lại mật khẩu";
        btnDatLaiMatKhau.UseVisualStyleBackColor = false;
        btnDatLaiMatKhau.Click += btnDatLaiMatKhau_Click;
        // 
        // label10
        // 
        label10.AutoSize = true;
        label10.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label10.ForeColor = SystemColors.MenuHighlight;
        label10.Location = new Point(211, 599);
        label10.Margin = new Padding(4, 0, 4, 0);
        label10.Name = "label10";
        label10.Size = new Size(69, 16);
        label10.TabIndex = 42;
        label10.Text = "Đăng nhập";
        // 
        // btnCancel
        // 
        btnCancel.BackColor = Color.Red;
        btnCancel.FlatAppearance.BorderSize = 0;
        btnCancel.FlatStyle = FlatStyle.Flat;
        btnCancel.Font = new Font("Malgun Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnCancel.ForeColor = Color.White;
        btnCancel.Location = new Point(937, 0);
        btnCancel.Margin = new Padding(4);
        btnCancel.Name = "btnCancel";
        btnCancel.Size = new Size(33, 26);
        btnCancel.TabIndex = 43;
        btnCancel.Text = "X";
        btnCancel.UseVisualStyleBackColor = false;
        btnCancel.Click += btnCancel_Click;
        // 
        // label9
        // 
        label9.AutoSize = true;
        label9.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label9.ForeColor = Color.DodgerBlue;
        label9.Location = new Point(229, 581);
        label9.Margin = new Padding(4, 0, 4, 0);
        label9.Name = "label9";
        label9.Size = new Size(36, 15);
        label9.TabIndex = 41;
        label9.Text = "Hoặc";
        // 
        // DatMatKhauMoi
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.WhiteSmoke;
        ClientSize = new Size(970, 644);
        Controls.Add(btnCancel);
        Controls.Add(label10);
        Controls.Add(label9);
        Controls.Add(btnDatLaiMatKhau);
        Controls.Add(panel1);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(pictureBox2);
        Controls.Add(pictureBox1);
        FormBorderStyle = FormBorderStyle.None;
        Margin = new Padding(4);
        Name = "DatMatKhauMoi";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Datmkmoi";
        Load += DatMatKhauMoi_Load;
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.PictureBox pictureBox2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.Button btnDatLaiMatKhau;
    private System.Windows.Forms.Label label10;
    private Label labelMatKhauKhongKhop;
    private Button btnCancel;
    private Label label9;
}