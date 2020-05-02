using System.Linq;
using System.Threading.Tasks;
using AirQuality.Services;
using AirQuality.ViewModels;
using AirQuality.Models;
using Microsoft.AspNetCore.Mvc;

namespace AirQuality.Controllers
{
    public class StationsController : Controller
    {
        private readonly IStationService _service;
        public StationsController(IStationService service)
        {
            this._service = service;
        }

        public async Task<IActionResult> GetPositions(int id)
        {
            var stations = await _service.GetStations();
            var station = stations.FirstOrDefault(s => s.StationId == id);

            var positions = await _service.GetPositions(14);

            var viewModel = new PositionListViewModel();
            viewModel.StationName = station.StationName;
            viewModel.Positions = positions.ToList();

            return View("Positions",viewModel);

        }

    }
}