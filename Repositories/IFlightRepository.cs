using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlywayAirlines.Repositories
{
    public interface IFlightRepository
    {
        public List<Flight> getAll();

        public bool create(int flightNumber, int aircraftid, string takeOfPoint, Decimal flightDuration, DateTime takeOfTime,  string destination, decimal flightPrice);

        public bool update(int id, int flightNumber, int aircraftid, string takeOfPoint, Decimal flightDuration, DateTime takeOfTime,  string destination, decimal flightPrice);

        public bool remove(int id);

        public Flight find(int flightNumber);

        public Flight findById(int id);

        public void displayAll();

        public List<Flight> search(string source, string destination, DateTime departureDate);
    }
}
