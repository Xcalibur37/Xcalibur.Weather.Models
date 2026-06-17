using System.Text.Json.Serialization;

namespace Xcalibur.Weather.Models.Services.OpenMeteo.CurrentWeather
{
    /// <summary>
    /// Current Weather Units.
    /// </summary>
    /// <seealso cref="CurrentWeatherUnits" />
    public record CurrentWeatherUnits
    {
        /// <summary>
        /// Gets the time.
        /// </summary>
        /// <value>
        /// The time.
        /// </value>
        [JsonPropertyName("time")] 
        public string? Time { get; init; }
        /// <summary>
        /// Gets the interval.
        /// </summary>
        /// <value>
        /// The interval.
        /// </value>
        [JsonPropertyName("interval")] 
        public string? Interval { get; init; }
        /// <summary>
        /// Gets the temperature.
        /// </summary>
        /// <value>
        /// The temperature.
        /// </value>
        [JsonPropertyName("temperature_2m")] 
        public string? Temperature { get; init; }
        /// <summary>
        /// Gets the relative humidity.
        /// </summary>
        /// <value>
        /// The relative humidity.
        /// </value>
        [JsonPropertyName("relative_humidity_2m")] 
        public string? RelativeHumidity { get; init; }
        /// <summary>
        /// Gets the apparent temperature.
        /// </summary>
        /// <value>
        /// The apparent temperature.
        /// </value>
        [JsonPropertyName("apparent_temperature")]
        public string? ApparentTemperature { get; init; }
        /// <summary>
        /// Gets the precipitation.
        /// </summary>
        /// <value>
        /// The precipitation.
        /// </value>
        [JsonPropertyName("precipitation")] 
        public string? Precipitation { get; init; }
        /// <summary>
        /// Gets the rain.
        /// </summary>
        /// <value>
        /// The rain.
        /// </value>
        [JsonPropertyName("rain")] 
        public string? Rain { get; init; }
        /// <summary>
        /// Gets the showers.
        /// </summary>
        /// <value>
        /// The showers.
        /// </value>
        [JsonPropertyName("showers")] 
        public string? Showers { get; init; }
        /// <summary>
        /// Gets the snowfall.
        /// </summary>
        /// <value>
        /// The snowfall.
        /// </value>
        [JsonPropertyName("snowfall")] 
        public string? Snowfall { get; init; }
        /// <summary>
        /// Gets the weather code.
        /// </summary>
        /// <value>
        /// The weather code.
        /// </value>
        [JsonPropertyName("weather_code")] 
        public string? WeatherCode { get; init; }
        /// <summary>
        /// Gets the cloud cover.
        /// </summary>
        /// <value>
        /// The cloud cover.
        /// </value>
        [JsonPropertyName("cloud_cover")] 
        public string? CloudCover { get; init; }
        /// <summary>
        /// Gets the pressure MSL.
        /// </summary>
        /// <value>
        /// The pressure MSL.
        /// </value>
        [JsonPropertyName("pressure_msl")] 
        public string? PressureMsl { get; init; }
        /// <summary>
        /// Gets the surface pressure.
        /// </summary>
        /// <value>
        /// The surface pressure.
        /// </value>
        [JsonPropertyName("surface_pressure")] 
        public string? SurfacePressure { get; init; }
        /// <summary>
        /// Gets the wind speed.
        /// </summary>
        /// <value>
        /// The wind speed.
        /// </value>
        [JsonPropertyName("wind_speed_10m")] 
        public string? WindSpeed { get; init; }
        /// <summary>
        /// Gets the wind direction.
        /// </summary>
        /// <value>
        /// The wind direction.
        /// </value>
        [JsonPropertyName("wind_direction_10m")]
        public string? WindDirection { get; init; }
        /// <summary>
        /// Gets the wind gust.
        /// </summary>
        /// <value>
        /// The wind gust.
        /// </value>
        [JsonPropertyName("wind_gusts_10m")] 
        public string? WindGust { get; init; }
    }
}
