using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlywayAirlines.Services
{
    public interface IBookingService
    {
        public List<Booking> getAll();

        public bool create(int flightid, int passengerid, string bookingType, int seatNumber);

        public bool update(int id, int flightid, int passengerid, string bookingType, int seatNumber);

        public bool remove(int id);

        public Booking find(string bookingNumber);
        public Booking findById(int id);
    }
}
