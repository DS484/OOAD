
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Room {

    public Room() {
    }

    private int id;

    private int roomNumber;

    private string picture;

    private string description;

    private double price;

    private int capacity;

    public bool checkAvailable(DateTime checkIn, DateTime checkOut) {
        // TODO implement here
        return RoomDao.checkAvailable(DateTime checkIn, DateTime checkOut);
    }


    public bool checkAvailable(DateTime checkIn, DateTime checkOut, int guestCount) {
        // TODO implement here

        return checkCapacity(guestCount) && checkAvailable(checkIn, checkOut);
    }

    public bool checkCapacity(int guestCount) {
        // TODO implement here
        return capacity >= guestCount;
    }

    public int getId() {
        return id;
        // TODO implement here
    }

}