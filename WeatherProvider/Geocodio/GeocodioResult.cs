using System.Text.Json.Serialization;

namespace Xcalibur.Weather.Models.WeatherProvider.Geocodio
{
    /// <summary>
    /// Geocodio Geocode API result.
    /// </summary>
    public sealed class GeocodioResult
    {
        /// <summary>
        /// Gets the address components.
        /// </summary>
        /// <value>
        /// The address components.
        /// </value>
        [JsonPropertyName("address_components")]
        public GeocodioResultAddressComponents? AddressComponents { get; init; }

        /// <summary>
        /// Gets the address lines.
        /// </summary>
        /// <value>
        /// The address lines.
        /// </value>
        [JsonPropertyName("address_lines")]
        public List<string>? AddressLines { get; init; }

        /// <summary>
        /// Gets the formatted address.
        /// </summary>
        /// <value>
        /// The formatted address.
        /// </value>
        [JsonPropertyName("formatted_address")]
        public string? FormattedAddress { get; init; }

        /// <summary>
        /// Gets the location.
        /// </summary>
        /// <value>
        /// The location.
        /// </value>
        [JsonPropertyName("location")]
        public GeocodioLocation? Location { get; init; }

        /// <summary>
        /// Gets the accuracy.
        /// </summary>
        /// <value>
        /// The accuracy.
        /// </value>
        [JsonPropertyName("accuracy")]
        public decimal? Accuracy { get; init; }

        /// <summary>
        /// Gets the type of the accuracy.
        /// </summary>
        /// <value>
        /// The type of the accuracy.
        /// </value>
        [JsonPropertyName("accuracy_type")]
        public string? AccuracyType { get; init; }

        /// <summary>
        /// Gets the source.
        /// </summary>
        /// <value>
        /// The source.
        /// </value>
        [JsonPropertyName("source")]
        public string? Source { get; init; }
    }
}
