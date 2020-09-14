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
    public class BookingController : Controller
    {
        static string connStr = "server=localhost;user=root;database=airlinemanagement;port=3306;password=loveforall1990";
        static MySqlConnection conn = new MySqlConnection(connStr);
        static IBookingRepository bookingRepo = new BookingRepository(conn);
        static IBookingService bookingService = new BookingService(bookingRepo);
        static IFlightRepository flightRepository = new FlightRepository(conn);
        static IFlightService flightService = new FlightService(flightRepository);
        static IAircraftRepository aircraftRepo = new AircraftRepository(conn);
        static IAircraftService aircraftService = new AircraftService(aircraftRepo);
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
        public IActionResult create(int flightId, string bookingType)
        {
            if (string.IsNullOrEmpty(HttpContext.Request.Cookies["passenger_firstName"]))
            {
                return RedirectToAction("Index", "Home");
            }

            var passengerFirstName = HttpContext.Request.Cookies["passenger_firstName"];
            var passengerLastName = HttpContext.Request.Cookies["passenger_lastName"];
            var passengerPhoneNumber = HttpContext.Request.Cookies["passenger_phoneNumber"];
            var passengerGender = HttpContext.Request.Cookies["passenger_gender"];
            var passengerEmail = HttpContext.Request.Cookies["passenger_email"];
            var passengerDateOfBirth = DateTime.Parse(HttpContext.Request.Cookies["passenger_dateOfBirth"]);
            var passengerId = passengerService.create(passengerFirstName, passengerLastName, passengerPhoneNumber, passengerGender, passengerEmail, passengerDateOfBirth);

            Flight flight = flightService.findById(flightId);
            var capacity = aircraftService.getCapacity(flight.getAircraftid());
            var bookingCount = bookingService.bookingCount(flightId);

            var occupied = bookingCount;
            if (occupied >= capacity)
            {
                // the flight is full, return response
            }

            var seatNumber = occupied + 1;


            var bookingNumber = bookingService.create(flightId, passengerId, bookingType, seatNumber);

            if (string.IsNullOrEmpty(bookingNumber))
            {
                // an error occurred while creating the booking
            }

            return RedirectToAction("Details","Booking", new { bookingNumber });
        }
        [HttpGet]
        
        public IActionResult Display()
        {
            var bookingList = bookingService.getAll();
            return View(bookingList);
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Details(string bookingNumber)
        {
            var booking = bookingService.find(bookingNumber);
            if (booking == null)
            {
                return NotFound();
            }
            else
            {
                return View(booking);
            }
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var booking = bookingService.findById(id);
            if (booking == null)
            {
                return NotFound();
            }
            else
            {
                return View(booking);
            }
        }

        [HttpPost]
        public IActionResult Edit(int id, int flightid, int passengerid, string bookingType, int seatNumber)
        {
            bookingService.update(id, flightid, passengerid, bookingType, seatNumber);
            return RedirectToAction("Display");
        }



        [HttpGet]
        public IActionResult Delete(int id)
        {
            var booking = bookingService.findById(id);
            if (booking == null)
            {
                return NotFound();
            }
            return View();
        }

        [HttpPost]
        public IActionResult Delete(int id, string bookingNumber, int flightid, int passengerid, DateTime bookingDate, string bookingType, int seatNumber)
        {
            bookingService.remove(id);
            return RedirectToAction("Display");
        }
    }
}
