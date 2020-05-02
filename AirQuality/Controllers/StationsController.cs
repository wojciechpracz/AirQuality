using System.Linq;
using System.Threading.Tasks;
using AirQuality.Services;
using AirQuality.ViewModels;
using AirQuality.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

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

            var positions = await _service.GetPositions(station.StationId);

            var viewModel = new PositionListViewModel();
            viewModel.StationName = station.StationName;
            viewModel.Positions = positions.ToList();

            var measures = new List<string>();

            foreach (var position in positions)
            {
                var value = await _service.GetMeasuredValue(position.Id);

                if (value == null)
                {
                    value = "Brak danych";
                }

                measures.Add(value);
            }

            viewModel.PositionValuse = measures;

            var airIndex = await _service.GetAirQualityIndex(station.StationId);

            viewModel.AirIndex = airIndex.Value;

            return View("Positions",viewModel);

        }

    }
}