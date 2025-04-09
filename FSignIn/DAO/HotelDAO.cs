using Hotel_Management.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Hotel_Management.DAO
{
    public class HotelDAO
    {
        private DBConnection db = new DBConnection();

        public bool Insert(object obj)
        {
            Hotel hotel = (Hotel)obj;
            string sql = $"INSERT INTO hotels(hotel_name, address, city, picture, voucher, star_avg, Review, latitude, longitude) VALUES (N'{hotel.HotelName}', N'{hotel.Address}', N'{hotel.City}', N'{hotel.Picture}', N'{hotel.Voucher}', '{hotel.StarAvg}', N'{hotel.Review}', '{hotel.Latitude}', '{hotel.Longitude}')";
            int inserted = db.ExecuteNoneQuery(sql);
            if (inserted > 0) return true;
            return false;
        }

        public bool Update(object obj)
        {
            Hotel hotel = (Hotel)obj;
            string query = $"UPDATE Hotels SET hotel_name = N'{hotel.HotelName}', address = N'{hotel.Address}', " +
                $"city = N'{hotel.City}', picture = N'{hotel.Picture}', Review = N'{hotel.Review}', Voucher = N'{hotel.Voucher}', star_avg = '{hotel.StarAvg}'  WHERE id = '{hotel.Id}'";
            int edited = db.ExecuteNoneQuery(query);
            if (edited > 0) return true;
            return false;
        }

        public DataTable FindHotel(int id)
        {
            string query = "SELECT h.hotel_name, h.address, h.city, h.picture, r.room_number, r.pre_price, r.curr_price, r.id, h.star_avg FROM Hotels h JOIN Rooms r ON h.id = r.hotel_id WHERE h.id = @hotelId";

            object[] parameter = { id };

            DataTable dt = db.ExecuteQuery(query, parameter);
            return dt;
        }

        public DataTable InfoHotel(int hotelId)
        {
            string query = "SELECT * FROM Hotels where id = @hotelId";

            object[] parameter = { hotelId };

            DataTable dt = db.ExecuteQuery(query, parameter);
            return dt;
        }

        public Hotel GetHotel(int id)
        {
            string query = "SELECT * FROM hotels WHERE id = @id";
            object[] parameter = { id };
            DataTable dt = db.ExecuteQuery(query, parameter);
            foreach(DataRow row in dt.Rows)
            {
                return new Hotel(Convert.ToInt32(row["id"]), (string)row["hotel_name"], (string)row["address"],
                (string)row["city"]);
            }
            return new Hotel();
        }

        public DataTable CheckVoucher(string voucher, int hotelId)
        {
            string query = "SELECT * FROM Hotels WHERE Voucher = @voucher AND id = @hotelId";

            object[] parameter = { voucher, hotelId };
            DataTable dt = db.ExecuteQuery(query, parameter);
            
            return dt;
        }

        public DataTable SeeReview(int hotelId)
        {
            string query = "SELECT u.username, f.star, f.comment, h.hotel_name FROM Users u JOIN Feedback f ON u.id = f.user_id JOIN Hotels h ON h.id = f.hotel_id WHERE h.id = @hotelId";
            object[] parameter = { hotelId };

            DataTable dt = db.ExecuteQuery(query, parameter);
            return dt;
        }

        public void InsertHotelManager()
        {
            object user_id = db.ExecuteScalar("SELECT max(id) FROM users");
            object hotel_id = db.ExecuteScalar("SELECT max(id) FROM hotels");
            Int64 userId = (Int64)user_id;
            Int64 hotelId = (Int64)hotel_id;
            string sql = $"INSERT INTO hotel_managers (user_id, hotel_id) VALUES ({userId}, {hotelId})";
            db.ExecuteNoneQuery(sql);
        }

        public double GetLatitude(int hotelId)
        {
            string query = "SELECT latitude FROM Hotels WHERE id = @hotelId";
            object[] parameter = { hotelId };
            DataTable dt = db.ExecuteQuery(query, parameter);
            return Convert.ToDouble(dt.Rows[0][0]);
        }

        public double GetLongitude(int hotelId)
        {
            string query = "SELECT longitude FROM Hotels WHERE id = @hotelId";
            object[] parameter = { hotelId };
            DataTable dt = db.ExecuteQuery(query, parameter);
            return Convert.ToDouble(dt.Rows[0][0]);
        }

        public string GetHotelName(int hotelId)
        {
            string query = "SELECT hotel_name FROM Hotels WHERE id = @hotelId";
            object[] parameter = { hotelId };
            DataTable dt = db.ExecuteQuery(query, parameter);
            return (dt.Rows[0][0].ToString()!);
        }
    }
}
