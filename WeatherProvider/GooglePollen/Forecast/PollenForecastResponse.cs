using System.Text.Json.Serialization;

namespace Xcalibur.Weather.Models.WeatherProvider.GooglePollen.Forecast
{
    /// <summary>
    /// Top-level response returned by the Google Pollen API forecast lookup endpoint.
    /// </summary>
    public class PollenForecastResponse
    {
        /// <summary>
        /// Gets or sets the region code.
        /// </summary>
        [JsonPropertyName("regionCode")]
        public string? RegionCode { get; set; }

        /// <summary>
        /// Gets or sets the daily forecast information.
        /// </summary>
        [JsonPropertyName("dailyInfo")]
        public List<DailyInfoModel>? DailyInfo { get; set; }
    }
}
