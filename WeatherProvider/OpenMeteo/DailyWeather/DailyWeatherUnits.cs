using System.Text.Json.Serialization;

namespace Xcalibur.Weather.Models.WeatherProvider.OpenMeteo.DailyWeather
{
    /// <summary>
    /// Daily Weather Units
    /// </summary>
    public class DailyWeatherUnits
    {
        [JsonPropertyName("time")]
        public string? Time { get; set; }

        [JsonPropertyName("weather_code")]
        public string? WeatherCode { get; set; }

        [JsonPropertyName("temperature_2m_max")]
        public string? TemperatureMax { get; set; }

        [JsonPropertyName("temperature_2m_min")]
        public string? TemperatureMin { get; set; }

        [JsonPropertyName("sunrise")]
        public string? Sunrise { get; set; }

        [JsonPropertyName("sunset")]
        public string? Sunset { get; set; }

        [JsonPropertyName("daylight_duration")]
        public string? DaylightDuration { get; set; }

        [JsonPropertyName("sunshine_duration")]
        public string? SunshineDuration { get; set; }

        [JsonPropertyName("rain_sum")]
        public string? RainSum { get; set; }

        [JsonPropertyName("showers_sum")]
        public string? ShowersSum { get; set; }

        [JsonPropertyName("snowfall_sum")]
        public string? SnowfallSum { get; set; }

        [JsonPropertyName("precipitation_sum")]
        public string? PrecipitationSum { get; set; }

        [JsonPropertyName("precipitation_hours")]
        public string? PrecipitationHours { get; set; }

        [JsonPropertyName("precipitation_probability_max")]
        public string? PrecipitationProbabilityMax { get; set; }

        [JsonPropertyName("wind_speed_10m_max")]
        public string? WindSpeedMax { get; set; }

        [JsonPropertyName("wind_gusts_10m_max")]
        public string? WindGustsMax { get; set; }

        [JsonPropertyName("uv_index_max")]
        // ReSharper disable once InconsistentNaming
        public string? UVIndexMax { get; set; }

    }
}
