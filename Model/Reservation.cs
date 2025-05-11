
using Hotel_Management.DAO;
using System.Data;

public class Reservation {

    public Reservation() {
    }

    public Reservation(Room room, DateTime checkIn, DateTime checkOut)
    {
        this.room = room;
        this.checkIn = checkIn;
        this.checkOut = checkOut;
    }

    private int id;

    private DateTime checkIn;

    private DateTime checkOut;

    private DateTime createdAt;

    private Room room = new Room();

    private User customer = new User();

    private Payment payment;

    public Room Room { get => room; set => room = value; }
    public User Customer { get => customer; set => customer = value; }
    public int Id { get => id; set => id = value; }
    public DateTime CheckIn { get => checkIn; set => checkIn = value; }
    public DateTime CheckOut { get => checkOut; set => checkOut = value; }
    public DateTime CreatedAt { get => createdAt; set => createdAt = value; }
    public Payment Payment { get => payment; set => payment = value; }

    public void bookRoom (User customer, Room room, DateTime checkIn, DateTime CheckOut) {
        bool check = customer.checkCustomerInfo();

        if (!check)
        {
            throw new Exception("Thông tin khách hàng không hợp lệ !");
        }
        else
        {

            Reservation newReservation = new Reservation(room, checkIn, checkOut);
            newReservation.saveReservation();
            display("Thanh toán để hoàn tất đặt phòng !");
        } 
    }

    public List<Reservation> getReservations(DateTime startDate, DateTime endDate)
    {
        List<Reservation> reservationList = new List<Reservation>();
        foreach(Reservation r in reservationList)
        {
            if (startDate <= r.Payment.getPaymentDate() &&
                r.Payment.getPaymentDate() <= endDate)
            {
                reservationList.Add(r);
            }   
        }

        return reservationList;
    }

    public void getRevenueReport(DateTime startDate, DateTime endDate, Hotel hotel) 
    {
        List<Reservation> reservationResult = getReservationsByHotel (startDate, endDate, hotel);
        double totalRevenue = 0;

        foreach (Reservation reservation in reservationResult)
        {
             totalRevenue += reservation.getPaymentAmount();
        }
        
        if (totalRevenue > 0) {

            display(totalRevenue);
        } 
        else
        {
            display("Không có dữ liệu doanh thu");
        }
    }
    private double getPaymentAmount()
    {
        double paymentAmount = payment.getAmount();
        return paymentAmount;
    }

    public string makePayment()
    {
        Payment = new Payment();
        return Payment.processPayment(this);
    }

    public void saveReservation()
    {
        // Bước 1: Lưu thông tin đặt phòng vào bảng Reservation
        string sqlReservation = @"
        INSERT INTO Reservation (RoomId, CheckIn, CheckOut, CreatedAt, CustomerId)
        VALUES (@RoomId, @CheckIn, @CheckOut, @CreatedAt, @CustomerId);
        SELECT SCOPE_IDENTITY();";

        object[] parametersReservation = new object[]
        {
        room.Id,
        checkIn,
        checkOut,
        DateTime.Now,
        customer.Id
        };

        var reservationId = new DBConnection().ExecuteQuery(sqlReservation, parametersReservation).Rows[0][0];

        this.id = Convert.ToInt32(reservationId);
    }

    internal List<Reservation> findReservations(int userId)
    {
        List<Reservation> reservations = new List<Reservation>();

        string sql = @"
        SELECT r.Id AS ReservationId, r.CheckIn, r.CheckOut, r.CreatedAt, 
               rm.Id AS RoomId, rm.RoomType, rm.Price, 
               h.Id AS HotelId, h.Name AS HotelName, h.Address AS HotelAddress, h.Status AS HotelStatus
        FROM Reservation r
        JOIN Room rm ON r.RoomId = rm.Id
        JOIN Hotel h ON rm.HotelId = h.Id
        WHERE r.UserId = @UserId";

        object[] parameters = new object[] { userId };

        DataTable dt = new DBConnection().ExecuteQuery(sql, parameters);

        foreach (DataRow row in dt.Rows)
        {
            Room room = new Room
            {
                Id = Convert.ToInt32(row["RoomId"]),
                RoomNumber = Convert.ToInt32(row["RoomId"]),
                Price = Convert.ToDouble(row["Price"]),
            };

            Hotel hotel = new Hotel
            {
                Id = Convert.ToInt32(row["HotelId"]),
                Name = row["HotelName"].ToString(),
                Address = row["HotelAddress"].ToString(),
                Status = row["HotelStatus"].ToString()
            };

            Reservation reservation = new Reservation
            {
                Id = Convert.ToInt32(row["ReservationId"]),
                CheckIn = Convert.ToDateTime(row["CheckIn"]),
                CheckOut = Convert.ToDateTime(row["CheckOut"]),
                CreatedAt = Convert.ToDateTime(row["CreatedAt"]),
                Room = room,     // Gán thông tin phòng
                                 // Không cần gán thông tin User, vì tìm theo UserId đã có
            };

            reservations.Add(reservation); // Thêm đối tượng Reservation vào danh sách
        }

        return reservations; 
    }

    private List<Reservation> getReservationsByHotel(DateTime startDate, DateTime endDate, Hotel hotel)
    {
        List<Reservation> reservations = new List<Reservation>();

        string sql = @"
        SELECT r.Id AS ReservationId, r.CheckIn, r.CheckOut, r.CreatedAt, 
               rm.Id AS RoomId, rm.RoomType, rm.Price, 
               h.Id AS HotelId, h.Name AS HotelName, h.Address AS HotelAddress, h.Status AS HotelStatus
        FROM Reservation r
        JOIN Room rm ON r.RoomId = rm.Id
        JOIN Hotel h ON rm.HotelId = h.Id
        WHERE h.Id = @HotelId
        AND r.CheckIn >= @StartDate AND r.CheckOut <= @EndDate";

        object[] parameters = new object[]
        {
        hotel.Id,
        startDate,
        endDate
        };

        DataTable dt = new DBConnection().ExecuteQuery(sql, parameters);

        foreach (DataRow row in dt.Rows)
        {
            Room room = new Room
            {
                Id = Convert.ToInt32(row["RoomId"]),
                RoomNumber = Convert.ToInt32(row["RoomNumber"]),
                Price = Convert.ToDouble(row["Price"]),
            };

            Hotel hotelData = new Hotel
            {
                Id = Convert.ToInt32(row["HotelId"]),
                Name = row["HotelName"].ToString(),
                Address = row["HotelAddress"].ToString(),
                Status = row["HotelStatus"].ToString()
            };

            Reservation reservation = new Reservation
            {
                Id = Convert.ToInt32(row["ReservationId"]),
                CheckIn = Convert.ToDateTime(row["CheckIn"]),
                CheckOut = Convert.ToDateTime(row["CheckOut"]),
                CreatedAt = Convert.ToDateTime(row["CreatedAt"]),
                Room = room,
            };

            reservations.Add(reservation);
        }

        return reservations;
    }


    public List<Reservation> getReservations(Hotel hotel, DateTime startDate, DateTime endDate)
    {
        List<Reservation> reservations = new List<Reservation>();

        string sql = @"
        SELECT r.Id AS ReservationId, r.CheckIn, r.CheckOut, r.CreatedAt, 
               rm.Id AS RoomId, rm.RoomType, rm.Price, 
               h.Id AS HotelId, h.Name AS HotelName, h.Address AS HotelAddress, h.Status AS HotelStatus
        FROM Reservation r
        JOIN Room rm ON r.RoomId = rm.Id
        JOIN Hotel h ON rm.HotelId = h.Id
        WHERE h.Id = @HotelId
        AND r.CheckIn >= @StartDate AND r.CheckOut <= @EndDate";

        object[] parameters = new object[]
        {
        hotel.Id,
        startDate,
        endDate
        };

        DataTable dt = new DBConnection().ExecuteQuery(sql, parameters);

        foreach (DataRow row in dt.Rows)
        {
            Room room = new Room
            {
                Id = Convert.ToInt32(row["RoomId"]),
                RoomNumber = Convert.ToInt32(row["RoomId"]),
                Price = Convert.ToDouble(row["Price"]),
            };

            Hotel hotelData = new Hotel
            {
                Id = Convert.ToInt32(row["HotelId"]),
                Name = row["HotelName"].ToString(),
                Address = row["HotelAddress"].ToString(),
                Status = row["HotelStatus"].ToString()
            };

            Reservation reservation = new Reservation
            {
                Id = Convert.ToInt32(row["ReservationId"]),
                CheckIn = Convert.ToDateTime(row["CheckIn"]),
                CheckOut = Convert.ToDateTime(row["CheckOut"]),
                CreatedAt = Convert.ToDateTime(row["CreatedAt"]),
                Room = room,
            };

            reservations.Add(reservation);
        }

        return reservations;
    }


    private void display(Object obj)
    {
        throw new NotImplementedException();
    }
}