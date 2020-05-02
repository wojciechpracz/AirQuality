using System;
using System.Text.Json.Serialization;

namespace AirQuality.Models
{
    public class MeasuredValue
    {
        [JsonPropertyName("date")]        
        public string Date { get; set; }
        [JsonPropertyName("value")]        
        public string Value { get; set; }
    }
}