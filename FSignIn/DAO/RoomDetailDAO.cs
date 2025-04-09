using Hotel_Management.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management.DAO
{
    public class RoomDetailDAO
    {
        private DBConnection db = new DBConnection();

        public DataTable RoomInfo(int roomId)
        {
            string query = "SELECT room_id, picture_1, picture_2, picture_3, picture_4, picture_5, hotel_name, h.Review FROM Rooms_Detail rd JOIN Rooms r ON rd.room_id = r.id JOIN Hotels h ON h.id = r.hotel_id WHERE room_id = @roomid";

            object[] parameter = { roomId };

            DataTable dt = db.ExecuteQuery(query, parameter);

            return dt;
        }

        public bool InsertRoomDetail(object obj)
        {
            RoomDetail roomDetail = (RoomDetail)obj;
            Int64 roomId = Convert.ToInt64(db.ExecuteScalar("SELECT max(id) FROM rooms"));
            string sql = $"INSERT INTO Rooms_Detail(room_id, picture_1, picture_2, picture_3, picture_4, picture_5, adult, children, " +
                $"start_day, end_day) VALUES ({roomId}, N'{roomDetail.Picture1}', N'{roomDetail.Picture2}', N'{roomDetail.Picture3}', N'{roomDetail.Picture4}'," +
                $"N'{roomDetail.Picture5}', '{roomDetail.Adult}', '{roomDetail.Child}', '{roomDetail.Start_day}', '{roomDetail.End_day}' )";
            int inserted = db.ExecuteNoneQuery(sql);
            if (inserted > 0) return true;
            return false;
        }

        public string GetRoomService(int roomId)
        {
            string service = "";
            string query = $"SELECT service_type FROM Room_Services rs JOIN Services s ON rs.service_id = s.id WHERE rs.room_id = '{roomId}'";
            object result = (db.ExecuteScalar(query)).ToString()!;
            if (result != null)
            {
                service = result.ToString()!;
                return service;
            }
            return service;
        }

        public bool EditRoomDetail(object obj)
        {
            RoomDetail roomDetail = (RoomDetail)obj;
            string query = $"UPDATE Rooms_Detail SET picture_1 = N'{roomDetail.Picture1}', picture_2 = N'{roomDetail.Picture2}'," +
                $"picture_3 = N'{roomDetail.Picture3}', picture_4 = N'{roomDetail.Picture4}', picture_5 = N'{roomDetail.Picture5}'," +
                $"adult = '{roomDetail.Adult}', children = '{roomDetail.Child}', start_day = '{roomDetail.Start_day}', end_day = '{roomDetail.End_day}' WHERE room_id = {roomDetail.RoomId}";
            int edited = db.ExecuteNoneQuery(query);
            if (edited > 0) return true;
            return false;
        }

        
    }
}
