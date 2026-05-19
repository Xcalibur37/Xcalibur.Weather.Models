using System.Text.Json.Serialization;

namespace Xcalibur.Weather.Models.WeatherProvider.GoogleWeatherAlerts
{
    /// <summary>
    /// Represents the localised title of a weather alert.
    /// </summary>
    public class AlertTitleModel
    {
        /// <summary>
        /// Gets or sets the title text.
        /// </summary>
        [JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Gets or sets the language code (e.g. "en").
        /// </summary>
        [JsonPropertyName("languageCode")]
        public string? LanguageCode { get; set; }
    }
}
