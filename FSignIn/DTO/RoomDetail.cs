using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management.DTO
{
    public class RoomDetail
    {
        private int roomId;
        private string? picture1;
        private string? picture2;
        private string? picture3;   
        private string? picture4;
        private string? picture5;
        private int adult;
        private int child;
        private DateTime start_day;
        private DateTime end_day;

        public RoomDetail(int adult, int child, DateTime start_day)
        {
            this.adult = adult;
            this.child = child;
            this.start_day = start_day;
        }

        public RoomDetail(string picture1, string picture2, string picture3, string picture4, string picture5, int adult, int child, DateTime start_day, DateTime end_day)
        {
            this.picture1 = picture1;
            this.picture2 = picture2;
            this.picture3 = picture3;
            this.picture4 = picture4;
            this.picture5 = picture5;
            this.adult = adult;
            this.child = child;
            this.start_day = start_day;
            this.end_day = end_day;
        }

        public RoomDetail(int roomId, string picture1, string picture2, string picture3, string picture4, string picture5, int adult, int child, DateTime start_day, DateTime end_day)
        {
            this.roomId = roomId;
            this.picture1 = picture1;
            this.picture2 = picture2;
            this.picture3 = picture3;
            this.picture4 = picture4;
            this.picture5 = picture5;
            this.adult = adult;
            this.child = child;
            this.start_day = start_day;
            this.end_day = end_day;
        }

        public int RoomId { get => roomId; set => roomId = value; }
        public string Picture1 { get => picture1!; set => picture1 = value; }
        public string Picture2 { get => picture2!; set => picture2 = value; }
        public string Picture3 { get => picture3!; set => picture3 = value; }
        public string Picture4 { get => picture4!; set => picture4 = value; }
        public string Picture5 { get => picture5!; set => picture5 = value; }
        public int Adult { get => adult; set => adult = value; }
        public int Child { get => child; set => child = value; }
        public DateTime Start_day { get => start_day; set => start_day = value; }
        public DateTime End_day { get => end_day; set => end_day = value; }
    }
}
