using System.Text.Json.Serialization;

namespace Xcalibur.Weather.Models.Services.Atmospore.Response
{
    /// <summary>
    /// Top-level response returned by the Atmospore pollen-top API endpoint.
    /// </summary>
    public class PollenResponse
    {
        /// <summary>
        /// Gets or sets the response metadata.
        /// </summary>
        [JsonPropertyName("meta")]
        public PollenMetaResponse? Meta { get; set; }

        /// <summary>
        /// Gets or sets the list of pollen species entries.
        /// </summary>
        [JsonPropertyName("data")]
        public List<PollenEntryResponse>? Data { get; set; }
    }
}
