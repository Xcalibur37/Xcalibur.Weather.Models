using System.Text.Json.Serialization;

namespace Xcalibur.Weather.Models.WeatherProvider.Geocodio
{
    /// <summary>
    /// Address components in a Geocodio result.
    /// </summary>
    public sealed class GeocodioResultAddressComponents
    {
        /// <summary>
        /// Gets the city.
        /// </summary>
        /// <value>
        /// The city.
        /// </value>
        [JsonPropertyName("city")]
        public string? City { get; init; }

        /// <summary>
        /// Gets the county.
        /// </summary>
        /// <value>
        /// The county.
        /// </value>
        [JsonPropertyName("county")]
        public string? County { get; init; }

        /// <summary>
        /// Gets the state.
        /// </summary>
        /// <value>
        /// The state.
        /// </value>
        [JsonPropertyName("state")]
        public string? State { get; init; }

        /// <summary>
        /// Gets the zip.
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
