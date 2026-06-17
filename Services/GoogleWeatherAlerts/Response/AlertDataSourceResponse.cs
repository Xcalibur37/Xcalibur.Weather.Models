using System.Text.Json.Serialization;

namespace Xcalibur.Weather.Models.Services.GoogleWeatherAlerts.Response
{
    /// <summary>
    /// Data source information for weather alerts.
    /// </summary>
    public class AlertDataSourceResponse
    {
        /// <summary>
        /// Gets or sets the publisher.
        /// </summary>
        [JsonPropertyName("publisher")]
        public string? Publisher { get; set; }
    }
}
