using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FlywayAirlines.Models;
using FlywayAirlines.Repositories;
using FlywayAirlines.Services;
using MySql.Data.MySqlClient;

namespace FlywayAirlines.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        static string connStr = "server=localhost;user=root;database=flyway;port=3306;password=password";
        static MySqlConnection conn = new MySqlConnection(connStr);
        static IFlightRepository flightRepo = new FlightRepository(conn);
        static IFlightService flightService = new FlightService(flightRepo);

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]

        public IActionResult FlightSearch(string source, string destination, DateTime departureDate )
        {
            List<Flight> flights = flightService.search(source, destination, departureDate);
            return View("Index", flights);
        }
    }
}
