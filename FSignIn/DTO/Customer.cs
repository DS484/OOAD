using Hotel_Management.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management.DTO
{
    internal class Customer : User
    {
        public Customer(int id, string firstName, string lastName, 
            int gender, string userName, string identifyCard, 
            string phoneNumber, int role, string password) : base(id, firstName,
                lastName, gender, userName, identifyCard, phoneNumber, role, password)
        {
            
        }
        public Customer(string firstName, string lastName,
            int gender, string userName, string identifyCard,
            string phoneNumber, int role, string password) : base(firstName,
                lastName, gender, userName, identifyCard, phoneNumber, role, password)
        {

        }
    }
}
