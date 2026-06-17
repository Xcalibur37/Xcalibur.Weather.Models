using System.Text.Json.Serialization;
using Xcalibur.Weather.Models.Services.OpenMeteo.Base;

namespace Xcalibur.Weather.Models.Services.OpenMeteo.CurrentAirQuality
{
    /// <summary>
    /// Air Quality Response.
    /// </summary>
    public class AirQualityResponse : BaseResponse
    {
        /// <summary>
        /// Gets or sets the current units.
        /// </summary>
        /// <value>
        /// The current units.
        /// </value>
        [JsonPropertyName("current_units")]
        public AirQualityUnits? CurrentUnits { get; set; }

        /// <summary>
        /// Gets or sets the current.
        /// </summary>
        /// <value>
        /// The current.
        /// </value>
        [JsonPropertyName("current")]
        public AirQualityModel? Current { get; set; }
    }
}
