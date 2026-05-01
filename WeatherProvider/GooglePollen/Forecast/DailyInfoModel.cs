using System.Text.Json.Serialization;

namespace Xcalibur.Weather.Models.WeatherProvider.GooglePollen.Forecast
{
    /// <summary>
    /// Daily pollen forecast information for a single date.
    /// </summary>
    public class DailyInfoModel
    {
        /// <summary>
        /// Gets or sets the forecast date.
        /// </summary>
        [JsonPropertyName("date")]
        public ForecastDateModel? Date { get; set; }

        /// <summary>
        /// Gets or sets the pollen type information.
        /// </summary>
        [JsonPropertyName("pollenTypeInfo")]
        public List<PollenTypeInfoModel>? PollenTypeInfo { get; set; }

        /// <summary>
        /// Gets or sets the plant information.
        /// </summary>
        [JsonPropertyName("plantInfo")]
        public List<PlantInfoModel>? PlantInfo { get; set; }
    }
}
