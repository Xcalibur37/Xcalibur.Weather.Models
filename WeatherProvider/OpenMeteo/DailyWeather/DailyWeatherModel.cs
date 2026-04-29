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
        /// <summary>
        /// Gets or sets the temperature maximum.
        /// </summary>
        /// <value>
        /// The temperature maximum.
        /// </value>
        [JsonPropertyName("temperature_2m_max")]
        public List<double?>? TemperatureMax { get; set; }

        /// <summary>
        /// Gets or sets the temperature minimum.
        /// </summary>
        /// <value>
        /// The temperature minimum.
        /// </value>
        [JsonPropertyName("temperature_2m_min")]
        public List<double?>? TemperatureMin { get; set; }

        /// <summary>
        /// Gets or sets the sunrise.
        /// </summary>
        /// <value>
        /// The sunrise.
        /// </value>
        [JsonPropertyName("sunrise")]
        public List<string?>? Sunrise { get; set; }

        /// <summary>
        /// Gets or sets the sunset.
        /// </summary>
        /// <value>
        /// The sunset.
        /// </value>
        [JsonPropertyName("sunset")]
        public List<string?>? Sunset { get; set; }

        /// <summary>
        /// Gets or sets the duration of the daylight.
        /// </summary>
        /// <value>
        /// The duration of the daylight.
        /// </value>
        [JsonPropertyName("daylight_duration")]
        public List<double?>? DaylightDuration { get; set; }

        /// <summary>
        /// Gets or sets the duration of the sunshine.
        /// </summary>
        /// <value>
        /// The duration of the sunshine.
        /// </value>
        [JsonPropertyName("sunshine_duration")]
        public List<double?>? SunshineDuration { get; set; }

        /// <summary>
        /// Gets or sets the rain sum.
        /// </summary>
        /// <value>
        /// The rain sum.
        /// </value>
        [JsonPropertyName("rain_sum")]
        public List<double?>? RainSum { get; set; }

        /// <summary>
        /// Gets or sets the showers sum.
        /// </summary>
        /// <value>
        /// The showers sum.
        /// </value>
        [JsonPropertyName("showers_sum")]
        public List<double?>? ShowersSum { get; set; }

        /// <summary>
        /// Gets or sets the snowfall sum.
        /// </summary>
        /// <value>
        /// The snowfall sum.
        /// </value>
        [JsonPropertyName("snowfall_sum")]
        public List<double?>? SnowfallSum { get; set; }

        /// <summary>
        /// Gets or sets the precipitation sum.
        /// </summary>
        /// <value>
        /// The precipitation sum.
        /// </value>
        [JsonPropertyName("precipitation_sum")]
        public List<double?>? PrecipitationSum { get; set; }

        /// <summary>
        /// Gets or sets the precipitation hours.
        /// </summary>
        /// <value>
        /// The precipitation hours.
        /// </value>
        [JsonPropertyName("precipitation_hours")]
        public List<double?>? PrecipitationHours { get; set; }

        /// <summary>
        /// Gets or sets the precipitation probability maximum.
        /// </summary>
        /// <value>
        /// The precipitation probability maximum.
        /// </value>
        [JsonPropertyName("precipitation_probability_max")]
        public List<double?>? PrecipitationProbabilityMax { get; set; }

        /// <summary>
        /// Gets or sets the wind speed maximum.
        /// </summary>
        /// <value>
        /// The wind speed maximum.
        /// </value>
        [JsonPropertyName("wind_speed_10m_max")]
        public List<double?>? WindSpeedMax { get; set; }

        /// <summary>
        /// Gets or sets the wind gusts maximum.
        /// </summary>
        /// <value>
        /// The wind gusts maximum.
        /// </value>
        [JsonPropertyName("wind_gusts_10m_max")]
        public List<double?>? WindGustsMax { get; set; }

        /// <summary>
        /// Gets or sets the uv index maximum.
        /// </summary>
        /// <value>
        /// The uv index maximum.
        /// </value>
        [JsonPropertyName("uv_index_max")]
        // ReSharper disable once InconsistentNaming
        public List<double?>? UVIndexMax { get; set; }
    }
}
