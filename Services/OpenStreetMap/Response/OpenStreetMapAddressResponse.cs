using System.Text.Json.Serialization;

namespace Xcalibur.Weather.Models.Services.OpenStreetMap.Response
{
    /// <summary>
    /// Address detail block returned by the OpenStreetMap Nominatim addressdetails=1 flag.
    /// </summary>
    public sealed class OpenStreetMapAddressResponse
    {
        /// <summary>
        /// Gets the city (or town/village when city is absent).
        /// </summary>
        [JsonPropertyName("city")]
        public string? City { get; init; }

        /// <summary>
        /// Gets the town.
        /// </summary>
        [JsonPropertyName("town")]
        public string? Town { get; init; }

        /// <summary>
        /// Gets the village.
        /// </summary>
        [JsonPropertyName("village")]
        public string? Village { get; init; }

        /// <summary>
        /// Gets the county.
        /// </summary>
        [JsonPropertyName("county")]
        public string? County { get; init; }

        /// <summary>
        /// Gets the state.
        /// </summary>
        [JsonPropertyName("state")]
        public string? State { get; init; }

        /// <summary>
        /// Gets the postcode (zip).
        /// </summary>
        [JsonPropertyName("postcode")]
        public string? Postcode { get; init; }

        /// <summary>
        /// Gets the country.
        /// </summary>
        [JsonPropertyName("country")]
        public string? Country { get; init; }

        /// <summary>
        /// Gets the ISO 3166-1 alpha-2 country code (e.g. "us").
        /// </summary>
        [JsonPropertyName("country_code")]
        public string? CountryCode { get; init; }
    }
}
