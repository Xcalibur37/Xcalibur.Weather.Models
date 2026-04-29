using System.Text.Json.Serialization;

namespace Xcalibur.Weather.Models.WeatherProvider.IpGeo.Astronomy
{
    /// <summary>
    /// Response model for sun and moon data.
    /// </summary>
    public class SunMoonDataResponse
    {
        /// <summary>
        /// Gets or sets the location.
        /// </summary>
        /// <value>
        /// The location.
        /// </value>
        [JsonPropertyName("location")]
        public LocationModel? Location { get; set; }

        /// <summary>
        /// Gets or sets the astronomy.
        /// </summary>
        /// <value>
        /// The astronomy.
        /// </value>
        [JsonPropertyName("astronomy")]
        public AstronomyModel? Astronomy { get; set; }
    }
}
