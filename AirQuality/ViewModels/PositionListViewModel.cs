using System.Collections.Generic;
using AirQuality.Models;

namespace AirQuality.ViewModels
{
    public class PositionListViewModel
    {
        public string StationName { get; set; }
        public List<MeasurementPosition> Positions { get; set; }
    }
}