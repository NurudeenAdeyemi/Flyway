﻿using FlywayAirlines.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlywayAirlines.Repositories
{
    public interface IAircraftRepository
    {
        public List<Aircraft> getAll();

        public bool create(string name, string type, string registrationNumber, int capacity, string manufacturer, int cruiseSpeed);

        public bool update(int id, string name, string type, string registrationNumber, int capacity,  string manufacturer, int cruiseSpeed);

        public bool remove(int id);

        public Aircraft find(string registrationNumber);
        public Aircraft findById(int id);

        public void displayAll();

        public int getCapacity(int id);
    }
}

