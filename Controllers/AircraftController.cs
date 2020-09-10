using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FlywayAirlines.Models;
using FlywayAirlines.Repositories;
using FlywayAirlines.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;

namespace FlywayAirlines.Controllers
{
    [Authorize]
    public class AircraftController : Controller
    {
        static string connStr = "server=localhost;user=root;database=airlinemanagement;port=3306;password=loveforall1990";
        static MySqlConnection conn = new MySqlConnection(connStr);
        static IAircraftRepository aircraftRepo = new AircraftRepository(conn);
        static IAircraftService aircraftService = new AircraftService(aircraftRepo);
        [HttpGet]
        public IActionResult create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult create(string name, string type, string registrationNumber, int capacity, string manufacturer, int cruiseSpeed)
        {
            aircraftService.create(name, type, registrationNumber,capacity, manufacturer, cruiseSpeed);
            return RedirectToAction("Display");

        }
        [HttpGet]
        public IActionResult Display()
        {
            var aircraftList = aircraftService.getAll();
            return View(aircraftList);
        }

        [HttpGet]

        public IActionResult Details(int id)
        {
            var aircraft = aircraftService.findById(id);
            if (aircraft == null)
            {
                return NotFound();
            }
            else
            {
                return View(aircraft);
            }
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var aircraft = aircraftService.findById(id);
            if (aircraft == null)
            {
                return NotFound();
            }
            else
            {
                return View(aircraft);
            }
        }

        [HttpPost]
        public IActionResult Edit(int id, string name, string type, string registrationNumber, int capacity, string manufacturer, int cruiseSpeed)
        {
            aircraftService.update(id, name, type, registrationNumber, capacity, manufacturer, cruiseSpeed);
            return RedirectToAction("Display");
        }



        [HttpGet]
        public IActionResult Delete(int id)
        {
            var aircraft = aircraftService.findById(id);
            if (aircraft == null)
            {
                return NotFound();
            }
            return View(aircraft);
        }

        [HttpPost]
        public IActionResult Delete(int id, int x)
        {
                aircraftService.remove(id);
                return RedirectToAction("Display");
        }
            
    }
}
