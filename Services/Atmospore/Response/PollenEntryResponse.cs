using System.Text.Json.Serialization;

namespace Xcalibur.Weather.Models.Services.Atmospore.Response
{
    /// <summary>
    /// Represents a single daily entry in the Atmospore /v1/pollen API response.
    /// </summary>
    public class PollenEntryResponse
    {
        /// <summary>
        /// Gets or sets the forecast date (yyyy-MM-dd).
        /// </summary>
        [JsonPropertyName("date")]
        public string? Date { get; set; }

        /// <summary>
        /// Gets or sets the overall risk level for the day (e.g., low, moderate, high, very high).
        /// </summary>
        [JsonPropertyName("overall_risk")]
        public string? OverallRisk { get; set; }

        /// <summary>
        /// Gets or sets the species pollen data, keyed by species code.
        /// </summary>
        [JsonPropertyName("species")]
        public Dictionary<string, PollenSpeciesEntryResponse>? Species { get; set; }
    }
}
