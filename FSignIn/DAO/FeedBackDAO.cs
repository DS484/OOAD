using Hotel_Management.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management.DAO
{
    public class FeedBackDAO
    {
        private DBConnection db = new DBConnection();

        public bool InsertFeecBack(int star, string comment, int userId, int hotelId)
        {
            string query = $"INSERT INTO Feedback(star, comment, user_id, hotel_id) VALUES ('{star}', N'{comment}', '{userId}', '{hotelId}')";
            int inserted = db.ExecuteNoneQuery(query);
            if (inserted > 0) return true;
            return false;
        }
    }
}
