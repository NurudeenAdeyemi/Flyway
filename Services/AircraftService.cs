using FlywayAirlines.Models;
using FlywayAirlines.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlywayAirlines.Services
{
    public class AircraftService : IAircraftService
    {
        private readonly IAircraftRepository aircraftRepository;

        public AircraftService(IAircraftRepository aircraftRepository)
        {
            this.aircraftRepository = aircraftRepository;
        }
        public bool create(string name, string type, string registrationNumber, int capacity, string manufacturer, int cruiseSpeed)
        {
           if (capacity<=0)
            {
                return false;
            }
            return aircraftRepository.create(name, type, registrationNumber, capacity, manufacturer, cruiseSpeed);
        }

        public Aircraft find(string registrationNumber)
        {
            return aircraftRepository.find(registrationNumber);
        }

        public Aircraft findById(int id)
        {
            return aircraftRepository.findById(id);
        }

        public List<Aircraft> getAll()
        {
            return aircraftRepository.getAll();
        }

        public bool remove(int id)
        {
            return aircraftRepository.remove(id);
        }

        public bool update(int id, string name, string type, string registrationNumber, int capacity, string manufacturer, int cruiseSpeed)
        {
            return aircraftRepository.update(id, name, type, registrationNumber, capacity, manufacturer, cruiseSpeed);
        }
    }
}
