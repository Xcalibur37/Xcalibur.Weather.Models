using System.Text.Json.Serialization;

namespace Xcalibur.Weather.Models.Services.OpenStreetMap.Response
{
    /// <summary>
    /// A single result entry from the OpenStreetMap Nominatim search API.
    /// </summary>
    public sealed class OpenStreetMapResultResponse
    {
        /// <summary>
        /// Gets the place identifier.
        /// </summary>
        [JsonPropertyName("place_id")]
        public long PlaceId { get; init; }

        /// <summary>
        /// Gets the latitude as a string (Nominatim returns quoted decimals).
        /// </summary>
        [JsonPropertyName("lat")]
        public string? Lat { get; init; }

        /// <summary>
        /// Gets the longitude as a string (Nominatim returns quoted decimals).
        /// </summary>
        [JsonPropertyName("lon")]
        public string? Lon { get; init; }

        /// <summary>
        /// Gets the human-readable display name.
        /// </summary>
        [JsonPropertyName("display_name")]
        public string? DisplayName { get; init; }

        /// <summary>
        /// Gets the address detail block.
        /// </summary>
        [JsonPropertyName("address")]
        public OpenStreetMapAddressResponse? Address { get; init; }

        /// <summary>
        /// Gets the address type (e.g. "city", "county").
        /// </summary>
        [JsonPropertyName("addresstype")]
        public string? AddressType { get; init; }

        /// <summary>
        /// Gets the importance score.
        /// </summary>
        [JsonPropertyName("importance")]
        public double Importance { get; init; }
    }
}
