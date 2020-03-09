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
        string geotag, bool multiDay, string banner1, string banner2, string banner3, string banner4, string banner5)
        {
            List<string> ban = new List<string> { banner1, banner2, banner3, banner4, banner5 };

            for (int i = 0; i < ban.Count; i++) 
            {
                //ban[i] = ban[i].Substring(78,ban[i].Length - 79);
                ban[i] = ban[i].Split("Banners/")[1];
            }

            Clinic clin = new Clinic(url, phone, fax, add1, add2,
             city, googUrl, embedUrl, days1, days2, hours1,
         hours2, hours3, hours4, ampm1, ampm2, ampm3, ampm4, busName, geotag, multiDay, ban);

            return View(clin);
        }
    }
}
