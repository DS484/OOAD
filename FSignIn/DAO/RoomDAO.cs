using Hotel_Management.Constants;
using Hotel_Management.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Hotel_Management.DAO
{
    public class RoomDAO
    {
        private DBConnection db = new DBConnection();
        
        public DataTable InfoRoom(int roomId)
        {
            string query = "SELECT * FROM Rooms WHERE id = @roomId";
            object[] parameter = {roomId};

            DataTable dt = db.ExecuteQuery(query, parameter);
            return dt;
        }

        public int FindRoomByRoomNumber(string roomNumber, int hotelId)
        {
            string query = $"SELECT id FROM Rooms r WHERE r.hotel_id = '{hotelId}' AND r.room_number LIKE '{roomNumber}'";

            return Convert.ToInt32(db.ExecuteScalar(query));
        }

        public DataTable FindRoom(int roomId, int hotelId)
        {
            string query = "SELECT * FROM Rooms r JOIN Hotels h ON r.hotel_id = h.id WHERE r.id = @roomId AND h.id = @hotelId";

            object[] parameter = { roomId, hotelId };

            DataTable dt = db.ExecuteQuery(query, parameter);

            return dt;
        }
        
        public DataTable GetRoom(int hotelId)
        {
            string query = "SELECT r.id FROM Rooms r JOIN Hotels h ON r.hotel_id = h.id WHERE h.id = @hotelId";

            object[] parameter = { hotelId };

            DataTable dt = db.ExecuteQuery(query, parameter);

            return dt;
        }

        public bool BookRoomSuccess(int roomId)
        {
            string sql = $"UPDATE Rooms SET room_status = 0 WHERE id = '{roomId}'";
            int inserted = db.ExecuteNoneQuery(sql);
            if (inserted > 0) return true;
            return false;
        }

        public bool InsertRoom(object obj)
        {
            Room room = (Room)obj;
            string sql = $"INSERT INTO Rooms(room_number, room_picture, pre_price, curr_price, description, hotel_id)" +
                $"VALUES ('{room.RoomNumber}', N'{room.RoomPicture}', '{room.PreCost}', '{room.CurrCost}'," +
                $"N'{room.RoomDescription}', '{room.HotelId}')";
            int inserted = db.ExecuteNoneQuery(sql);
            if (inserted > 0) return true;
            return false;
        }
        
        public bool EditRoom(object obj)
        {
            Room room = (Room)obj;
            string query = $"UPDATE Rooms SET room_number = N'{room.RoomNumber}', pre_price = '{room.PreCost}'," +
                $"curr_price = '{room.CurrCost}', description = N'{room.RoomDescription}' WHERE id = '{room.Id}'";
            int edited = db.ExecuteNoneQuery(query);
            if (edited > 0) return true;
            return false;
        }

        public bool DeleteRoom(int roomId)
        {
            string query = $"DELETE FROM Rooms WHERE id = '{roomId}'";
            int deleted = db.ExecuteNoneQuery(query);
            if (deleted > 0) return true;
            return false;
        }

        public DataTable CheckRoomExist(string roomNumber, int hotelId)
        {
            string query = "SELECT * FROM Rooms WHERE room_number = @roomNumber AND hotel_id = @hotelId";
            object[] parameter = { roomNumber, hotelId };

            DataTable dt = db.ExecuteQuery(query, parameter);

            return dt;
        }
    }
}
