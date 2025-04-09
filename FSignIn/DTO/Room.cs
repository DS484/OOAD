using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management.DTO
{
    public class Room
    {
        private int id;
        private string ?roomNumber;
        private string ?roomPicture;
        private int preCost;
        private int currCost;
        private string ?roomDescription;
        private int hotelId;

        public Room(int roomNumber)
        {
            
        }

        public Room(string roomNumber, string roomPicture, int preCost, int currCost, string roomDescription, int hotelId)
        {
            this.roomNumber = roomNumber;
            this.roomPicture = roomPicture;
            this.preCost = preCost;
            this.currCost = currCost;
            this.roomDescription = roomDescription;
            this.hotelId = hotelId;
        }

        public Room(int id, string roomNumber, string roomPicture, int preCost, int currCost, string roomDescription, int hotelId)
        {
            this.id = id;
            this.roomNumber = roomNumber;
            this.roomPicture = roomPicture;
            this.preCost = preCost;
            this.currCost = currCost;
            this.roomDescription = roomDescription;
            this.hotelId = hotelId;
        }

        public Room(int id, string roomNumber, string roomPicture, int preCost, int currCost, string roomDescription)
        {
            this.id = id;
            this.roomNumber = roomNumber;
            this.roomPicture = roomPicture;
            this.preCost = preCost;
            this.currCost = currCost;
            this.roomDescription = roomDescription;
        }

        public int Id { get => id; set => id = value; }
        public string RoomNumber { get => roomNumber!; set => roomNumber = value; }
        public string RoomPicture { get => roomPicture!; set => roomPicture = value; }
        public int PreCost { get => preCost; set => preCost = value; }
        public int CurrCost { get => currCost; set => currCost = value; }
        public string RoomDescription { get => roomDescription!; set => roomDescription = value; }
        public int HotelId { get => hotelId; set => hotelId = value; }
    }
}
