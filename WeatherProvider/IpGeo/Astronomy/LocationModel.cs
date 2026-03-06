using System.Text.Json.Serialization;

namespace Xcalibur.Weather.Models.WeatherProvider.IpGeo.Astronomy
{
    /// <summary>
    /// Location information model.
    /// </summary>
    public class LocationModel
    {
        [JsonPropertyName("latitude")]
        public string? Latitude { get; set; }

        [JsonPropertyName("longitude")]
        public string? Longitude { get; set; }

        [JsonPropertyName("country_name")]
        public string? CountryName { get; set; }

        [JsonPropertyName("state_prov")]
        public string? State { get; set; }

        [JsonPropertyName("city")]
        public string? City { get; set; }

        [JsonPropertyName("locality")]
        public string? Locality { get; set; }

        [JsonPropertyName("elevation")]
        public string? Elevation { get; set; }
    }
}
