using CalculatorProject.Context;
using CalculatorProject.Models;
using CalculatorProject.Services.TranslatorService.Classes;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CalculatorProject.Controllers
{
    public class RegistrationController : Controller
    {
        private readonly CalculatorDbContext _dbContext;

        public RegistrationController(CalculatorDbContext db)
        {
            _dbContext = db;
        }

        [HttpPost]
        public async Task<IActionResult> RegistrationPage(
          string login, string password, long country, string
            firstName, string lastName, string patronymic, DateTime birthDate)
        {
            var user = new User
            {
                FirstName = firstName,
                LastName = lastName,
                Patronymic = patronymic,
                Login = login,
                Password = password,
                BirthDate = birthDate,
                Country = await _dbContext.Countries.FindAsync(country)
            };

            await _dbContext.Users.AddAsync(user);
            await _dbContext.SaveChangesAsync();

            return Redirect($"~/Home/Index?FirstName={user.FirstName}");
        }

        [HttpGet]
        public IActionResult RegistrationPage()
        {
            return View(_dbContext.Countries);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
