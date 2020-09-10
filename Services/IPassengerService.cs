using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlywayAirlines.Services
{
    public interface IPassengerService
    {
        public List<Passenger> getAll();

        public bool create(string firstName, string lastName,  double phoneNumber, string email, string gender, DateTime dateOfBirth);

        public bool update(int id, string firstName, string lastName, double phoneNumber, string email, string gender, DateTime dateOfBirth);

        public bool remove(int id);

        public Passenger find(string lastName);
        public Passenger findById(int id);
    }
}

