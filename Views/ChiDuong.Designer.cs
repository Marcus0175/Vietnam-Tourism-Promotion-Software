namespace App.Views;
partial class ChiDuong
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChiDuong));
        splitContainer1 = new SplitContainer();
        lbDiemDen = new Label();
        btnTimKiem = new Button();
        txtSearch = new TextBox();
        pictureBox2 = new PictureBox();
        btnTat = new Button();
        btnCancel = new Button();
        webView = new Microsoft.Web.WebView2.WinForms.WebView2();
        pictureBox1 = new PictureBox();
        ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
        splitContainer1.Panel1.SuspendLayout();
        splitContainer1.Panel2.SuspendLayout();
        splitContainer1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
        ((System.ComponentModel.ISupportInitialize)webView).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        SuspendLayout();
        // 
        // splitContainer1
        // 
        splitContainer1.Dock = DockStyle.Fill;
        splitContainer1.Location = new Point(0, 0);
        splitContainer1.Name = "splitContainer1";
        // 
        // splitContainer1.Panel1
        // 
        splitContainer1.Panel1.BackColor = Color.PaleTurquoise;
        splitContainer1.Panel1.Controls.Add(lbDiemDen);
        splitContainer1.Panel1.Controls.Add(btnTimKiem);
        splitContainer1.Panel1.Controls.Add(txtSearch);
        splitContainer1.Panel1.Controls.Add(pictureBox2);
        // 
        // splitContainer1.Panel2
        // 
        splitContainer1.Panel2.Controls.Add(btnTat);
        splitContainer1.Panel2.Controls.Add(btnCancel);
        splitContainer1.Panel2.Controls.Add(webView);
        splitContainer1.Panel2.Controls.Add(pictureBox1);
        splitContainer1.Size = new Size(970, 473);
        splitContainer1.SplitterDistance = 253;
        splitContainer1.TabIndex = 0;
        // 
        // lbDiemDen
        // 
        lbDiemDen.AutoSize = true;
        lbDiemDen.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
        lbDiemDen.ForeColor = Color.Black;
        lbDiemDen.Location = new Point(12, 257);
        lbDiemDen.Name = "lbDiemDen";
        lbDiemDen.Size = new Size(154, 21);
        lbDiemDen.TabIndex = 6;
        lbDiemDen.Text = "Hãy nhập điểm đến";
        // 
        // btnTimKiem
        // 
        btnTimKiem.BackColor = Color.DodgerBlue;
        btnTimKiem.Cursor = Cursors.Hand;
        btnTimKiem.FlatStyle = FlatStyle.Flat;
        btnTimKiem.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        btnTimKiem.ForeColor = Color.White;
        btnTimKiem.Location = new Point(146, 310);
        btnTimKiem.Name = "btnTimKiem";
        btnTimKiem.Size = new Size(91, 34);
        btnTimKiem.TabIndex = 5;
        btnTimKiem.Text = "Tìm kiếm";
        btnTimKiem.UseVisualStyleBackColor = false;
        btnTimKiem.Click += btnTimKiem_Click;
        btnTimKiem.Paint += btnTimKiem_Paint;
        // 
        // txtSearch
        // 
        txtSearch.Location = new Point(12, 281);
        txtSearch.Name = "txtSearch";
        txtSearch.Size = new Size(225, 23);
        txtSearch.TabIndex = 4;
        // 
        // pictureBox2
        // 
        pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
        pictureBox2.Location = new Point(0, 3);
        pictureBox2.Name = "pictureBox2";
        pictureBox2.Size = new Size(281, 207);
        pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureBox2.TabIndex = 3;
        pictureBox2.TabStop = false;
        // 
        // btnTat
        // 
        btnTat.BackColor = Color.Red;
        btnTat.FlatAppearance.BorderSize = 0;
        btnTat.FlatStyle = FlatStyle.Flat;
        btnTat.Font = new Font("Malgun Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnTat.ForeColor = Color.White;
        btnTat.Location = new Point(691, 0);
        btnTat.Margin = new Padding(4);
        btnTat.Name = "btnTat";
        btnTat.Size = new Size(22, 30);
        btnTat.TabIndex = 36;
        btnTat.Text = "X";
        btnTat.UseVisualStyleBackColor = false;
        btnTat.Click += btnTat_Click;
        // 
        // btnCancel
        // 
        btnCancel.BackColor = Color.Red;
        btnCancel.FlatStyle = FlatStyle.Flat;
        btnCancel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        btnCancel.ForeColor = Color.White;
        btnCancel.Location = new Point(770, 3);
        btnCancel.Name = "btnCancel";
        btnCancel.Size = new Size(23, 27);
        btnCancel.TabIndex = 2;
        btnCancel.Text = "X";
        btnCancel.UseVisualStyleBackColor = false;
        btnCancel.Click += btnCancel_Click;
        // 
        // webView
        // 
        webView.AllowExternalDrop = true;
        webView.CreationProperties = null;
        webView.DefaultBackgroundColor = Color.White;
        webView.Dock = DockStyle.Fill;
        webView.Location = new Point(0, 0);
        webView.Name = "webView";
        webView.Size = new Size(713, 473);
        webView.TabIndex = 1;
        webView.ZoomFactor = 1D;
        webView.Click += webView_Click;
        // 
        // pictureBox1
        // 
        pictureBox1.Dock = DockStyle.Fill;
        pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
        pictureBox1.Location = new Point(0, 0);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(713, 473);
        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureBox1.TabIndex = 0;
        pictureBox1.TabStop = false;
        // 
        // ChiDuong
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(970, 473);
        Controls.Add(splitContainer1);
        FormBorderStyle = FormBorderStyle.None;
        Name = "ChiDuong";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Form1";
        Load += Form1_Load;
        splitContainer1.Panel1.ResumeLayout(false);
        splitContainer1.Panel1.PerformLayout();
        splitContainer1.Panel2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
        splitContainer1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
        ((System.ComponentModel.ISupportInitialize)webView).EndInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private SplitContainer splitContainer1;
    private PictureBox pictureBox2;
    private Microsoft.Web.WebView2.WinForms.WebView2 webView;
    private PictureBox pictureBox1;
    private Button btnTimKiem;
    private TextBox txtSearch;
    private Label lbDiemDen;
    private Button btnCancel;
    private Button btnTat;
}
