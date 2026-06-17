using System.Text.Json.Serialization;
using Xcalibur.Weather.Models.Services.OpenMeteo.Base;

namespace Xcalibur.Weather.Models.Services.OpenMeteo.CurrentWeather
{
    /// <summary>
    /// DTO for the Open‑Meteo current weather response.
    /// </summary>
    public class CurrentWeatherResponse : BaseResponse
    {
        /// <summary>
        /// Gets or sets the current units.
        /// </summary>
        /// <value>
        /// The current units.
        /// </value>
        [JsonPropertyName("current_units")]
        public CurrentWeatherUnits? CurrentUnits { get; set; }

        /// <summary>
        /// Gets or sets the current.
        /// </summary>
        /// <value>
        /// The current.
        /// </value>
        [JsonPropertyName("current")]
        public CurrentWeatherModel? Current { get; set; }
    }
}
