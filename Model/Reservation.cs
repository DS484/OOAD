
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;

public class Reservation {

    public Reservation() {
    }

    private int id;

    private DateTime checkIn;

    private DateTime checkOut;

    private DateTime createdAt;

    private Room room = new Room();

    private User customer = new User();

    private Payment payment;


    public Reservation bookRoom(User customer, Room room, DateTime checkIn, DateTime CheckOut) {
        bool check = customer.checkCustomerInfor();

        if (!check)
        {
            throw new Exception("Invalid Customer Infor");
        }
        else
        {
            bool isAvailable = room.checkAvailable(checkIn, checkOut);
            if (isAvailable)
            {
                saveReservation();
                return this;
            }
            else
            {
                throw new Exception("Room Not Available");
            }
        } 
    }

    public List<ReservationDTO> getBookingSchedule(Hotel hotel, DateTime startDate, DateTime endDate)
    {
        List<Reservation> reservations = getReservations(hotel, startDate, endDate); 
        if (reservations.Count == 0)
        {
            throw new Exception("Not Found Reservation");
        }
        else
        {
            List<ReservationDTO> reservationDTOs = new List<ReservationDTO>();
            foreach (Reservation reservation in reservations)
            {
                int roomId = reservation.room.getId();
                string customername = reservation.customer.getCustomerName();
                reservationDTOs.Add(new ReservationDTO(reservation.id,reservation.createdAt,roomId, customername));
            }
            return reservationDTOs;
        }
        

    }

    public void saveReservation() {
        // TODO implement here
    }

    public List<Reservation> getReservations(Hotel hotel, DateTime startDate, DateTime endDate) {
        return null;
    }

    public void getRevenueReport(DateTime startDate, DateTime endDate) {
        // TODO implement here
    }

    public string makePayment()
    {
        payment = new Payment();
        return payment.processPayment(this);
    }

    

}