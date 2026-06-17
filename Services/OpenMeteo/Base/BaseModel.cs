using System.Text.Json.Serialization;

namespace Xcalibur.Weather.Models.Services.OpenMeteo.Base
{
    /// <summary>
    /// Base model for OpenMeteo API responses.
    /// </summary>
    public abstract class BaseModel
    {
        // Time strings (ISO-like, no TZ in this API)
        /// <summary>
        /// Gets or sets the time.
        /// </summary>
        /// <value>
        /// The time.
        /// </value>
        [JsonPropertyName("time")]
        public string?[] Time { get; set; } = [];

        /// <summary>
        /// Gets or sets the weather codes.
        /// </summary>
        /// <value>
        /// The weather codes.
        /// </value>
        [JsonPropertyName("weather_code")]
        public int?[]? WeatherCodes
        {
            get;
            set
            {
                field = value;
                if (value == null) return;
                WeatherCodeValues = new string[value.Length];
                for (var i = 0; i < value.Length; i++)
                {
                    WeatherCodeValues[i] = value[i].GetWeatherCodeDescription();
                }
            }
        }

        /// <summary>
        /// Gets or sets the weather code values.
        /// </summary>
        /// <value>
        /// The weather code values.
        /// </value>
        public string[]? WeatherCodeValues { get; set; }
    }
}
