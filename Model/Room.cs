
using Hotel_Management.DAO;
using System.Data;

public class Room {

    public Room() {}

    public Room(int id, int roomNumber, string picture, string description, double price, int capacity, Hotel hotel)
    {
        this.Id = id;
        this.RoomNumber = roomNumber;
        this.Picture = picture;
        this.Description = description;
        this.Price = price;
        this.Capacity = capacity;
        this.Hotel = hotel;
    }

    private int id;

    private int roomNumber;

    private string picture;

    private string description;

    private double price;

    private int capacity;
    private Hotel hotel;

    public int Id { get => id; set => id = value; }
    public int RoomNumber { get => roomNumber; set => roomNumber = value; }
    public string Picture { get => picture; set => picture = value; }
    public string Description { get => description; set => description = value; }
    public double Price { get => price; set => price = value; }
    public int Capacity { get => capacity; set => capacity = value; }
    public Hotel Hotel { get => hotel; set => hotel = value; }

    public bool isValidData()
    {
        return this.roomNumber > 0 && this.capacity > 0;
    }


    public bool checkAvailable(DateTime checkIn, DateTime checkOut, int guestCount) {
        return checkCapacity(guestCount) && checkAvailable(checkIn, checkOut);
    }

    public bool checkCapacity(int guestCount) {
        return Capacity >= guestCount;
    }

    public void saveRoom()
    {
        string sql = "INSERT INTO Room (HotelId, RoomType, Price, Status) VALUES (@HotelId, @RoomType, @Price, @Status)";

        object[] parameters = new object[]
        {
            this.id,
            this.roomNumber,
            this.price,
            "Avaiable"
        };

        new DBConnection().ExecuteQuery(sql, parameters);
    }


    public bool checkAvailable(DateTime checkIn, DateTime checkOut)
    {
        string sql = @"
        SELECT COUNT(*) 
        FROM Reservation r
        JOIN Room rm ON r.RoomId = rm.Id
        WHERE r.CheckIn < @CheckOut AND r.CheckOut > @CheckIn 
        AND rm.Status = 'Available'";  

        // Tham số truyền vào câu SQL
        object[] parameters = new object[]
        {
        checkIn,
        checkOut
        };

        // Thực thi câu truy vấn
        DataTable dt = new DBConnection().ExecuteQuery(sql, parameters);

        // Nếu có ít nhất một phòng trống thì trả về true
        return Convert.ToInt32(dt.Rows[0][0]) == 0; 
    }

}