using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Webapp2021.Models;

namespace Webapp2021.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly TestDbContext _TestDbContext;


        public HomeController(ILogger<HomeController> logger, TestDbContext TestDbContext)
        {
            _logger = logger;
            _TestDbContext = TestDbContext;
        }

        public IActionResult Index()
        {
            ViewData.Model = _TestDbContext.Phones.OrderBy(item => item.Id).ToList();
            return View();
        }

        public IActionResult GetTest(int id)
        {
            ViewData.Model = _TestDbContext.Phones.FirstOrDefault(i => i.Id == id);
            return View();
        }
        [HttpGet]
        public IActionResult EditTest(int id)
        {
            ViewData.Model = _TestDbContext.Phones.FirstOrDefault(i => i.Id == id);
            return View();
        }
        [HttpPost]
        public IActionResult EditTest(Phone Phone)
        {
            var fromDB = _TestDbContext.Phones.Find(Phone.Id);
            fromDB.IsActive = Phone.IsActive;
            fromDB.Description = Phone.Description;
            fromDB.Name = Phone.Name;
            fromDB.Model = Phone.Model;
            fromDB.Creator = Phone.Creator;
            fromDB.Created = Phone.Created;
            fromDB.Updated = Phone.Updated;
            _TestDbContext.SaveChanges();

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
    }
}
