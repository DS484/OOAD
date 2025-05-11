using Guna.Charts.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hotel_Management.DAO;

namespace Model
{
    public class Feedback
    {
        int id;
        string content;
        int starNumber;
        Hotel hotel;

        public Feedback(Hotel hotel, int starNumber, string content)
        {
            this.hotel = hotel;
            this.starNumber = starNumber;
            this.content = content;
        }

        public int Id { get => id; set => id = value; }
        public string Content { get => content; set => content = value; }
        public int StarNumber { get => starNumber; set => starNumber = value; }

        public void saveRating(int hotelId, int starNumber, string content)
        {
            if (starNumber != null)
            {
                Hotel hotel = new Hotel().findHotel(hotelId);

                if (hotel != null)
                {
                    Feedback newFeedback = new Feedback(hotel, starNumber, content);
                    newFeedback.saveFeedback();

                    display("Đánh giá thành công !");
                }
            }
            else
            {
                display("Vui lòng chọn số sao !");
            }
        }

        public void saveFeedback()
        {
            string sql = "INSERT INTO Feedback (Content, StarNumber, hotelId) " +
                         "VALUES (@Content, @StarNumber, @hotelId)";

            object[] parameters = new object[]
            {
                content,
                starNumber,
                hotel.Id,
            };

            new DBConnection().ExecuteQuery(sql, parameters);
        }


        private void display (Object obj)
        {

        }
    }
}
