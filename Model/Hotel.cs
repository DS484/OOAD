
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

    private string status; 

    private List<Room> rooms = new List<Room>();

    private User owner = new User();

    public int Id { get => id; set => id = value; }
    public string Name { get => name; set => name = value; }
    public string Address { get => address; set => address = value; }
    public string Picture { get => picture; set => picture = value; }
    public string Status { get => status; set => status = value; }
    public List<Room> Rooms { get => rooms; set => rooms = value; }
    public User Owner { get => owner; set => owner = value; }

    public List<Hotel> searchHotel(string address, DateTime checkIn, DateTime checkOut, int guestCount)
    {
        List<Hotel> hotelLst = getHotelByAddress(address);

        // Duyệt danh sách khách sạn từ cuối lên đầu
        for (int i = hotelLst.Count - 1; i >= 0; i--)
        {
            Hotel hotel = hotelLst[i];

            // Duyệt danh sách phòng trong khách sạn đó 
            for (int j = hotel.Rooms.Count - 1; j >= 0; j--)
            {
                Room room = hotel.Rooms[j];
                bool isAvailable = room.checkAvailable(checkIn, checkOut, guestCount);
                if (!isAvailable)
                {
                    hotel.removeRoomAt(j); 
                    // xóa những phòng không thỏa mãn điều kiện lọc khỏi kết quả tìm kiếm 
                }
            }

            // Nếu khách sạn không còn phòng nào phù hợp thì xóa khỏi danh sách
            if (hotel.Rooms.Count == 0)
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

    public string addRoom (int roomNumber, string picture, string description, double price, int capacity)
    {
        if (Status == "PENDING APPOVAL")
        {
            // không thể thêm phòng 
            return "Không thể thêm phòng vì khách sạn của bạn đang ở trạng thái chưa được duyệt"; 
        }
        else
        {
            // truyền vào this để biết room thuộc hotel nào 
            Room newRoom = new Room(1,roomNumber, picture, description, price, capacity, this);

            bool isValid = newRoom.isValidData();

            if (!isValid)
            {
                return "Thông tin phòng không hợp lệ !";
            }
            else
            {
                newRoom.saveRoom();
                return "Thêm phòng thành công !";
            }
        }
    }



    public void removeRoomAt(int i) {
        this.Rooms.RemoveAt(i);
    }


    public List<Hotel> getHotelByAddress(string address) {
        return null;
    }

}