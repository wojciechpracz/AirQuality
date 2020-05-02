using System.Collections.Generic;
using AirQuality.Models;

namespace AirQuality.ViewModels
{
    public class PositionListViewModel
    {
        public string StationName { get; set; }
        public List<MeasurementPosition> Positions { get; set; }
        public List<string> PositionValuse { get; set; }
        public string AirIndex { get; set; }
    }
}