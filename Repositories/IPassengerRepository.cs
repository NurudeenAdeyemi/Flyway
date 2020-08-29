using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlywayAirlines.Repositories
{
    public interface IPassengerRepository
    {
        public List<Passenger> getAll();

        public bool create(string firstName, string lastName, int bookingid, string address, double phoneNumber, string email, string gender, DateTime dateOfBirth);

        public bool update(int id, string firstName, string lastName, int bookingid, string address, double phoneNumber, string email, string gender, DateTime dateOfBirth);

        public bool remove(int id);

        public Passenger find(int bookingid);

        public Passenger findById(int id);

        public void displayAll();
    }
}
