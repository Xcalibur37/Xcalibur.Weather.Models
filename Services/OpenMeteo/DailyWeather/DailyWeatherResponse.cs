using System.Text.Json.Serialization;
using Xcalibur.Weather.Models.Services.OpenMeteo.Base;

namespace Xcalibur.Weather.Models.Services.OpenMeteo.DailyWeather
{
    /// <summary>
    /// Root response for daily forecast
    /// </summary>
    public class DailyWeatherResponse : BaseResponse
    {
        /// <summary>
        /// Gets or sets the daily units.
        /// </summary>
        /// <value>
        /// The daily units.
        /// </value>
        [JsonPropertyName("daily_units")]
        public DailyWeatherUnits? DailyUnits { get; set; }

        /// <summary>
        /// Gets or sets the daily.
        /// </summary>
        /// <value>
        /// The daily.
        /// </value>
        [JsonPropertyName("daily")]
        public DailyWeatherModel? Daily { get; set; }
    }
}
