using System.Text.Json.Serialization;
using Xcalibur.Weather.Models.Services.WeatherAlert.Base;

namespace Xcalibur.Weather.Models.Services.WeatherAlert.Bom
{
    /// <summary>
    /// Represents the root response from Australian Bureau of Meteorology warnings API.
    /// </summary>
    public class BomAlertsResponse : BaseAlertsResponse
    {
        /// <summary>
        /// Gets or sets the warning metadata.
        /// </summary>
        [JsonPropertyName("metadata")]
        public BomMetadataResponse? Metadata { get; set; }

        /// <summary>
        /// Gets or sets the list of warnings.
        /// </summary>
        [JsonPropertyName("warnings")]
        public List<BomWarningResponse> Warnings { get; set; } = [];
    }
}
