using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlywayAirlines.Repositories
{
    public interface IBookingRepository
    {
        public List<Booking> getAll();

        public bool create(string bookingNumber, int flightid, int passengerid, DateTime bookingDate, string bookingType, int seatNumber);

        public bool update(int id, string bookingNumber, int flightid, int passengerid, DateTime bookingDate, string bookingType, int seatNumber);

        public bool remove(int id);

        public Booking find(string bookingNumber);

        public Booking findById(int id);

        public void displayAll();
    }
}
