
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


    public void searchHotel(string address, DateTime checkIn, DateTime checkOut, int guestCount) {
        // TODO implement here
    }


    public void removeRoom(Room room) {
        // TODO implement here
    }


    public void getHotelByAddress(string address) {
        // TODO implement here
    }

}