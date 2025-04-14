
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

        return true;
    }


    public void checkAvailable(DateTime checkIn, DateTime checkOut, int guestCount) {
        // TODO implement here
    }

    public void checkCapacity(int guestCount) {
        // TODO implement here
    }

    public void getId() {
        // TODO implement here
    }

}