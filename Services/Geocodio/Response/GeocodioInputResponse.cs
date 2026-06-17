using System.Text.Json.Serialization;

namespace Xcalibur.Weather.Models.Services.Geocodio.Response
{
    /// <summary>
    /// Geocodio Geocode API input.
    /// </summary>
    public sealed class GeocodioInputResponse
    {
        /// <summary>
        /// Gets the address components.
        /// </summary>
        /// <value>
        /// The address components.
        /// </value>
        [JsonPropertyName("address_components")]
        public GeocodioInputAddressComponentsResponse? AddressComponents { get; init; }

        /// <summary>
        /// Gets the formatted address.
        /// </summary>
        /// <value>
        /// The formatted address.
        /// </value>
        [JsonPropertyName("formatted_address")]
        public string? FormattedAddress { get; init; }
    }
}
