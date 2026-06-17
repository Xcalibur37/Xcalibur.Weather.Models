using System.Text.Json.Serialization;

namespace Xcalibur.Weather.Models.Services.Geocodio.Response
{
    /// <summary>
    /// Geocodio Geocode API response.
    /// </summary>
    public sealed class GeocodioResponse
    {
        /// <summary>
        /// Gets the input.
        /// </summary>
        /// <value>
        /// The input.
        /// </value>
        [JsonPropertyName("input")]
        public GeocodioInputResponse? Input { get; init; }

        /// <summary>
        /// Gets the results.
        /// </summary>
        /// <value>
        /// The results.
        /// </value>
        [JsonPropertyName("results")]
        public List<GeocodioResultResponse>? Results { get; init; }
    }
}
