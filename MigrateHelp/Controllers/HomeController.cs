using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MigrateHelp.Models;

namespace MigrateHelp.Controllers
{
    public class HomeController : Controller
    {
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

        public IActionResult Result(string url, string phone, string fax, string add1, string add2, 
            string city, string googUrl, string embedUrl, string days1, string days2,
        string hours1,
        string hours2,
        string hours3,
        string hours4,
        string ampm1,
        string ampm2,
        string ampm3,
        string ampm4,
        string busName,
        string geotag, bool multiDay)
        {
            Clinic clin = new Clinic(url, phone, fax, add1, add2,
             city, googUrl, embedUrl, days1, days2, hours1,
         hours2, hours3, hours4, ampm1, ampm2, ampm3, ampm4, busName, geotag, multiDay);

            return View(clin);
        }
    }
}
