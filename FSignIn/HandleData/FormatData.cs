using Hotel_Management.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management.HandleData
{
    public class FormatData
    {
        public string ConvertDate(DateTime date)
        {
            return date.ToString("MM/dd/yyyy");
        }

        public string SetPassword(string password)
        {
            string password_hash = BCrypt.Net.BCrypt.HashPassword(password);
            return password_hash;
        }

        public bool VerifyPassword(string username, string password)
        {
            CustomerDAO cust = new CustomerDAO();
            DataTable dt = cust.Login(username, password);
            if (dt.Rows.Count == 0) return false;
            foreach (DataRow row in dt.Rows)
            {
                bool verified = BCrypt.Net.BCrypt.Verify(password, row["password"].ToString());
                if (!verified) return false;
                return true;
            }
            return true;
        }
    }
}
