using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FlywayAirlines.Repositories;
using FlywayAirlines.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;

namespace FlywayAirlines.Controllers
{
    [Authorize]
    public class PassengerController : Controller
    {
        static string connStr = "server=localhost;user=root;database=airlinemanagement;port=3306;password=loveforall1990";
        static MySqlConnection conn = new MySqlConnection(connStr);
        static IPassengerRepository passengerRepo = new PassengerRepository(conn);
        static IPassengerService passengerService = new PassengerService(passengerRepo);
        
        [HttpGet]
       [AllowAnonymous]
        public IActionResult create(int flightId)
        {
            if (flightId == default)
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public IActionResult create(string firstName, string lastName, string phoneNumber, string email, string gender, DateTime dateOfBirth, int flightId)
        {
            if (flightId == default)
            {
                return RedirectToAction("Index", "Home");
            }

            HttpContext.Response.Cookies.Append("passenger_firstName", firstName);
            HttpContext.Response.Cookies.Append("passenger_lastName", lastName);
            HttpContext.Response.Cookies.Append("passenger_phoneNumber", phoneNumber);
            HttpContext.Response.Cookies.Append("passenger_email", email);
            HttpContext.Response.Cookies.Append("passenger_gender", gender);
            HttpContext.Response.Cookies.Append("passenger_dateOfBirth", dateOfBirth.ToString());

            return RedirectToAction("Create", "Booking", routeValues: new
            {
                flightId
            });
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
        public IActionResult Edit(int id, string firstName, string lastName, string phoneNumber, string email, string gender, DateTime dateOfBirth)
        {
            passengerService.update(id, firstName, lastName,  phoneNumber, email, gender, dateOfBirth);
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
        public IActionResult Delete(int id, string firstName, string lastName, string phoneNumber, string email, string gender, DateTime dateOfBirth)
        {
            passengerService.remove(id);
            return RedirectToAction("Display");
        }
    }
}
