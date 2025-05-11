
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Hotel_Management.DAO;

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

    public void searchHotel(string address, DateTime checkIn, DateTime checkOut, int guestCount)
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
            display(hotelLst);
        }
        else
        {
            display("Không tìm thấy khách sạn thỏa mãn yêu cầu của bạn !");
        }
    }

    public void addRoom (int roomNumber, string picture, string description, double price, int capacity)
    {
        if (Status == "PENDING APPOVAL")
        {
            // không thể thêm phòng 
            display("Không thể thêm phòng vì khách sạn của bạn đang ở trạng thái chưa được duyệt"); 
        }
        else
        {
            // truyền vào this để biết room thuộc hotel nào 
            Room newRoom = new Room(1,roomNumber, picture, description, price, capacity, this);

            bool isValid = newRoom.isValidData();

            if (!isValid)
            {
                display("Thông tin phòng không hợp lệ !");
            }
            else
            {
                newRoom.saveRoom();
                display("Thêm phòng thành công !");
            }
        }
    }



    public void removeRoomAt(int i) {
        this.Rooms.RemoveAt(i);
    }

    public List<Hotel> getStayedHotel (int userId)
    {
        List<Reservation> reservationLst = new Reservation().findReservations(userId);

        List<Hotel> hotelLst = new List<Hotel>();
        foreach (Reservation reservation in reservationLst)
        {
            int roomId = reservation.Room.Id;
            Hotel hotel = this.findHotel(roomId);
            if (!hotelLst.Contains(hotel))
            {
                hotelLst.Add(hotel);
            }
        }

        if (hotelLst.Count == 0)
            throw new Exception("Không có khách sạn nào để đánh giá !");
        else return hotelLst;
    }

    public void addHotel(string name, string address, string picture, User user)
    {
        this.name = name;
        this.address = address;
        this.picture = picture;
        this.owner = user;

        bool validate = validateInfo();
        if (!validate)
        {
            user.display("Dữ liệu không hợp lệ !");     
        }
        else
        {
            saveHotel();
            display("Thêm khách sạn thành công !");
        }
    }


    public List<Hotel> getHotelByAddress(string address)
    {
        List<Hotel> hotels = new List<Hotel>();

        string sql = @"
        SELECT Id, Name, Address, Picture, Status 
        FROM Hotel
        WHERE Address LIKE @Address";

        object[] parameters = new object[] { "%" + address + "%" };  // Dùng % để tìm kiếm theo địa chỉ chứa chuỗi

        DataTable dt = new DBConnection().ExecuteQuery(sql, parameters);

        foreach (DataRow row in dt.Rows)
        {
            Hotel hotel = new Hotel
            {
                Id = Convert.ToInt32(row["Id"]),
                Name = row["Name"].ToString(),
                Address = row["Address"].ToString(),
                Picture = row["Picture"].ToString(),
                Status = row["Status"].ToString()
            };

            hotels.Add(hotel);  
        }

        return hotels;  
    }



    private void saveHotel()
    {
        string sql = @"
        INSERT INTO Hotel (Name, Address, Picture, Status) 
        VALUES (@Name, @Address, @Picture, @Status);
        SELECT SCOPE_IDENTITY();";  

        // Các tham số để chèn vào câu SQL
        object[] parameters = new object[]
        {
        name,     // Name từ đối tượng Hotel
        address,  // Address từ đối tượng Hotel
        picture,  // Picture từ đối tượng Hotel
        status    // Status từ đối tượng Hotel
        };

        var hotelId = new DBConnection().ExecuteQuery(sql, parameters).Rows[0][0];
        this.id = Convert.ToInt32(hotelId);
    }


    private bool validateInfo()
    {
        return id > 0 && name.Trim().Length > 0 && owner != null;
    }

    public Hotel findHotel(int roomId)
    {
        string sql = @"
        SELECT h.Id, h.Name, h.Address, h.Picture, h.Status
        FROM Room r
        INNER JOIN Hotel h ON r.HotelId = h.Id
        WHERE r.Id = @RoomId";

        object[] parameters = new object[] { roomId };
        DataTable dt = new DBConnection().ExecuteQuery(sql, parameters);

        if (dt.Rows.Count == 0)
            return null;

        DataRow row = dt.Rows[0];

        Hotel hotel = new Hotel
        {
            Id = Convert.ToInt32(row["Id"]),
            Name = row["Name"].ToString(),
            Address = row["Address"].ToString(),
            Picture = row["Picture"].ToString(),
            Status = row["Status"].ToString(),
        };

        return hotel;
    }



    private void display(Object obj)
    {

    }
}