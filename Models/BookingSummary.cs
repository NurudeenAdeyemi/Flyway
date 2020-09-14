using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlywayAirlines.Models
{
    public class BookingSummary
    {
        public string bookingNumber { get; set; }
        public DateTime bookingDate { get; set; }
        public string bookingType { get; set; }
        public int seatNumber { get; set; }
        public int flightNumber { get; set; }
        public int flightPrice { get; set; }
        public DateTime takeOfTime { get; set; }
        public DateTime landingTime { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }

        public BookingSummary(string bookingNumber, DateTime bookingDate, string bookingType, int seatNumber, int flightNumber, int flightPrice, DateTime takeOfTime, DateTime landingTime, string firstName, string lastName)
        {
            this.bookingNumber = bookingNumber;
            this.bookingDate = bookingDate;
            this.bookingType = bookingType;
            this.seatNumber = seatNumber;
            this.flightNumber = flightNumber;
            this.flightPrice = flightPrice;
            this.takeOfTime = takeOfTime;
            this.landingTime = landingTime;
            this.firstName = firstName;
            this.lastName = lastName;

        }
    }
}
