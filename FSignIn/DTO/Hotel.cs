using Hotel_Management.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management.DTO
{
    public class Hotel
    {  
        private int id;
        private string? hotelName;
        private string? address;
        private string? city;
        private int starAvg;
        private string? picture;
        private string? review;
        private string? voucher;
        private float laitude;
        private float longitude;

        public Hotel() { }

        public Hotel(int id, string hotelName, string address, string city)
        {
            this.Id = id;
            this.HotelName = hotelName;
            this.Address = address;
            this.City = city;
        }

        public Hotel(int id, string hotelName, string address, string city, string picture, string voucher, string review, int starAvg)
        {
            this.id = id;
            this.HotelName = hotelName;
            this.Address = address;
            this.City = city;
            this.Picture = picture;
            this.Voucher = voucher;
            this.Review = review;
            this.StarAvg = starAvg;
        }

        public Hotel(string hotelName, string address, string city, string picture, string voucher, string review, int starAvg, float latitude, float longitude)
        {
            this.HotelName = hotelName;
            this.Address = address;
            this.City = city;
            this.Picture = picture;
            this.Voucher = voucher;
            this.Review = review;
            this.StarAvg = starAvg;
            this.laitude = latitude;
            this.longitude = longitude;
        }

        public Hotel(int id, string hotelName, string address, string city, int starAvg, string picture)
        {
            this.Id = id;
            this.HotelName = hotelName;
            this.Address = address;
            this.City = city;
            this.StarAvg = starAvg;
            this.Picture = picture;
        }

        public int Id { get => id; set => id = value; }
        public string HotelName { get => hotelName!; set => hotelName = value; }
        public string Address { get => address!; set => address = value; }
        public string City { get => city!; set => city = value; }
        public int StarAvg { get => starAvg; set => starAvg = value; }
        public string Picture { get => picture!; set => picture = value; }
        public string Review { get => review!; set => review = value; }
        public string Voucher { get => voucher!; set => voucher = value; }
        public float Latitude { get => laitude; set => laitude = value; }
        public float Longitude { get => longitude; set => longitude = value; }
    }
}
