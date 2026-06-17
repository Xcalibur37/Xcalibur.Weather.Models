using System.Text.Json.Serialization;

namespace Xcalibur.Weather.Models.Services.GoogleWeatherAlerts.Response
{
    /// <summary>
    /// Alert title information.
    /// </summary>
    public class AlertTitleResponse
    {
        /// <summary>
        /// Gets or sets the text.
        /// </summary>
        [JsonPropertyName("text")]
        public string? Text { get; set; }
    }
}
