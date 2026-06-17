using System.Text.Json.Serialization;

namespace Xcalibur.Weather.Models.Services.GoogleWeatherAlerts.Response
{
    /// <summary>
    /// Top-level response from Google Weather Alerts API.
    /// </summary>
    public class WeatherAlertsResponse
    {
        /// <summary>
        /// Gets or sets the weather alerts.
        /// </summary>
        [JsonPropertyName("weatherAlerts")]
        public List<WeatherAlertResponse>? WeatherAlerts { get; set; }

        /// <summary>
        /// Gets or sets the region code.
        /// </summary>
        [JsonPropertyName("regionCode")]
        public string? RegionCode { get; set; }
    }
}
