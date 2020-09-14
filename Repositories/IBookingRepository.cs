using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FlywayAirlines.Models;

namespace FlywayAirlines.Repositories
{
    public interface IBookingRepository
    {
        public List<Booking> getAll();

        public bool create(string bookingNumber, int flightid, int passengerid, DateTime bookingDate, string bookingType, int seatNumber);

        public bool update(int id, string bookingNumber, int flightid, int passengerid, DateTime bookingDate, string bookingType, int seatNumber);

        public bool remove(int id);

        public BookingSummary find(string bookingNumber);

        public Booking findById(int id);

        public void displayAll();

        public int bookingCount(int id);
    }
}
