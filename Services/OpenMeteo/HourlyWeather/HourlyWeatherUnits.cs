using System.Text.Json.Serialization;

namespace Xcalibur.Weather.Models.Services.OpenMeteo.HourlyWeather
{
    /// <summary>
    /// Units for each hourly series
    /// </summary>
    public class HourlyWeatherUnits
    {
        /// <summary>
        /// Gets or sets the time.
        /// </summary>
        /// <value>
        /// The time.
        /// </value>
        [JsonPropertyName("time")]
        public string? Time { get; set; }

        /// <summary>
        /// Gets or sets the temperature2m.
        /// </summary>
        /// <value>
        /// The temperature2m.
        /// </value>
        [JsonPropertyName("temperature_2m")]
        public string? Temperature2m { get; set; }

        /// <summary>
        /// Gets or sets the apparent temperature.
        /// </summary>
        /// <value>
        /// The apparent temperature.
        /// </value>
        [JsonPropertyName("apparent_temperature")]
        public string? ApparentTemperature { get; set; }

        /// <summary>
        /// Gets or sets the weather code.
        /// </summary>
        /// <value>
        /// The weather code.
        /// </value>
        [JsonPropertyName("weather_code")]
        public string? WeatherCode { get; set; }

        /// <summary>
        /// Gets or sets the visibility.
        /// </summary>
        /// <value>
        /// The visibility.
        /// </value>
        [JsonPropertyName("visibility")]
        public string? Visibility { get; set; }

        /// <summary>
        /// Gets or sets the cloud cover.
        /// </summary>
        /// <value>
        /// The cloud cover.
        /// </value>
        [JsonPropertyName("cloud_cover")]
        public string? CloudCover { get; set; }

        /// <summary>
        /// Gets or sets the surface pressure.
        /// </summary>
        /// <value>
        /// The surface pressure.
        /// </value>
        [JsonPropertyName("surface_pressure")]
        public string? SurfacePressure { get; set; }
    }
}
