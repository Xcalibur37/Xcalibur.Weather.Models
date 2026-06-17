using System.Text.Json.Serialization;

namespace Xcalibur.Weather.Models.Services.WeatherAlert.Gdacs
{
    /// <summary>
    /// Represents a single GDACS disaster/weather event.
    /// </summary>
    public class GdacsEventResponse
    {
        /// <summary>
        /// Gets or sets the event identifier.
        /// </summary>
        [JsonPropertyName("eventid")]
        public string? EventId { get; set; }

        /// <summary>
        /// Gets or sets the event name/title.
        /// </summary>
        [JsonPropertyName("eventname")]
        public string? EventName { get; set; }

        /// <summary>
        /// Gets or sets the event type (TC=Tropical Cyclone, EQ=Earthquake, FL=Flood, etc.).
        /// </summary>
        [JsonPropertyName("eventtype")]
        public string? EventType { get; set; }

        /// <summary>
        /// Gets or sets the alert level (Green, Orange, Red).
        /// </summary>
        [JsonPropertyName("alertlevel")]
        public string? AlertLevel { get; set; }

        /// <summary>
        /// Gets or sets the alert score.
        /// </summary>
        [JsonPropertyName("alertscore")]
        public double? AlertScore { get; set; }

        /// <summary>
        /// Gets or sets the severity description.
        /// </summary>
        [JsonPropertyName("severity")]
        public string? Severity { get; set; }

        /// <summary>
        /// Gets or sets the country/countries affected.
        /// </summary>
        [JsonPropertyName("country")]
        public string? Country { get; set; }

        /// <summary>
        /// Gets or sets the ISO3 country codes.
        /// </summary>
        [JsonPropertyName("iso3")]
        public string? Iso3 { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Gets or sets the event date/time (ISO 8601).
        /// </summary>
        [JsonPropertyName("fromdate")]
        public string? FromDate { get; set; }

        /// <summary>
        /// Gets or sets the to date/time (ISO 8601).
        /// </summary>
        [JsonPropertyName("todate")]
        public string? ToDate { get; set; }

        /// <summary>
        /// Gets or sets the latitude of the event epicenter.
        /// </summary>
        [JsonPropertyName("latitude")]
        public double? Latitude { get; set; }

        /// <summary>
        /// Gets or sets the longitude of the event epicenter.
        /// </summary>
        [JsonPropertyName("longitude")]
        public double? Longitude { get; set; }

        /// <summary>
        /// Gets or sets the affected population estimate.
        /// </summary>
        [JsonPropertyName("population")]
        public long? Population { get; set; }

        /// <summary>
        /// Gets or sets the vulnerability score.
        /// </summary>
        [JsonPropertyName("vulnerability")]
        public double? Vulnerability { get; set; }

        /// <summary>
        /// Gets or sets the episode ID.
        /// </summary>
        [JsonPropertyName("episodeid")]
        public string? EpisodeId { get; set; }

        /// <summary>
        /// Gets or sets the event icon URL.
        /// </summary>
        [JsonPropertyName("icon")]
        public string? Icon { get; set; }

        /// <summary>
        /// Gets or sets the event URL.
        /// </summary>
        [JsonPropertyName("url")]
        public string? Url { get; set; }
    }
}
