
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Hotel {

    public Hotel() {
    }

    private int id;

    private string name;

    private string address;

    private string picture;

    private List<Room> rooms = new List<Room>();

    private User owner = new User();


    public List<Hotel> searchHotel(string address, DateTime checkIn, DateTime checkOut, int guestCount)
    {
        List<Hotel> hotelLst = getHotelByAddress(address);

        // Duyệt danh sách khách sạn từ cuối lên đầu
        for (int i = hotelLst.Count - 1; i >= 0; i--)
        {
            Hotel hotel = hotelLst[i];

            // Duyệt danh sách phòng trong khách sạn đó từ cuối lên đầu
            for (int j = hotel.rooms.Count - 1; j >= 0; j--)
            {
                Room room = hotel.rooms[j];
                bool isAvailable = room.checkAvailable(checkIn, checkOut, guestCount);
                if (!isAvailable)
                {
                    hotel.removeRoomAt(j); // an toàn khi duyệt từ cuối lên
                }
            }

            // Nếu khách sạn không còn phòng nào phù hợp thì xóa khỏi danh sách
            if (hotel.rooms.Count == 0)
            {
                hotelLst.RemoveAt(i);
            }
        }

        if (hotelLst.Count > 0)
        {
            return hotelLst;
        }
        else
        {
            throw new Exception("No available hotels at the moment");
        }
    }



    public void removeRoomAt(int i) {
        this.rooms.RemoveAt(i);
    }


    public List<Hotel> getHotelByAddress(string address) {
        return null;
    }

}