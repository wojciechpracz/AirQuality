using System.Text.Json.Serialization;

namespace AirQuality.Models
{
    public class City
    {
        [JsonPropertyName("name")]        
        public string Name { get; set; }

        [JsonPropertyName("commune")]
        AirQuality.Models.Commune Commune { get; set; }

    }
}