using System.Text.Json.Serialization;

namespace Xcalibur.Weather.Models.Services.Geocodio.Response
{
    /// <summary>
    /// Location data from Geocodio Geocode API.
    /// </summary>
    public sealed class GeocodioLocationResponse
    {
        /// <summary>
        /// Gets the latitude.
        /// </summary>
        /// <value>
        /// The latitude.
        /// </value>
        [JsonPropertyName("lat")]
        public decimal Latitude { get; init; }

        /// <summary>
        /// Gets the longitude.
        /// </summary>
        /// <value>
        /// The longitude.
        /// </value>
        [JsonPropertyName("lng")]
        public decimal Longitude { get; init; }
    }
}
