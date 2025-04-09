using Hotel_Management.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Hotel_Management.HandleData
{
    public class DataInputCheck
    {
        DBConnection db = new DBConnection();

        public bool CheckPhoneNumber(string phoneNumber)
        {
            return Regex.IsMatch(phoneNumber, @"^0\d{9}$");
        }
        public bool CheckIdentifyCard(string card)
        {
            return Regex.IsMatch(card, @"^\d{12}$");
        }

        public bool checkUserDataExist(string columnName, string searchString)
        {
            string query = $"SELECT COUNT(*) FROM Users WHERE {columnName} = @SearchString";
            object result = db.ExecuteScalar(query, new object[] { searchString });

            return (int)result > 0;
        }

        public bool checkHotelDataExist(string[] searchString)
        {
            string query = $"SELECT COUNT(*) FROM Hotels WHERE hotel_name = @hotelName AND address = @address AND city = @city";
            object result = db.ExecuteScalar(query, new object[] { searchString[0], searchString[1], searchString[2] });

            return (int)result > 0;
        }

        public bool CheckDuplicateField(string tableName, string fieldName, string oldValue, string newValue)
        {
            if(newValue == oldValue) return false;
            string query = $"SELECT COUNT(*) FROM {tableName} WHERE {fieldName} = '{newValue}'";
            object result = db.ExecuteScalar(query);
            return (int)result > 0;
        }
    }
}
