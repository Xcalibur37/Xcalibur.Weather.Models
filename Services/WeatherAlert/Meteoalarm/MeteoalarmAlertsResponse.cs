using System.Text.Json.Serialization;
using Xcalibur.Weather.Models.Services.WeatherAlert.Base;

namespace Xcalibur.Weather.Models.Services.WeatherAlert.Meteoalarm
{
    /// <summary>
    /// Top-level response from the Meteoalarm API.
    /// </summary>
    public class MeteoalarmAlertsResponse : BaseAlertsResponse
    {
        /// <summary>
        /// Gets or sets the list of weather alerts.
        /// </summary>
        [JsonPropertyName("alerts")]
        public List<MeteoalarmAlertResponse>? Alerts { get; set; }

        /// <summary>
        /// Gets or sets the latitude.
        /// </summary>
        [JsonPropertyName("latitude")]
        public double? Latitude { get; set; }

        /// <summary>
        /// Gets or sets the longitude.
        /// </summary>
        [JsonPropertyName("longitude")]
        public double? Longitude { get; set; }

        /// <summary>
        /// Gets or sets the country code.
        /// </summary>
        [JsonPropertyName("country")]
        public string? Country { get; set; }
    }
}
