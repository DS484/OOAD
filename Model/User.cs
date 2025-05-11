
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Windows.Forms;

public class User {

    public User() {
    }

    private int id;

    private string firstName;

    private string lastName;

    private string phone;

    private string identifyCard;

    private string role;

    private string userName;

    private string password;

    public int Id { get => id; set => id = value; }
    public string FirstName { get => firstName; set => firstName = value; }
    public string LastName { get => lastName; set => lastName = value; }
    public string Phone { get => phone; set => phone = value; }
    public string IdentifyCard { get => identifyCard; set => identifyCard = value; }
    public string Role { get => role; set => role = value; }
    public string UserName { get => userName; set => userName = value; }
    public string Password { get => password; set => password = value; }

    public bool checkCustomerInfo()
    {
        return !string.IsNullOrEmpty(this.FirstName) &&
               !string.IsNullOrEmpty(this.LastName) &&
               !string.IsNullOrEmpty(this.Phone) &&
               !string.IsNullOrEmpty(this.IdentifyCard) &&
               !string.IsNullOrEmpty(this.UserName) &&
               !string.IsNullOrEmpty(this.Password);
    }


    public string getCustomerName() {
        return firstName + lastName;
    }

    public void getBookingSchedule(Hotel hotel, DateTime startDate, DateTime endDate, DataGridView dataGridView)
    {
        List<Reservation> reservations = new Reservation().getReservations(hotel, startDate, endDate);
        if (reservations.Count == 0)
        {
            display("Không tìm thấy lịch đặt phòng !");
        }
        else
        {
            // Xóa d? li?u c? trong DataGridView
            dataGridView.Rows.Clear();
            dataGridView.Columns.Clear();

            // Thêm các c?t vào DataGridView
            dataGridView.Columns.Add("Id", "Reservation ID");
            dataGridView.Columns.Add("CreatedAt", "Created At");
            dataGridView.Columns.Add("RoomId", "Room ID");
            dataGridView.Columns.Add("CustomerName", "Customer Name");

            // ?? d? li?u t? reservations vào DataGridView
            foreach (Reservation reservation in reservations)
            {
                int roomId = reservation.Room.Id;
                string customerName = reservation.Customer.getCustomerName();
                display(
                    reservation.Id,
                    reservation.CreatedAt.ToString(),
                    roomId,
                    customerName
                );
            }
        }
    }

    public void createHotel (string name, string address, string picture)
    {
        if (Role != "Owner")
        {
            display("Chỉ owner mới có quyền thêm khách sạn !");
        } 
        else
        {
            Hotel newHotel = new Hotel();
            newHotel.addHotel(name, address, picture, this);
        }
    }



    private void display(int id, string v, int roomId, string customerName)
    {
        throw new NotImplementedException();
    }

    public void display(Object obj)
    { }
}