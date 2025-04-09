using Hotel_Management.DTO;
using Hotel_Management.HandleData;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management.DAO
{
    public class UserDAO
    {
        private DBConnection db = new DBConnection();
        private FormatData formatData = new FormatData();   

        public UserDAO() { }

        public int GetRole(string username)
        {
            string query = "SELECT role FROM users WHERE username = @username";
            object[] objects = { username };
            object result = db.ExecuteScalar(query, objects);
            return Convert.ToInt32(result);
        }

        public DataTable GetFullUserExcept(string username)
        {
            string query = "SELECT id, first_name, last_name, gender, " +
                "username, identify_card, phone_numner, role FROM users WHERE username != @username";
            object[] objects = { username };
            return db.ExecuteQuery(query, objects);
        }

        public bool UpdatePassWord(string username, string password)
        {
            string query = $"UPDATE Users SET password = N'{formatData.SetPassword(password)}' WHERE username = '{username}'";
            int edited = db.ExecuteNoneQuery(query);
            if (edited > 0) return true;
            return false;
        }
    }
}
