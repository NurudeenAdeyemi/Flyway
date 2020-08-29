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
        public bool create(int bookingNumber, int flightid, DateTime bookingDate, string bookingType, int seatNumber)
        {
            if (flightid <= 0)
            {
                return false;
            }
            return bookingRepository.create(bookingNumber, flightid, bookingDate, bookingType, seatNumber);
        }

        public Booking find(int bookingNumber)
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

        public bool update(int id, int bookingNumber, int flightid, DateTime bookingDate, string bookingType, int seatNumber)
        {
            return bookingRepository.update(id, bookingNumber, flightid, bookingDate, bookingType, seatNumber);
        }
    }
}
