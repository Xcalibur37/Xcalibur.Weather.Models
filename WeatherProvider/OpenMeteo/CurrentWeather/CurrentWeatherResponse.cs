using System.Text.Json.Serialization;

namespace Xcalibur.Weather.Models.WeatherProvider.OpenMeteo.CurrentWeather
{
    /// <summary>
    /// DTO for the Open‑Meteo current weather response.
    /// </summary>
    public class CurrentWeatherResponse
    {
        [JsonPropertyName("latitude")]
        public double Latitude { get; set; }

        [JsonPropertyName("longitude")]
        public double Longitude { get; set; }

        [JsonPropertyName("generationtime_ms")]
        public double GenerationTimeMs { get; set; }

        [JsonPropertyName("utc_offset_seconds")]
        public int UtcOffsetSeconds { get; set; }

        [JsonPropertyName("timezone")]
        public string? Timezone { get; set; }

        [JsonPropertyName("timezone_abbreviation")]
        public string? TimezoneAbbreviation { get; set; }

        [JsonPropertyName("elevation")]
        public double Elevation { get; set; }

        [JsonPropertyName("current_units")]
        public CurrentWeatherUnits? CurrentUnits { get; set; }

        [JsonPropertyName("current")]
        public CurrentWeatherModel? Current { get; set; }
    }
}
