using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hotel_Management.Constants;
using Hotel_Management.DTO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Hotel_Management.DAO
{
    public class CustomerDAO
    {
        private DBConnection db = new DBConnection();

        public CustomerDAO()
        {
        }

        public DataTable SearchHotel(string city, int adult, int child, DateTime startDate, DateTime endDate)
        {
            string query = "SELECT h.id as 'Hotel Id', r.id as 'Room Id' FROM Hotels h JOIN Rooms r ON h.id = r.hotel_id JOIN Rooms_Detail rd ON r.id = rd.room_id WHERE rd.adult = @adultCount AND rd.children = @childrenCount AND rd.start_day <= @startDate AND rd.end_day >= @endDate AND h.city LIKE @city GROUP BY r.id, h.id";

            object[] parameter = { adult, child, startDate, endDate, city };

            DataTable dt = db.ExecuteQuery(query, parameter);
            return dt;
        }
        
        public bool Insert(object obj)
        {
            Customer cust = (Customer)obj;
            string sql = $"INSERT INTO users(password, first_name, last_name, gender, username, identify_card, " +
                $"phone_number, role) VALUES ('{cust.Password}', N'{cust.FirstName}', N'{cust.LastName}', '{cust.Gender}'," +
                $"'{cust.UserName}', '{cust.IdentifyCard}', '{cust.PhoneNumber}', '{cust.Role}' )";
            int inserted = db.ExecuteNoneQuery(sql);
            if (inserted > 0) return true;
            return false;
        }

        public DataTable Login(string username, string password)
        {
            string query = "SELECT username, password FROM users WHERE username = @username";
            object[] parameter = { username };
            DataTable dt = db.ExecuteQuery(query, parameter);
            return dt;
        }

        public int FindId(string userName)
        {
            string query = "SELECT id FROM Users WHERE username = @username";
            object[] parameter = { userName };
            DataTable dt = db.ExecuteQuery(query, parameter);
            return Convert.ToInt32(dt.Rows[0][0]);
        }

        public DataTable UserInfomation(int userId)
        {
            string query = "SELECT * FROM Users WHERE id = @userid";
            object[] parameter = { userId };
            DataTable dt = db.ExecuteQuery(query, parameter);
            return dt;
        }

        public DataTable CheckHistory(int userId)
        {
            string query = "SELECT u.id, h.id, room_number, checkin, checkout, h.hotel_name, u.first_name, u.last_name, u.username, h.picture, b.id FROM Users u JOIN Booking b ON u.id = b.user_id JOIN Rooms r ON r.id = b.room_id JOIN Hotels h ON h.id = r.hotel_id WHERE u.id = @userId";
            object[] parameter = { userId };
            DataTable dt = db.ExecuteQuery(query, parameter);
            return dt;
        }

        public string GetUserName(int userId)
        {
            string query = $"SELECT username FROM Users WHERE id = {userId}";
            return (string)db.ExecuteScalar(query);
        }
    }


}
