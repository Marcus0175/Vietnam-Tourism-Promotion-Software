namespace Chatbot
{
    partial class ChatBot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatBot));
            panel1 = new Panel();
            label1 = new Label();
            btnCancel = new Button();
            rtbChat = new RichTextBox();
            btnAsk = new Button();
            txtQuestion = new TextBox();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(rtbChat);
            panel1.Controls.Add(btnAsk);
            panel1.Controls.Add(txtQuestion);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(589, 382);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold | FontStyle.Italic);
            label1.ForeColor = Color.White;
            label1.Location = new Point(211, 20);
            label1.Name = "label1";
            label1.Size = new Size(197, 24);
            label1.TabIndex = 5;
            label1.Text = "Bạn cần trợ giúp gì ?";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Red;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(567, 0);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(22, 23);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "X";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // rtbChat
            // 
            rtbChat.Location = new Point(90, 63);
            rtbChat.Name = "rtbChat";
            rtbChat.Size = new Size(433, 240);
            rtbChat.TabIndex = 2;
            rtbChat.Text = "";
            rtbChat.TextChanged += rtbChat_TextChanged;
            // 
            // btnAsk
            // 
            btnAsk.BackColor = Color.Aqua;
            btnAsk.BackgroundImage = (Image)resources.GetObject("btnAsk.BackgroundImage");
            btnAsk.BackgroundImageLayout = ImageLayout.Stretch;
            btnAsk.FlatStyle = FlatStyle.Flat;
            btnAsk.ForeColor = SystemColors.Desktop;
            btnAsk.Location = new Point(504, 327);
            btnAsk.Name = "btnAsk";
            btnAsk.Size = new Size(42, 24);
            btnAsk.TabIndex = 1;
            btnAsk.UseVisualStyleBackColor = false;
            btnAsk.Click += btnAsk_Click;
            // 
            // txtQuestion
            // 
            txtQuestion.Location = new Point(90, 329);
            txtQuestion.Name = "txtQuestion";
            txtQuestion.Size = new Size(387, 23);
            txtQuestion.TabIndex = 0;
            txtQuestion.TextChanged += txtQuestion_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(84, 78);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // ChatBot
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(589, 382);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ChatBot";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += ChatBot_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private RichTextBox rtbChat;
        private Button btnAsk;
        private TextBox txtQuestion;
        private Button btnCancel;
        private Label label1;
        private PictureBox pictureBox1;
    }
}
