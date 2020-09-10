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
        public bool create(string firstName, string lastName,  double phoneNumber, string email, string gender, DateTime dateOfBirth)
        {
            if (lastName == null)
            {
                return false;
            }
            return passengerRepository.create(firstName, lastName, phoneNumber, email, gender, dateOfBirth);
        }

        public Passenger find(string lastName)
        {
            return passengerRepository.find(lastName);
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

        public bool update(int id, string firstName, string lastName, double phoneNumber, string email, string gender, DateTime dateOfBirth)
        {
            return passengerRepository.update(id, firstName, lastName, phoneNumber, email, gender, dateOfBirth);
        }
    }
}
