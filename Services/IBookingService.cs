using FlywayAirlines.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlywayAirlines.Services
{
    public interface IBookingService
    {
        public List<Booking> getAll();

        public string create(int flightid, int passengerid, string bookingType, int seatNumber);

        public bool update(int id, int flightid, int passengerid, string bookingType, int seatNumber);

        public bool remove(int id);

        public BookingSummary find(string bookingNumber);
        public Booking findById(int id);

        public int bookingCount(int id);
    }
}
