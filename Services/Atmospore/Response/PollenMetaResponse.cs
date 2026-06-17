using System.Text.Json.Serialization;

namespace Xcalibur.Weather.Models.Services.Atmospore.Response
{
    /// <summary>
    /// Metadata returned by the Atmospore /v1/pollen API response.
    /// </summary>
    public class PollenMetaResponse
    {
        /// <summary>
        /// Gets or sets the location coordinates.
        /// </summary>
        [JsonPropertyName("location")]
        public PollenLocationResponse? Location { get; set; }

        /// <summary>
        /// Gets or sets the units for pollen count values (e.g., "grains/m³").
        /// </summary>
        [JsonPropertyName("units")]
        public string? Units { get; set; }

        /// <summary>
        /// Gets or sets the UTC timestamp at which the forecast was generated.
        /// </summary>
        [JsonPropertyName("generated_at")]
        public string? GeneratedAt { get; set; }
    }
}
