using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlywayAirlines
{
    public class Booking
    {
        private int id;
        private int bookingNumber;
        private int flightid;
        private DateTime bookingDate;
        private string bookingType;
        private int seatNumber;

        public Booking(int id, int bookingNumber, int flightid, DateTime bookingDate, string bookingType, int seatNumber)
        {
            this.id = id;
            this.bookingNumber = bookingNumber;
            this.flightid = flightid;
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

        public void setBookingNumber(int bookingNumber)
        {
            this.bookingNumber = bookingNumber;
        }
        public int getBookingNumber()
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
