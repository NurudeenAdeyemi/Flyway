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
    public class BookingController : Controller
    {
        static string connStr = "server=localhost;user=root;database=airlinemanagement;port=3306;password=loveforall1990";
        static MySqlConnection conn = new MySqlConnection(connStr);
        static IBookingRepository bookingRepo = new BookingRepository(conn);
        static IBookingService bookingService = new BookingService(bookingRepo);
        [HttpGet]
        public IActionResult create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult create(int bookingNumber, int flightid, DateTime bookingDate, string bookingType, int seatNumber)
        {
            bookingService.create(bookingNumber, flightid, bookingDate, bookingType, seatNumber);
            return RedirectToAction("Display");

        }
        [HttpGet]
        public IActionResult Display()
        {
            var bookingList = bookingService.getAll();
            return View(bookingList);
        }

        [HttpGet]

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
        public IActionResult Edit(int id, int bookingNumber, int flightid, DateTime bookingDate, string bookingType, int seatNumber)
        {
            bookingService.update(id, bookingNumber, flightid, bookingDate, bookingType, seatNumber);
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
        public IActionResult Delete(int id, int flightNumber, int aircraftid, string takeOfPoint, Decimal flightDuration, DateTime takeOfTime, string destination, decimal flightPrice)
        {
            bookingService.remove(id);
            return RedirectToAction("Display");
        }
    }
}
