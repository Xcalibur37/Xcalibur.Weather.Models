using System.Text.Json.Serialization;

namespace Xcalibur.Weather.Models.Services.WeatherAlert.Meteoalarm
{
    /// <summary>
    /// Represents a single Meteoalarm alert from the Meteoalarm API.
    /// </summary>
    public class MeteoalarmAlertResponse
    {
        /// <summary>
        /// Gets or sets the alert identifier.
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Gets or sets the alert type.
        /// </summary>
        [JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Gets or sets the awareness level (1=Green, 2=Yellow, 3=Orange, 4=Red).
        /// </summary>
        [JsonPropertyName("awareness_level")]
        public int? AwarenessLevel { get; set; }

        /// <summary>
        /// Gets or sets the awareness type code.
        /// </summary>
        [JsonPropertyName("awareness_type")]
        public int? AwarenessType { get; set; }

        /// <summary>
        /// Gets or sets the event name/title.
        /// </summary>
        [JsonPropertyName("event")]
        public string? Event { get; set; }

        /// <summary>
        /// Gets or sets the headline.
        /// </summary>
        [JsonPropertyName("headline")]
        public string? Headline { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Gets or sets the instruction.
        /// </summary>
        [JsonPropertyName("instruction")]
        public string? Instruction { get; set; }

        /// <summary>
        /// Gets or sets the onset time (ISO 8601).
        /// </summary>
        [JsonPropertyName("onset")]
        public string? Onset { get; set; }

        /// <summary>
        /// Gets or sets the expiration time (ISO 8601).
        /// </summary>
        [JsonPropertyName("expires")]
        public string? Expires { get; set; }

        /// <summary>
        /// Gets or sets the effective time (ISO 8601).
        /// </summary>
        [JsonPropertyName("effective")]
        public string? Effective { get; set; }

        /// <summary>
        /// Gets or sets the severity.
        /// </summary>
        [JsonPropertyName("severity")]
        public string? Severity { get; set; }

        /// <summary>
        /// Gets or sets the certainty.
        /// </summary>
        [JsonPropertyName("certainty")]
        public string? Certainty { get; set; }

        /// <summary>
        /// Gets or sets the urgency.
        /// </summary>
        [JsonPropertyName("urgency")]
        public string? Urgency { get; set; }

        /// <summary>
        /// Gets or sets the sender name.
        /// </summary>
        [JsonPropertyName("sender_name")]
        public string? SenderName { get; set; }

        /// <summary>
        /// Gets or sets the affected areas.
        /// </summary>
        [JsonPropertyName("area")]
        public string? Area { get; set; }
    }
}
