using System.Text.Json.Serialization;

namespace Xcalibur.Weather.Models.Services.OpenMeteo.DailyWeather
{
    /// <summary>
    /// Daily Weather Units
    /// </summary>
    public class DailyWeatherUnits
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
        /// Gets or sets the weather code.
        /// </summary>
        /// <value>
        /// The weather code.
        /// </value>
        [JsonPropertyName("weather_code")]
        public string? WeatherCode { get; set; }

        /// <summary>
        /// Gets or sets the temperature maximum.
        /// </summary>
        /// <value>
        /// The temperature maximum.
        /// </value>
        [JsonPropertyName("temperature_2m_max")]
        public string? TemperatureMax { get; set; }

        /// <summary>
        /// Gets or sets the temperature minimum.
        /// </summary>
        /// <value>
        /// The temperature minimum.
        /// </value>
        [JsonPropertyName("temperature_2m_min")]
        public string? TemperatureMin { get; set; }

        /// <summary>
        /// Gets or sets the sunrise.
        /// </summary>
        /// <value>
        /// The sunrise.
        /// </value>
        [JsonPropertyName("sunrise")]
        public string? Sunrise { get; set; }

        /// <summary>
        /// Gets or sets the sunset.
        /// </summary>
        /// <value>
        /// The sunset.
        /// </value>
        [JsonPropertyName("sunset")]
        public string? Sunset { get; set; }

        /// <summary>
        /// Gets or sets the duration of the daylight.
        /// </summary>
        /// <value>
        /// The duration of the daylight.
        /// </value>
        [JsonPropertyName("daylight_duration")]
        public string? DaylightDuration { get; set; }

        /// <summary>
        /// Gets or sets the duration of the sunshine.
        /// </summary>
        /// <value>
        /// The duration of the sunshine.
        /// </value>
        [JsonPropertyName("sunshine_duration")]
        public string? SunshineDuration { get; set; }

        /// <summary>
        /// Gets or sets the rain sum.
        /// </summary>
        /// <value>
        /// The rain sum.
        /// </value>
        [JsonPropertyName("rain_sum")]
        public string? RainSum { get; set; }

        /// <summary>
        /// Gets or sets the showers sum.
        /// </summary>
        /// <value>
        /// The showers sum.
        /// </value>
        [JsonPropertyName("showers_sum")]
        public string? ShowersSum { get; set; }

        /// <summary>
        /// Gets or sets the snowfall sum.
        /// </summary>
        /// <value>
        /// The snowfall sum.
        /// </value>
        [JsonPropertyName("snowfall_sum")]
        public string? SnowfallSum { get; set; }

        /// <summary>
        /// Gets or sets the precipitation sum.
        /// </summary>
        /// <value>
        /// The precipitation sum.
        /// </value>
        [JsonPropertyName("precipitation_sum")]
        public string? PrecipitationSum { get; set; }

        /// <summary>
        /// Gets or sets the precipitation hours.
        /// </summary>
        /// <value>
        /// The precipitation hours.
        /// </value>
        [JsonPropertyName("precipitation_hours")]
        public string? PrecipitationHours { get; set; }

        /// <summary>
        /// Gets or sets the precipitation probability maximum.
        /// </summary>
        /// <value>
        /// The precipitation probability maximum.
        /// </value>
        [JsonPropertyName("precipitation_probability_max")]
        public string? PrecipitationProbabilityMax { get; set; }

        /// <summary>
        /// Gets or sets the wind speed maximum.
        /// </summary>
        /// <value>
        /// The wind speed maximum.
        /// </value>
        [JsonPropertyName("wind_speed_10m_max")]
        public string? WindSpeedMax { get; set; }

        /// <summary>
        /// Gets or sets the wind gusts maximum.
        /// </summary>
        /// <value>
        /// The wind gusts maximum.
        /// </value>
        [JsonPropertyName("wind_gusts_10m_max")]
        public string? WindGustsMax { get; set; }

        /// <summary>
        /// Gets or sets the uv index maximum.
        /// </summary>
        /// <value>
        /// The uv index maximum.
        /// </value>
        [JsonPropertyName("uv_index_max")]
        // ReSharper disable once InconsistentNaming
        public string? UVIndexMax { get; set; }

    }
}
