using System.Text.Json.Serialization;

namespace Xcalibur.Weather.Models.WeatherProvider.OpenMeteo.CurrentWeather
{
    /// <summary>
    /// DTO for the Open‑Meteo "current" object.
    /// Matches the JSON you posted and is safe to use with System.Text.Json.
    /// </summary>
    public class CurrentWeatherModel
    {
        [JsonPropertyName("time")]
        public string? Time { get; set; }

        [JsonPropertyName("interval")]
        public int Interval { get; set; }

        [JsonPropertyName("temperature_2m")]
        public double? Temperature { get; set; }

        [JsonPropertyName("relative_humidity_2m")]
        public double? RelativeHumidity { get; set; }

        [JsonPropertyName("apparent_temperature")]
        public double? ApparentTemperature { get; set; }

        [JsonPropertyName("precipitation")]
        public double? Precipitation { get; set; }

        [JsonPropertyName("rain")]
        public double? Rain { get; set; }

        [JsonPropertyName("showers")]
        public double? Showers { get; set; }

        [JsonPropertyName("snowfall")]
        public double? Snowfall { get; set; }

        [JsonPropertyName("weather_code")]
        public int? WeatherCode
        {
            get;
            set
            {
                field = value;
                if (value == null) return;
                WeatherCodeValue = WeatherCode.GetWeatherCodeDescription();
            }
        }

        public string? WeatherCodeValue { get; set; }

        [JsonPropertyName("cloud_cover")]
        public double? CloudCover { get; set; }

        [JsonPropertyName("pressure_msl")]
        public double? PressureMsl { get; set; }

        [JsonPropertyName("surface_pressure")]
        public double? SurfacePressure { get; set; }

        [JsonPropertyName("wind_speed_10m")]
        public double? WindSpeed { get; set; }

        [JsonPropertyName("wind_direction_10m")]
        public int? WindDirection { get; set; }

        [JsonPropertyName("wind_gusts_10m")]
        public double? WindGust { get; set; }

        [JsonPropertyName("is_day")]
        public bool? IsDay { get; set; }
    }
}
