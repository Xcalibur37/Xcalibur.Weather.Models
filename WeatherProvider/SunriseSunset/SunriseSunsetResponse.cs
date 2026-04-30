using System.Text.Json.Serialization;

namespace Xcalibur.Weather.Models.WeatherProvider.SunriseSunset
{
    /// <summary>
    /// Top-level response returned by the SunriseSunset.io JSON API.
    /// </summary>
    public class SunriseSunsetResponse
    {
        /// <summary>Gets or sets the result payload.</summary>
        [JsonPropertyName("results")]
        public SunriseSunsetResultModel? Results { get; set; }

        /// <summary>Gets or sets the API status string (e.g. "OK").</summary>
        [JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>Gets or sets the IANA timezone identifier.</summary>
        [JsonPropertyName("tzid")]
        public string? Tzid { get; set; }
    }
}
