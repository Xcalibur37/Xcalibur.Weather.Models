using System.Text.Json.Serialization;

namespace Xcalibur.Weather.Models.WeatherProvider.GoogleWeatherAlerts
{
    /// <summary>
    /// Represents the authoritative data source for a weather alert.
    /// </summary>
    public class AlertDataSourceModel
    {
        /// <summary>
        /// Gets or sets the publisher (e.g. "NOAA").
        /// </summary>
        [JsonPropertyName("publisher")]
        public string? Publisher { get; set; }

        /// <summary>
        /// Gets or sets the human-readable name of the issuing authority.
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Gets or sets the URI of the issuing authority.
        /// </summary>
        [JsonPropertyName("authorityUri")]
        public string? AuthorityUri { get; set; }
    }
}
