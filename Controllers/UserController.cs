using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using FlywayAirlines.Repositories;
using FlywayAirlines.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;

namespace FlywayAirlines.Controllers
{
    [Authorize]

    public class UserController : Controller
    {
        static string connStr = "server=localhost;user=root;database=flyway;port=3306;password=password";
        static MySqlConnection conn = new MySqlConnection(connStr);
        static IUserRepository userRepository = new UserRepository(conn);
        static IUserService userService = new UserService(userRepository);
        [HttpGet]
        public IActionResult create()
        {
            return View();
        }

        [HttpPost]

        public IActionResult create(string firstName, string lastName, string email, string password)
        {
            userService.create(firstName, lastName, email, password);
            return RedirectToAction("Display");

        }
        [HttpGet]
        public IActionResult Display()
        {
            var users = userService.getAll();
            return View(users);
        }

        [HttpGet]

        public IActionResult Details(int id)
        {
            var user = userService.findById(id);
            if (user == null)
            {
                return NotFound();
            }
            else
            {
                return View(user);
            }
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var user = userService.findById(id);
            if (user == null)
            {
                return NotFound();
            }
            else
            {
                return View(user);
            }
        }

        [HttpPost]
        public IActionResult Edit(int id, string firstName, string lastName, string email, string password)
        {
            userService.update(id, firstName, lastName, email, password);
            return RedirectToAction("Display");
        }



        [HttpGet]
        public IActionResult Delete(int id)
        {
            var user = userService.findById(id);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }

        [HttpPost]
        public IActionResult Delete(int id, int x)
        {
            userService.remove(id);
            return RedirectToAction("Display");
        }

        [HttpGet]
        public IActionResult Logout()
        {

            HttpContext.SignOutAsync();
            return RedirectToAction("Login");
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login()
        {

            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public IActionResult Login(string email, string password)
        {
            User user = userService.find(email, password);
            if (user == null)
            {
                ViewBag.Message = "Invalid Username/Password";
                return View();
            }
            else
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, user.getEmail()),
                    new Claim(ClaimTypes.Email, user.getEmail())
                };
                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var authenticationProperties = new AuthenticationProperties();
                var principal = new ClaimsPrincipal(claimsIdentity);
                HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal, authenticationProperties);
                return RedirectToAction("Admin", "User");
            }

        }

        [HttpGet]
        public IActionResult Admin()
        {

            return View();
        }
    }
}
