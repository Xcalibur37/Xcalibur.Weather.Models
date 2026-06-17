using System.Text.Json.Serialization;

namespace Xcalibur.Weather.Models.Services.Geocodio
{
    /// <summary>
    /// Geocodio Geocode API input address components.
    /// </summary>
    public sealed class GeocodioInputAddressComponents
    {
        /// <summary>
        /// Gets the zip code.
        /// </summary>
        /// <value>
        /// The zip.
        /// </value>
        [JsonPropertyName("zip")]
        public string? Zip { get; init; }

        /// <summary>
        /// Gets the country.
        /// </summary>
        /// <value>
        /// The country.
        /// </value>
        [JsonPropertyName("country")]
        public string? Country { get; init; }
    }
}
