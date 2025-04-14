
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

    public void getBookingSchedule(DateTime startDate, DateTime endDate)
    {
        // TODO implement here
    }

    public void saveReservation() {
        // TODO implement here
    }

    public List<Reservation> getReservations(DateTime startDate, DateTime endDate)
    {
        List<Reservation> reservationList = new List<Reservation>();
        foreach(Reservation r in reservationList)
        {
            if (startDate <= r.payment.getPaymentDate() &&
                r.payment.getPaymentDate() <= endDate)
            {
                reservationList.Add(r);
            }   
        }
    }

    public void getRevenueReport(DateTime startDate, DateTime endDate) 
    {
        List<Reservation> reservationList = getReservations(startDate, endDate);

        for(int i = reservationList.Count - 1; i >= 0; i--) 
        { 
            Reservation reservation = reservationList[i];

            string paymentStatus = reservation.payment?.getStatus();

            if (paymentStatus == "Paid")
            {
                reservationList.Remove(reservation);
            }
        }

        if (reservationList.Count > 0) {
            return reservationList;
        }
        else {
            throw new Exception("Not found revenue");
        }
    }

    public string makePayment()
    {
        payment = new Payment();
        return payment.processPayment(this);
    }

}