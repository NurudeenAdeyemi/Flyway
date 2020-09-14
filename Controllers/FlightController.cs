using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Threading.Tasks;
using FlywayAirlines.Repositories;
using FlywayAirlines.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MySql.Data.MySqlClient;

namespace FlywayAirlines.Controllers
{
    [Authorize]
    public class FlightController : Controller
    {
        static string connStr = "server=localhost;user=root;database=airlinemanagement;port=3306;password=loveforall1990";
        static MySqlConnection conn = new MySqlConnection(connStr);
        static IFlightRepository flightRepo = new FlightRepository(conn);
        static IFlightService flightService = new FlightService(flightRepo);
        static IAircraftRepository aircraftRepository = new AircraftRepository(conn);
        static IAircraftService aircraftService = new AircraftService(aircraftRepository);
        [HttpGet]
        public IActionResult create()
        {
            List<Aircraft> aircrafts = aircraftService.getAll();
            List<SelectListItem> listAItems = new List<SelectListItem>();
            foreach (Aircraft aircraft in aircrafts)
            {
                SelectListItem item = new SelectListItem(aircraft.getRegistrationNumber(), aircraft.getId().ToString());
                listAItems.Add(item);
            }

            ViewBag.Aircrafts = listAItems;
            return View();
        }

        [HttpPost]
        public IActionResult create(int flightNumber, int aircraftid, string takeOfPoint, DateTime landingTime, DateTime takeOfTime, string destination, decimal flightPrice)
        {
            flightService.create(flightNumber, aircraftid, takeOfPoint, landingTime, takeOfTime,  destination, flightPrice);
            return RedirectToAction("Display");

        }
        [HttpGet]
        public IActionResult Display()
        {
            var flightList = flightService.getAll();
            return View(flightList);
        }

        [HttpGet]

        public IActionResult Details(int id)
        {
            var flight = flightService.findById(id);
            if (flight == null)
            {
                return NotFound();
            }
            else
            {
                return View(flight);
            }
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var flight = flightService.findById(id);
            if (flight == null)
            {
                return NotFound();
            }
            else
            {
                return View(flight);
            }
        }

        [HttpPost]
        public IActionResult Edit(int id, int flightNumber, int aircraftid, string takeOfPoint, DateTime landingTime, DateTime takeOfTime,  string destination, decimal flightPrice)
        {
            flightService.update(id, flightNumber, aircraftid, takeOfPoint, landingTime, takeOfTime, destination, flightPrice);
            return RedirectToAction("Display");
        }



        [HttpGet]
        public IActionResult Delete(int id)
        {
            var flight = flightService.findById(id);
            if (flight == null)
            {
                return NotFound();
            }
            return View();
        }

        [HttpPost]
        public IActionResult Delete(int id, int flightNumber, int aircraftid, string takeOfPoint, DateTime landingTime, DateTime takeOfTime, string destination, decimal flightPrice)
        {
            flightService.remove(id);
            return RedirectToAction("Display");
        }

    }
}
