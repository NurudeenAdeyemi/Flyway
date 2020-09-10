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
        [HttpGet]
        [AllowAnonymous]
        public IActionResult create()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public IActionResult create(int flightid, int passengerid, string bookingType, int seatNumber)
        {
            bookingService.create(flightid, passengerid, bookingType, seatNumber);
            return RedirectToAction("Details","Booking");

        }
        [HttpGet]
        [AllowAnonymous]
        public IActionResult Display()
        {
            var bookingList = bookingService.getAll();
            return View(bookingList);
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Details(int id)
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
