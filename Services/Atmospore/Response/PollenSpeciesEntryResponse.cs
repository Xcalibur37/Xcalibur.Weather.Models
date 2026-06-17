using System.Text.Json.Serialization;

namespace Xcalibur.Weather.Models.Services.Atmospore.Response
{
    /// <summary>
    /// Pollen data for a single species within a daily forecast entry.
    /// </summary>
    public class PollenSpeciesEntryResponse
    {
        /// <summary>
        /// Gets or sets the pollen concentration value (grains/m³).
        /// </summary>
        [JsonPropertyName("value")]
        public double? Value { get; set; }

        /// <summary>
        /// Gets or sets the risk level (e.g., low, moderate, high, very high).
        /// </summary>
        [JsonPropertyName("risk_level")]
        public string? RiskLevel { get; set; }

        /// <summary>
        /// Gets or sets the human-readable display name of the species.
        /// </summary>
        [JsonPropertyName("display_name")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the pollen category (e.g., tree, grass, weed).
        /// </summary>
        [JsonPropertyName("category")]
        public string? Category { get; set; }
    }
}
