using FlywayAirlines.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlywayAirlines.Services
{
    public class PassengerService : IPassengerService
    {
        private readonly IPassengerRepository passengerRepository;

        public PassengerService(IPassengerRepository passengerRepository)
        {
            this.passengerRepository = passengerRepository;
        }
        public bool create(string firstName, string lastName, int bookingid, string address, double phoneNumber, string email, string gender, DateTime dateOfBirth)
        {
            if (bookingid <= 0)
            {
                return false;
            }
            return passengerRepository.create(firstName, lastName, bookingid, address, phoneNumber, email, gender, dateOfBirth);
        }

        public Passenger find(int bookingid)
        {
            return passengerRepository.find(bookingid);
        }

        public Passenger findById(int id)
        {
            return passengerRepository.findById(id);
        }

        public List<Passenger> getAll()
        {
            return passengerRepository.getAll();
        }

        public bool remove(int id)
        {
            return passengerRepository.remove(id);
        }

        public bool update(int id, string firstName, string lastName, int bookingid, string address, double phoneNumber, string email, string gender, DateTime dateOfBirth)
        {
            return passengerRepository.update(id, firstName, lastName, bookingid, address, phoneNumber, email, gender, dateOfBirth);
        }
    }
}
