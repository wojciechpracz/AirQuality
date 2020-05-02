using System.Collections.Generic;
using System.Threading.Tasks;
using AirQuality.Models;

namespace AirQuality.Services
{
    public interface IStationService
    {
        Task<IEnumerable<Station>> GetStations();

    }
}