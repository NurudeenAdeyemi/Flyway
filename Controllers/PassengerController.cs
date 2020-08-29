using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FlywayAirlines.Repositories;
using FlywayAirlines.Services;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;

namespace FlywayAirlines.Controllers
{
    public class PassengerController : Controller
    {
        static string connStr = "server=localhost;user=root;database=airlinemanagement;port=3306;password=loveforall1990";
        static MySqlConnection conn = new MySqlConnection(connStr);
        static IPassengerRepository passengerRepo = new PassengerRepository(conn);
        static IPassengerService passengerService = new PassengerService(passengerRepo);
        
        [HttpGet]
        public IActionResult create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult create(string firstName, string lastName, int bookingid, string address, double phoneNumber, string email, string gender, DateTime dateOfBirth)
        {
            passengerService.create(firstName, lastName, bookingid, address, phoneNumber, email, gender, dateOfBirth);
            return RedirectToAction("Display");

        }
        [HttpGet]
        public IActionResult Display()
        {
            var passengerList = passengerService.getAll();
            return View(passengerList);
        }

        [HttpGet]

        public IActionResult Details(int id)
        {
            var passenger = passengerService.findById(id);
            if (passenger == null)
            {
                return NotFound();
            }
            else
            {
                return View(passenger);
            }
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var passenger = passengerService.findById(id);
            if (passenger == null)
            {
                return NotFound();
            }
            else
            {
                return View(passenger);
            }
        }

        [HttpPost]
        public IActionResult Edit(int id, string firstName, string lastName, int bookingid, string address, double phoneNumber, string email, string gender, DateTime dateOfBirth)
        {
            passengerService.update(id, firstName, lastName, bookingid, address, phoneNumber, email, gender, dateOfBirth);
            return RedirectToAction("Display");
        }



        [HttpGet]
        public IActionResult Delete(int id)
        {
            var passenger = passengerService.findById(id);
            if (passenger == null)
            {
                return NotFound();
            }
            return View();
        }

        [HttpPost]
        public IActionResult Delete(int id, string firstName, string lastName, int bookingid, string address, double phoneNumber, string email, string gender, DateTime dateOfBirth)
        {
            passengerService.remove(id);
            return RedirectToAction("Display");
        }
    }
}
