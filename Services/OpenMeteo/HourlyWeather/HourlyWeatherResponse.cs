using System.Text.Json.Serialization;
using Xcalibur.Weather.Models.Services.OpenMeteo.Base;

namespace Xcalibur.Weather.Models.Services.OpenMeteo.HourlyWeather
{
    /// <summary>
    /// Root response for hourly forecast
    /// </summary>
    public class HourlyWeatherResponse : BaseResponse
    {
        /// <summary>
        /// Gets or sets the hourly units.
        /// </summary>
        /// <value>
        /// The hourly units.
        /// </value>
        [JsonPropertyName("hourly_units")]
        public HourlyWeatherUnits? HourlyUnits { get; set; }

        /// <summary>
        /// Gets or sets the hourly.
        /// </summary>
        /// <value>
        /// The hourly.
        /// </value>
        [JsonPropertyName("hourly")]
        public HourlyWeatherModel? Hourly { get; set; }
    }
}
