using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using AirQuality.Helpers;
using AirQuality.Models;
using Newtonsoft.Json;

namespace AirQuality.Services
{
    public class StationService: IStationService
    {
        public async Task<IEnumerable<Station>> GetStations()
        {
            var stations = new List<Station>();
            using(var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://api.gios.gov.pl/pjp-api/rest/");

                var response = await client.GetAsync("station/findAll");

                if(response.IsSuccessStatusCode)
                {
                    var res = await response.Content.ReadAsStringAsync();
                    stations = JsonConvert.DeserializeObject<List<Station>>(res, new StationConverter());

                }
            }
            return stations;
        }
    }
}