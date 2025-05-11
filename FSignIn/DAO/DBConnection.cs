using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Hotel_Management.DAO
{
    public class DBConnection
    {
        private string _connectionString = @"Server=Tieanh19\SQLEXPRESS;Database=HOTEL_MANAGEMENT;Trusted_Connection=true";

        private SqlConnection cnn;

        public DBConnection()
        {
            cnn = new SqlConnection(_connectionString); 
        }

        public void AddParameter(string query, object[] parameter, SqlCommand command)
        {
            if (parameter != null)
            {
                string[] listParameter = query.Split(' ');
                int i = 0;

                foreach (string item in listParameter)
                {
                    if (item.Contains("@"))
                    {
                        
                        command.Parameters.AddWithValue(item, parameter[i]);
                        ++i;
                    }
                }
            }
        }

        public DataTable ExecuteQuery(string query, object[] parameter)
        {
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                AddParameter(query, parameter, command);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }

        public int ExecuteNoneQuery(string query, object[]? parameter = null)
        {
            int data = 0;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                AddParameter(query, parameter!, command);
                data = command.ExecuteNonQuery();
                connection.Close();
            }
            return data;
        }

        public object ExecuteScalar(string query, object[]? parameter = null)
        {
            object data = new object();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                AddParameter(query, parameter!, command);
                data = command.ExecuteScalar();
                connection.Close();
            }
            return data;
        }
    }
}
