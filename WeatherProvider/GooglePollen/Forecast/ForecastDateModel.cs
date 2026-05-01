using System.Text.Json.Serialization;

namespace Xcalibur.Weather.Models.WeatherProvider.GooglePollen.Forecast
{
    /// <summary>
    /// Date value returned by the Google Pollen API.
    /// </summary>
    public class ForecastDateModel
    {
        /// <summary>
        /// Gets or sets the year.
        /// </summary>
        [JsonPropertyName("year")]
        public int? Year { get; set; }

        /// <summary>
        /// Gets or sets the month.
        /// </summary>
        [JsonPropertyName("month")]
        public int? Month { get; set; }

        /// <summary>
        /// Gets or sets the day.
        /// </summary>
        [JsonPropertyName("day")]
        public int? Day { get; set; }
    }
}
