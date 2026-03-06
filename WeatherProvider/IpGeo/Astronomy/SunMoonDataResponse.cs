using System.Text.Json.Serialization;

namespace Xcalibur.Weather.Models.WeatherProvider.IpGeo.Astronomy
{
    /// <summary>
    /// Response model for sun and moon data.
    /// </summary>
    public class SunMoonDataResponse
    {
        [JsonPropertyName("location")]
        public LocationModel? Location { get; set; }

        [JsonPropertyName("astronomy")]
        public AstronomyModel? Astronomy { get; set; }
    }
}
