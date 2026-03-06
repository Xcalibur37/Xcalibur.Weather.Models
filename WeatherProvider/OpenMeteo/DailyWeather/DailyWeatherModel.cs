using System.Text.Json.Serialization;
using Xcalibur.Weather.Models.WeatherProvider.OpenMeteo.Base;

namespace Xcalibur.Weather.Models.WeatherProvider.OpenMeteo.DailyWeather
{
    /// <summary>
    /// Daily Weather Model
    /// </summary>
    /// <seealso cref="BaseModel" />
    public class DailyWeatherModel : BaseModel
    {
        [JsonPropertyName("temperature_2m_max")]
        public List<double?>? TemperatureMax { get; set; }

        [JsonPropertyName("temperature_2m_min")]
        public List<double?>? TemperatureMin { get; set; }

        [JsonPropertyName("sunrise")]
        public List<string?>? Sunrise { get; set; }

        [JsonPropertyName("sunset")]
        public List<string?>? Sunset { get; set; }

        [JsonPropertyName("daylight_duration")]
        public List<double?>? DaylightDuration { get; set; }

        [JsonPropertyName("sunshine_duration")]
        public List<double?>? SunshineDuration { get; set; }

        [JsonPropertyName("rain_sum")]
        public List<double?>? RainSum { get; set; }

        [JsonPropertyName("showers_sum")]
        public List<double?>? ShowersSum { get; set; }

        [JsonPropertyName("snowfall_sum")]
        public List<double?>? SnowfallSum { get; set; }

        [JsonPropertyName("precipitation_sum")]
        public List<double?>? PrecipitationSum { get; set; }

        [JsonPropertyName("precipitation_hours")]
        public List<double?>? PrecipitationHours { get; set; }

        [JsonPropertyName("precipitation_probability_max")]
        public List<double?>? PrecipitationProbabilityMax { get; set; }

        [JsonPropertyName("wind_speed_10m_max")]
        public List<double?>? WindSpeedMax { get; set; }

        [JsonPropertyName("wind_gusts_10m_max")]
        public List<double?>? WindGustsMax { get; set; }

        [JsonPropertyName("uv_index_max")]
        // ReSharper disable once InconsistentNaming
        public List<double?>? UVIndexMax { get; set; }
    }
}
