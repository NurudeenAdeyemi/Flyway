using FlywayAirlines.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlywayAirlines.Services
{
    public class FlightService : IFlightService
    {
        private readonly IFlightRepository flightRepository;

        public FlightService(IFlightRepository flightRepository)
        {
            this.flightRepository = flightRepository;
        }
        public bool create(int flightNumber, int aircraftid, string takeOfPoint, Decimal flightDuration, DateTime takeOfTime, string destination, decimal flightPrice)
        {
            if (aircraftid <= 0)
            {
                return false;
            }
            return flightRepository.create(flightNumber, aircraftid, takeOfPoint, flightDuration, takeOfTime, destination, flightPrice);
        }

        public Flight find(int flightNumber)
        {
            return flightRepository.find(flightNumber);
        }

        public Flight findById(int id)
        {
            return flightRepository.findById(id);
        }

        public List<Flight> getAll()
        {
            return flightRepository.getAll();
        }

        public bool remove(int id)
        {
            return flightRepository.remove(id);
        }

        public bool update(int id, int flightNumber, int aircraftid, string takeOfPoint, Decimal flightDuration, DateTime takeOfTime, string destination, decimal flightPrice)
        {
            return flightRepository.update(id, flightNumber, aircraftid, takeOfPoint, flightDuration, takeOfTime, destination, flightPrice);
        }

        public List<Flight> search(string source, string destination, DateTime departureDate)
        {
            return flightRepository.search(source, destination, departureDate);
        }

    }
}
