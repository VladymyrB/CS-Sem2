using CalculatorProject.Context;
using CalculatorProject.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CalculatorProject.Controllers
{
    public class AuthController : Controller
    {
        private readonly CalculatorDbContext _dbContext;

        public AuthController(CalculatorDbContext db)
        {
            _dbContext = db;
        }

        [HttpPost]
        public IActionResult AuthPage(User user)
        {
            var searchedUser = _dbContext.Users.FirstOrDefault(i => i.Login == user.Login && i.Password == user.Password);
            if (searchedUser != null)
            {
                return Redirect($"~/Home/Index?FirstName={searchedUser.FirstName}");
            }

            return View();
        }

        [HttpGet]
        public IActionResult AuthPage()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
