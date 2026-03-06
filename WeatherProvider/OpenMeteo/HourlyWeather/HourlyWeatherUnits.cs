using System.Text.Json.Serialization;

namespace Xcalibur.Weather.Models.WeatherProvider.OpenMeteo.HourlyWeather
{
    // Units for each hourly series
    public class HourlyWeatherUnits
    {
        [JsonPropertyName("time")]
        public string? Time { get; set; }

        [JsonPropertyName("temperature_2m")]
        public string? Temperature2m { get; set; }

        [JsonPropertyName("apparent_temperature")]
        public string? ApparentTemperature { get; set; }

        [JsonPropertyName("weather_code")]
        public string? WeatherCode { get; set; }

        [JsonPropertyName("visibility")]
        public string? Visibility { get; set; }

        [JsonPropertyName("cloud_cover")]
        public string? CloudCover { get; set; }

        [JsonPropertyName("surface_pressure")]
        public string? SurfacePressure { get; set; }
    }
}
