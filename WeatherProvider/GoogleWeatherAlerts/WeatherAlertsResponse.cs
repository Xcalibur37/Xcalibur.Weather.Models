using System.Text.Json.Serialization;

namespace Xcalibur.Weather.Models.WeatherProvider.GoogleWeatherAlerts
{
    /// <summary>
    /// Top-level response returned by the Google Weather Alerts API lookup endpoint.
    /// </summary>
    public class WeatherAlertsResponse
    {
        /// <summary>
        /// Gets or sets the weather alerts.
        /// </summary>
        [JsonPropertyName("weatherAlerts")]
        public List<WeatherAlertModel>? WeatherAlerts { get; set; }

        /// <summary>
        /// Gets or sets the region code.
        /// </summary>
        [JsonPropertyName("regionCode")]
        public string? RegionCode { get; set; }
    }
}
