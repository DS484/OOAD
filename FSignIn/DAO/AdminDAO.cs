using Hotel_Management.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management.DAO
{
    internal class AdminDAO
    {
        private DBConnection db = new DBConnection();
        public AdminDAO() { }

        public bool Insert(object[] obj)
        {
            string sql = $"INSERT INTO Storage(username, name, identify_card, phone_number, gender, room_number, checkin, checkout, hotel_id, total_bill, has_voucher) VALUES ('{obj[0]}', " +
                $"N'{obj[1]}', N'{obj[2]}', N'{obj[3]}', N'{obj[4]}', N'{obj[5]}', N'{obj[6]}', N'{obj[7]}', N'{obj[8]}', N'{obj[9]}', N'{obj[10]}')";
            int inserted = db.ExecuteNoneQuery(sql);
            if (inserted > 0) return true;
            return false;
        }

        public DataTable GetHotelRevenue()
        {
            string query = @"WITH room_revenue AS (
	                        SELECT h.id,
	                        SUM(total_bill) AS Revenue
	                        FROM Storage s
	                        JOIN Hotels h
		                        ON h.id = s.hotel_id
	                        GROUP BY h.id
                        ) 
                        SELECT h.id, h.hotel_name AS ""Tên khách sạn"", h.address AS ""Địa chỉ"", h.city AS ""Thành phố"", 
                        CASE 
	                        WHEN rr.id is null THEN 0
	                        ELSE SUM(rr.Revenue)
                        END ""Tổng doanh thu""
                        FROM Hotels h
                        LEFT JOIN room_revenue rr
	                        ON h.id = rr.id
                        GROUP BY h.id, h.hotel_name, h.address, h.city, rr.id
                        ORDER BY ""Tổng doanh thu"" DESC;";
            object[] parameter = { };
            return db.ExecuteQuery(query, parameter);
        }

        public DataTable TopCustomer()
        {
            string query = "SELECT u.username, u.first_name, u.last_name, u.identify_card, u.gender, u.phone_number, COUNT(*) as Solan FROM Users u JOIN Booking b ON u.id = b.user_id GROUP BY u.first_name, u.username, u.first_name, u.last_name, u.identify_card, u.gender, u.phone_number HAVING COUNT(*) >= 1";

            object[] parameter = {};
            DataTable dt = db.ExecuteQuery(query, parameter);
            return dt;
        }

        public DataTable GetFamousLocation()
        {
            string query = @"SELECT h.address AS ""Địa chỉ"", h.city AS ""Thành phố"", COUNT(*) AS ""Số lượng đặt phòng""
                            FROM Hotels h
                            LEFT JOIN Rooms r
	                            ON h.id = r.hotel_id
                            LEFT JOIN Booking bk
	                            ON r.id = bk.room_id
                            WHERE bk.id is not null
                            GROUP BY h.address, h.city
                            ORDER BY COUNT(*) DESC;";
            object[] parameter = { };
            return db.ExecuteQuery(query, parameter);
        }

        public DataTable VIPCustomer()
        {
            string query = "SELECT u.username, u.first_name, u.last_name, u.identify_card, u.gender, u.phone_number FROM Users u JOIN Booking b ON u.id = b.user_id JOIN Rooms r ON r.id = b.room_id WHERE r.curr_price >= '5000000'";

            object[] parameter = { };

            DataTable dt = db.ExecuteQuery(query, parameter);
            return dt;
        }

        public DataTable GetHotHotel()
        {
            string query = @"select h.address as ""Địa chỉ"", h.city as ""Thành phố"", count(*) as ""Số lượng đặt phòng""
                            from hotels h
                            left join rooms r
	                            on h.id = r.hotel_id
                            left join Booking bk
	                            on r.id = bk.room_id
                            where bk.id is not null
                            group by h.address, h.city
                            order by count(*) desc;";
            object[] parameter = { };
            return db.ExecuteQuery(query, parameter);
        }

        public DataTable HotelRevenue()
        {
            string query = "SELECT h.id, h.hotel_name, h.address, h.city, Count(*) as Danhgia FROM Storage s JOIN Hotels h ON s.hotel_id = h.id WHERE comment is null and star is null GROUP BY h.id, h.hotel_name, h.address, h.city ORDER BY COUNT(*) DESC";

            object[] parameter = { };

            DataTable dt = db.ExecuteQuery(query, parameter);
            return dt;
        }
    }
}
