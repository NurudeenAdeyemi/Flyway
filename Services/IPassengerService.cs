using System;
using System.Collections.Generic;

namespace FlywayAirlines.Services
{
    public interface IPassengerService
    {
        public List<Passenger> getAll();

        public int create(string firstName, string lastName, string phoneNumber, string email, string gender, DateTime dateOfBirth);

        public bool update(int id, string firstName, string lastName, string phoneNumber, string email, string gender, DateTime dateOfBirth);

        public bool remove(int id);

        public Passenger find(string lastName);
        public Passenger findById(int id);
    }
}

