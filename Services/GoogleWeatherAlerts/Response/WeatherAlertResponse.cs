using System.Text.Json.Serialization;

namespace Xcalibur.Weather.Models.Services.GoogleWeatherAlerts.Response
{
    /// <summary>
    /// Represents a single weather alert from Google Weather Alerts API.
    /// </summary>
    public class WeatherAlertResponse
    {
        /// <summary>
        /// Gets or sets the alert identifier.
        /// </summary>
        [JsonPropertyName("alertId")]
        public string? AlertId { get; set; }

        /// <summary>
        /// Gets or sets the alert title.
        /// </summary>
        [JsonPropertyName("alertTitle")]
        public AlertTitleResponse? AlertTitle { get; set; }

        /// <summary>
        /// Gets or sets the type of the event.
        /// </summary>
        [JsonPropertyName("eventType")]
        public string? EventType { get; set; }

        /// <summary>
        /// Gets or sets the name of the area.
        /// </summary>
        [JsonPropertyName("areaName")]
        public string? AreaName { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; set; }

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
        /// Gets or sets the instruction.
        /// </summary>
        [JsonPropertyName("instruction")]
        public List<string>? Instruction { get; set; }

        /// <summary>
        /// Gets or sets the start time.
        /// </summary>
        [JsonPropertyName("startTime")]
        public string? StartTime { get; set; }

        /// <summary>
        /// Gets or sets the expiration time.
        /// </summary>
        [JsonPropertyName("expirationTime")]
        public string? ExpirationTime { get; set; }

        /// <summary>
        /// Gets or sets the data source.
        /// </summary>
        [JsonPropertyName("dataSource")]
        public AlertDataSourceResponse? DataSource { get; set; }

        /// <summary>
        /// Gets or sets the polygon.
        /// </summary>
        [JsonPropertyName("polygon")]
        public string? Polygon { get; set; }
    }
}
