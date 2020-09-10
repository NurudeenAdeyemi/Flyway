using FlywayAirlines.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlywayAirlines.Services
{
    public class BookingService : IBookingService
    {
        private readonly IBookingRepository bookingRepository;

        public BookingService(IBookingRepository bookingRepository)
        {
            this.bookingRepository = bookingRepository;
        }
        public bool create(int flightid, int passengerid, string bookingType, int seatNumber)
        {
            if (flightid <= 0)
            {
                return false;
            }
            var bookingNumber = Guid.NewGuid().ToString().Replace("-", "").Substring(0, 10);
            var bookingDate = DateTime.Now;
            return bookingRepository.create(bookingNumber, flightid, passengerid, bookingDate, bookingType, seatNumber);
        }

        public Booking find(string bookingNumber)
        {
            return bookingRepository.find(bookingNumber);
        }

        public Booking findById(int id)
        {
            return bookingRepository.findById(id);
        }

        public List<Booking> getAll()
        { 
            return bookingRepository.getAll();
        }

        public bool remove(int id)
        {
            return bookingRepository.remove(id);
        }

        public bool update(int id,  int flightid, int passengerid, string bookingType, int seatNumber)
        {
            var bookingNumber = Guid.NewGuid().ToString().Replace("-", "").Substring(0, 10);
            var bookingDate = DateTime.Now;
            return bookingRepository.update(id, bookingNumber, flightid, passengerid, bookingDate, bookingType, seatNumber);
        }
    }
}
