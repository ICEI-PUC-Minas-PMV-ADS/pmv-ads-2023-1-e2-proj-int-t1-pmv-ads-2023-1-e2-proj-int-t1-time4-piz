using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PizzApp.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using PizzApp.Repositories.Interfaces;
using PizzApp.ViewModels;

namespace PizzApp.Controllers
{
    public class HomeController : Controller
    {
       
        public IActionResult Index()
        {
           
            TempData["Nome"] = "PizzApp";
            return View();
           
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
