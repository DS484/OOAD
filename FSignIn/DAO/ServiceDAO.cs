using Hotel_Management.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management.DAO
{
    public class ServiceDAO
    {
        private DBConnection db = new DBConnection();

        public int FindService(string service)
        {
            string query = $"SELECT id FROM Services WHERE service_type = '{service}'";

            return Convert.ToInt32(db.ExecuteScalar(query));
        }

        public bool AddService(int roomId, int serviceId)
        {
            string query = $"INSERT INTO Room_Services VALUES({roomId},{serviceId})";
            int inserted = db.ExecuteNoneQuery(query);
            if (inserted > 0) return true;
            return false;
        }

        public bool EditService(int roomId, int serviceId)
        {
            string query = $"UPDATE Room_Services SET service_id = '{serviceId}' WHERE room_id = '{roomId}'";
            int edited = db.ExecuteNoneQuery(query);
            if (edited > 0) return true;
            return false;
        }

        public bool DeleteService(int roomId)
        {
            string query = $"DELETE FROM Room_Services WHERE room_id = '{roomId}'";
            int deleted = db.ExecuteNoneQuery(query);
            if (deleted > 0) return true;
            return false;
        }
    }
}
