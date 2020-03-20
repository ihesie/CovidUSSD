using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using covidUSSD.Web.Models;
using CovidUSSD.Service;
using CovidUSSD.Entities;

namespace covidUSSD.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IRepository<MenuItem> repository;

        public HomeController(ILogger<HomeController> logger, IRepository<MenuItem> repository)
        {
            _logger = logger;
            this.repository = repository;
        }

        public IActionResult Index()
        {
            //this.repository.Insert()
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
