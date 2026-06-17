using System.Text.Json.Serialization;

namespace Xcalibur.Weather.Models.Services.Atmospore.Response
{
    /// <summary>
    /// Location object nested within the Atmospore pollen API response metadata.
    /// </summary>
    public class PollenLocationResponse
    {
        /// <summary>
        /// Gets or sets the latitude.
        /// </summary>
        [JsonPropertyName("lat")]
        public double? Lat { get; set; }

        /// <summary>
        /// Gets or sets the longitude.
        /// </summary>
        [JsonPropertyName("lon")]
        public double? Lon { get; set; }
    }
}
