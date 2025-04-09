using Hotel_Management.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hotel_Management.DAO;
using System.Data;
namespace Hotel_Management.DTO
{
    internal class User
    {
        private int id;
        private string? firstName;
        private string? lastName;
        private int gender;
        private string? userName;
        private string? identifyCard;
        private string? phoneNumber;
        private int role;
        private DateTime createdAt;
        private DateTime modifiedAt;
        private bool isAdmin;
        private string? password;

        public User() { }

        public User(string firstName, string lastName, int gender, string userName, string identifyCard, string phoneNumber, int role, string password)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.gender = gender;
            this.userName = userName;
            this.identifyCard = identifyCard;
            this.phoneNumber = phoneNumber;
            this.role = role;
            this.password = SetPassword(password);
            this.CreatedAt = DateTime.Now;
            this.ModifiedAt = DateTime.Now;
            this.IsAdmin = false;

        }
        public User(int id, string firstName, string lastName, int gender, string userName, string identifyCard, string phoneNumber, int role, string password)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Gender = gender;
            this.UserName = userName;
            this.IdentifyCard = identifyCard;
            this.PhoneNumber = phoneNumber;
            this.Role = role;
            this.CreatedAt = DateTime.Now;
            this.ModifiedAt = DateTime.Now;
            this.IsAdmin = false;
            this.Password = SetPassword(password);
        }

        public int Id { get => id; set => id = value; }
        public string FirstName { get => firstName!; set => firstName = value; }
        public string LastName { get => lastName!; set => lastName = value; }
        public string UserName { get => userName!; set => userName = value; }
        public string IdentifyCard { get => identifyCard!; set => identifyCard = value; }
        public string PhoneNumber { get => phoneNumber!; set => phoneNumber = value; }
        public DateTime CreatedAt { get => createdAt; set => createdAt = value; }
        public DateTime ModifiedAt { get => modifiedAt; set => modifiedAt = value; }
        public bool IsAdmin { get => isAdmin; set => isAdmin = value; }
        public string Password { get => password!; set => password = SetPassword(value); }
        internal int Gender { get => gender; set => gender = value; }
        internal int Role { get => role; set => role = value; }

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
            foreach(DataRow row in dt.Rows)
            {
                bool verified = BCrypt.Net.BCrypt.Verify(password, row["password"].ToString());
                if (!verified) return false;
                return true;
            }
            return true;
        }
    }
}
