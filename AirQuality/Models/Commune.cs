using System.Text.Json.Serialization;

namespace AirQuality.Models
{
    public class Commune
    {
        [JsonPropertyName("communeName")]        
        public string Name { get; set; }
        
        [JsonPropertyName("districtName")]        
        public string DistrictName { get; set; }
        [JsonPropertyName("provinceName")]        
        public string ProvinceName { get; set; }
    }
}