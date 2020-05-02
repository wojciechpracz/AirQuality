using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AirQuality.Models;
using AirQuality.Services;
using AirQuality.ViewModels;

namespace AirQuality.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStationService _service;

        public HomeController(IStationService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var stations = await _service.GetStations();
            return View(stations);
        }

    }
}
