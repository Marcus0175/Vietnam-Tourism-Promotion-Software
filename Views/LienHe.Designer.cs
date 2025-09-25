namespace HoTro
{
    partial class LienHe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LienHe));
            txtSubject = new TextBox();
            txtContent = new RichTextBox();
            btnSend = new Button();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            btnTat = new Button();
            lbSubject = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // txtSubject
            // 
            txtSubject.Location = new Point(85, 149);
            txtSubject.Name = "txtSubject";
            txtSubject.Size = new Size(593, 23);
            txtSubject.TabIndex = 7;
            // 
            // txtContent
            // 
            txtContent.Location = new Point(82, 219);
            txtContent.Name = "txtContent";
            txtContent.Size = new Size(593, 255);
            txtContent.TabIndex = 9;
            txtContent.Text = "";
            txtContent.TextChanged += txtContent_TextChanged;
            // 
            // btnSend
            // 
            btnSend.BackColor = Color.White;
            btnSend.Cursor = Cursors.Hand;
            btnSend.FlatAppearance.BorderSize = 0;
            btnSend.FlatStyle = FlatStyle.Flat;
            btnSend.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            btnSend.ForeColor = Color.FromArgb(0, 0, 192);
            btnSend.Location = new Point(693, 219);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(73, 42);
            btnSend.TabIndex = 10;
            btnSend.Text = "Gửi";
            btnSend.UseVisualStyleBackColor = false;
            btnSend.Click += btnSend_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(91, 81);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic);
            label1.ForeColor = Color.White;
            label1.Location = new Point(257, 44);
            label1.Name = "label1";
            label1.Size = new Size(286, 30);
            label1.TabIndex = 12;
            label1.Text = "Xin chào! Bạn cần hỗ trợ gì ?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(85, 186);
            label2.Name = "label2";
            label2.Size = new Size(349, 21);
            label2.TabIndex = 13;
            label2.Text = "Hãy nhập vấn đề bạn đang gặp phải ở đây nhé!";
            // 
            // btnTat
            // 
            btnTat.BackColor = Color.Red;
            btnTat.FlatStyle = FlatStyle.Flat;
            btnTat.Location = new Point(771, 0);
            btnTat.Name = "btnTat";
            btnTat.Size = new Size(29, 34);
            btnTat.TabIndex = 15;
            btnTat.Text = "X";
            btnTat.UseVisualStyleBackColor = false;
            btnTat.Click += btnTat_Click;
            // 
            // lbSubject
            // 
            lbSubject.AutoSize = true;
            lbSubject.BackColor = Color.Transparent;
            lbSubject.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lbSubject.ForeColor = Color.White;
            lbSubject.Location = new Point(85, 125);
            lbSubject.Name = "lbSubject";
            lbSubject.Size = new Size(68, 21);
            lbSubject.TabIndex = 8;
            lbSubject.Text = "Tiêu đề:";
            lbSubject.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LienHe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(802, 530);
            Controls.Add(btnTat);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(btnSend);
            Controls.Add(txtContent);
            Controls.Add(lbSubject);
            Controls.Add(txtSubject);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "LienHe";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += HoTro_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtSubject;
        private RichTextBox txtContent;
        private Button btnSend;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label2;
private Button btnTat;
        private Label lbSubject;
    }
}
