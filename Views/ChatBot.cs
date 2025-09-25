using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using FuzzySharp;
using App.Controllers;
using App.Utilities;
using System.Runtime.InteropServices;

namespace Chatbot
{
    public partial class ChatBot : Form
    {
        private DatabaseHelper _dbHelper;

        public ChatBot()
        {
            InitializeComponent();

            string connectionString = @"Server=mssql-187909-0.cloudclusters.net,10012;Database=ChatBot;User Id=admin;Password=Admin123;";

            _dbHelper = new DatabaseHelper(connectionString);

            txtQuestion.KeyDown += TxtQuestion_KeyDown;
        }

        private void TxtQuestion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAsk.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAsk_Click(object sender, EventArgs e)
        {
            string userQuestion = txtQuestion.Text.Trim();
            if (string.IsNullOrEmpty(userQuestion))
            {
                MessageBox.Show("Vui lòng nhập câu hỏi!");
                return;
            }

            var allQuestions = _dbHelper.GetAllQuestions();
            var bestMatch = FindBestMatch(userQuestion, allQuestions);

            if (!string.IsNullOrEmpty(bestMatch))
            {
                string answer = _dbHelper.GetAnswer(bestMatch);
                AppendToChat($"Ban: {userQuestion}");
                AppendToChat($"Bot: {answer}");
                AppendToChat("");
            }
            else
            {
                AppendToChat($"Ban: {userQuestion}");
                AppendToChat("Bot: Tôi không thể trả lời câu hỏi này. Bạn hãy chỉ cho tôi nhé! ");
                AppendToChat("");

                string newAnswer = Microsoft.VisualBasic.Interaction.InputBox(
                    "Bạn có thể gõ 'Cancel' để bỏ qua:",
                    "Hãy thêm câu trả lời:",
                    "");

                if (!string.IsNullOrEmpty(newAnswer))
                {
                    _dbHelper.AddQuestion(userQuestion, newAnswer);
                    AppendToChat("Bot: Nếu bạn cần thêm sự trợ giúp, hãy hỏi tôi nhé!");
                }
            }

            txtQuestion.Clear();
        }

        private void AppendToChat(string message)
        {
            rtbChat.AppendText(message + Environment.NewLine);
            rtbChat.SelectionStart = rtbChat.Text.Length;
            rtbChat.ScrollToCaret();
        }

        private string FindBestMatch(string userQuestion, List<string> questions)
        {
            string bestMatch = null;
            int bestScore = 0;

            foreach (var question in questions)
            {
                int score = Fuzz.Ratio(userQuestion, question);

                if (score >= 70 && score > bestScore)
                {
                    bestScore = score;
                    bestMatch = question;
                }
            }

            return bestMatch;
        }
        private void rtbChat_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQuestion_TextChanged(object sender, EventArgs e)
        {

        }

        private void ChatBot_Load(object sender, EventArgs e)
        {
           
        }

        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
