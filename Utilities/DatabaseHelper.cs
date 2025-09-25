using System;
using System.Collections.Generic;
using System.Data.SqlClient;

public class DatabaseHelper
{
    private readonly string _connectionString;

    public DatabaseHelper(string connectionString)
    {
        _connectionString = connectionString;
    }

    public void AddQuestion(string question, string answer)
    {
        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
            connection.Open();
            string query = "INSERT INTO Questions (Question, Answer) VALUES (@Question, @Answer)";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@Question", question);
            cmd.Parameters.AddWithValue("@Answer", answer);
            cmd.ExecuteNonQuery();
        }
    }

    public string GetAnswer(string question)
    {
        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
            connection.Open();
            string query = "SELECT Answer FROM Questions WHERE Question = @Question";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@Question", question);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return reader["Answer"].ToString();
            }
        }
        return null;
    }

    public List<string> GetAllQuestions()
    {
        List<string> questions = new List<string>();
        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
            connection.Open();
            string query = "SELECT Question FROM Questions";
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                questions.Add(reader["Question"].ToString());
            }
        }
        return questions;
    }
}
