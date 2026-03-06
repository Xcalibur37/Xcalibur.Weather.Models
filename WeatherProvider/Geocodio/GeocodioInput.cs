using System.Text.Json.Serialization;

namespace Xcalibur.Weather.Models.WeatherProvider.Geocodio
{
    /// <summary>
    /// Geocodio Geocode API input.
    /// </summary>
    public sealed class GeocodioInput
    {
        /// <summary>
        /// Gets the address components.
        /// </summary>
        /// <value>
        /// The address components.
        /// </value>
        [JsonPropertyName("address_components")]
        public GeocodioInputAddressComponents? AddressComponents { get; init; }

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
