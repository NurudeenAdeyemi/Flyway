using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlywayAirlines
{
    public class Booking
    {
        private int id;
        private string bookingNumber;
        private int flightid;
        private DateTime bookingDate;
        private string bookingType;
        private int seatNumber;
        private int passengerid;
        public Flight flight { get; set; }
        public Passenger passenger { get; set; }

        public Booking(int id, string bookingNumber, int flightid, int passengerid,  DateTime bookingDate, string bookingType, int seatNumber)
        {
            this.id = id;
            this.bookingNumber = bookingNumber;
            this.flightid = flightid;
            this.passengerid = passengerid;
            this.bookingDate = bookingDate;
            this.bookingType = bookingType;
            this.seatNumber = seatNumber;
        }

        public void setId(int id)
        {
            this.id = id;
        }
        public int getId()
        {
            return id;
        }

        public void setFlightid(int flightid)
        {
            this.flightid = flightid;
        }
        public int getFlightid()
        {
            return flightid;
        }

        public void setPassengerid(int passengerid)
        {
            this.passengerid = passengerid;
        }
        public int getPassengerid()
        {
            return passengerid;
        }

        public void setBookingNumber(string bookingNumber)
        {
            this.bookingNumber = bookingNumber;
        }
        public string getBookingNumber()
        {
            return bookingNumber;
        }


        public void setBookingDate(DateTime bookingDate)
        {
            this.bookingDate = bookingDate;
        }
        public DateTime getBookingDate()
        {
            return bookingDate;
        }

        public void setBookingType(string bookingType)
        {
            this.bookingType = bookingType;
        }
        public string getBookingType()
        {
            return bookingType;
        }

        public void setSeatNumbere(int seatNumber)
        {
            this.seatNumber = seatNumber;
        }
        public int getSeatNumber()
        {
            return seatNumber;
        }

        public override string ToString()
        {
            return $"{id}\t{bookingNumber}\t{flightid}\t{bookingDate}\t{bookingType}\t{seatNumber}";
        }
    }
}
