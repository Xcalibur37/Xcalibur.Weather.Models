using System.Text.Json.Serialization;

namespace Xcalibur.Weather.Models.WeatherProvider.OpenMeteo.CurrentWeather
{
    /// <summary>
    /// Current Weather Units.
    /// </summary>
    /// <seealso cref="System.IEquatable&lt;Xcalibur.Weather.Services.WeatherProvider.OpenMeteo.CurrentWeather.CurrentWeatherUnits&gt;" />
    public record CurrentWeatherUnits
    {
        [JsonPropertyName("time")] 
        public string? Time { get; init; }
        [JsonPropertyName("interval")] 
        public string? Interval { get; init; }
        [JsonPropertyName("temperature_2m")] 
        public string? Temperature { get; init; }
        [JsonPropertyName("relative_humidity_2m")] 
        public string? RelativeHumidity { get; init; }
        [JsonPropertyName("apparent_temperature")]
        public string? ApparentTemperature { get; init; }
        [JsonPropertyName("precipitation")] 
        public string? Precipitation { get; init; }
        [JsonPropertyName("rain")] 
        public string? Rain { get; init; }
        [JsonPropertyName("showers")] 
        public string? Showers { get; init; }
        [JsonPropertyName("snowfall")] 
        public string? Snowfall { get; init; }
        [JsonPropertyName("weather_code")] 
        public string? WeatherCode { get; init; }
        [JsonPropertyName("cloud_cover")] 
        public string? CloudCover { get; init; }
        [JsonPropertyName("pressure_msl")] 
        public string? PressureMsl { get; init; }
        [JsonPropertyName("surface_pressure")] 
        public string? SurfacePressure { get; init; }
        [JsonPropertyName("wind_speed_10m")] 
        public string? WindSpeed { get; init; }
        [JsonPropertyName("wind_direction_10m")]
        public string? WindDirection { get; init; }
        [JsonPropertyName("wind_gusts_10m")] 
        public string? WindGust { get; init; }
    }
}
