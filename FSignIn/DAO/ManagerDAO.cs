using Hotel_Management.Constants;
using Hotel_Management.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Hotel_Management.DAO
{
    internal class ManagerDAO
    {
        private DBConnection db = new DBConnection();

        public ManagerDAO() { }
        public bool Insert(object obj)
        {
            Manager manager = (Manager)obj;
            string sql = $"INSERT INTO users(password, first_name, last_name, gender, username, identify_card, " +
                $"phone_number, role) VALUES ('{manager.Password}', N'{manager.FirstName}', N'{manager.LastName}', '{manager.Gender}'," +
                $"'{manager.UserName}', '{manager.IdentifyCard}', '{manager.PhoneNumber}', '{manager.Role}' )";
            int inserted = db.ExecuteNoneQuery(sql);
            if (inserted > 0) return true;
            return false;
        }

        public bool Update(object obj)
        {
            Manager manager = (Manager)obj;
            string query = $"UPDATE Users SET first_name = N'{manager.FirstName}', last_name = N'{manager.LastName}', " +
                $"gender = '{manager.Gender}', username = N'{manager.UserName}', identify_card = N'{manager.IdentifyCard}', " +
                $"phone_number = '{manager.PhoneNumber}' WHERE id = '{manager.Id}'";
            int edited = db.ExecuteNoneQuery(query);
            if (edited > 0) return true;
            return false;
        }

        public DataTable GetInfor(string username)
        {
            string query = "SELECT * FROM Users WHERE username = @username";
            object[] parameter = { username };

            return db.ExecuteQuery(query, parameter);
        }

        public Manager GetInfor(int managerId)
        {
            string query = "SELECT * FROM users WHERE id = @managerId";
            object[] parameter = { managerId };
            DataTable dt = db.ExecuteQuery(query, parameter);
            foreach (DataRow row in dt.Rows)
            {
                return new Manager(Convert.ToInt32(row["id"]), (string)row["first_name"], (string)row["last_name"],
            (int)row["gender"], (string)row["username"], (string)row["identify_card"],
            (string)row["phone_number"], (int)row["role"]);
            }
            return new Manager();
        }
        public string GetImageHotelHome(string username)
        {
            string query = $"SELECT h.picture " +
                $"FROM hotels h " +
                $"JOIN Hotel_Managers hm ON h.id = hm.hotel_id " +
                $"JOIN users u ON hm.user_id = u.id WHERE u.username = '{username}'";
            return (string)db.ExecuteScalar(query);
        }

        public int GetHotelId(string username)
        {
            string query = $"SELECT h.id " +
                $"FROM hotels h " +
            $"JOIN Hotel_Managers hm ON h.id = hm.hotel_id " +
                $"JOIN users u ON hm.user_id = u.id WHERE u.username = '{username}'";
            return Convert.ToInt32(db.ExecuteScalar(query));
        }

        public DataTable ManageRoom(string username)
        {
            string query = "SELECT r.room_number, rd.adult, rd.children, r.pre_price, r.curr_price, r.description, rd.start_day, rd.end_day, rd.picture_1, rd.picture_2, rd.picture_3, rd.picture_4, rd.picture_5, r.id FROM Users u JOIN hotel_managers hm ON u.id = hm.user_id JOIN Hotels h ON hm.hotel_id = h.id JOIN Rooms r ON r.hotel_id = h.id JOIN Rooms_Detail rd ON rd.room_id = r.id WHERE u.username LIKE @username";
            object[] parameter = { username };

            return db.ExecuteQuery(query, parameter);
        }

        public bool AddService(int roomId, int serviceId)
        {
            string sql = $"INSERT INTO Room_Services VALUES ('{roomId}', '{serviceId}')";
            int inserted = db.ExecuteNoneQuery(sql);
            if (inserted > 0) return true;
            return false;
        }

        public DataTable ManageService(string username)
        {
            string query = "SELECT r.room_number, service_id ,service_type, h.id FROM Services s JOIN Room_Services rs ON s.id = rs.service_id JOIN Rooms r ON r.id = rs.room_id JOIN Hotels h ON h.id = r.hotel_id JOIN hotel_managers hm ON hm.hotel_id = h.id JOIN Users u ON hm.user_id = u.id WHERE u.username LIKE @username";
            object[] parameter = { username };

            return db.ExecuteQuery(query, parameter);
        }

        public DataTable MyCustomer(int hotelId)
        {
            string query = "SELECT username, name, room_number, identify_card, phone_number, checkin, checkout FROM Storage WHERE hotel_id = @hotelId";
            object[] parameter = { hotelId };

            return db.ExecuteQuery(query, parameter);
        }

        public DataTable ManageFeedBack(int hotelId)
        {
            string query = "SELECT id, name, room_number, comment, star FROM Storage WHERE hotel_id = @hotelId";
            object[] parameter = { hotelId };

            return db.ExecuteQuery(query, parameter);
        }

        public DataTable HotelBill(int hotelId)
        {
            string query = "SELECT id, name, room_number, total_bill, checkin, checkout, has_voucher FROM Storage WHERE hotel_id = @hotelId";
            object[] parameter = { hotelId };

            return db.ExecuteQuery(query, parameter);
        }
    }
}
