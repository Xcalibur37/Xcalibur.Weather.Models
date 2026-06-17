using System.Text.Json.Serialization;

namespace Xcalibur.Weather.Models.Services.WeatherAlert.Nws
{
    /// <summary>
    /// Top-level response from the National Weather Service alerts API.
    /// </summary>
    public class NwsAlertsResponse
    {
        /// <summary>
        /// Gets or sets the context.
        /// </summary>
        [JsonPropertyName("@context")]
        public object? Context { get; set; }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        [JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Gets or sets the features (alerts).
        /// </summary>
        [JsonPropertyName("features")]
        public List<NwsAlertResponse>? Features { get; set; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        [JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Gets or sets the updated timestamp.
        /// </summary>
        [JsonPropertyName("updated")]
        public string? Updated { get; set; }
    }
}
