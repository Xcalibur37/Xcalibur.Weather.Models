using System.Text.Json.Serialization;

namespace Xcalibur.Weather.Models.WeatherProvider.GooglePollen.Forecast
{
    /// <summary>
    /// Pollen type information such as grass, tree, or weed.
    /// </summary>
    public class PollenTypeInfoModel
    {
        /// <summary>
        /// Gets or sets the pollen type code.
        /// </summary>
        [JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>
        /// Gets or sets the display name.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the pollen type is currently in season.
        /// </summary>
        [JsonPropertyName("inSeason")]
        public bool? InSeason { get; set; }

        /// <summary>
        /// Gets or sets the index information.
        /// </summary>
        [JsonPropertyName("indexInfo")]
        public IndexInfoModel? IndexInfo { get; set; }

        /// <summary>
        /// Gets or sets the health recommendations.
        /// </summary>
        [JsonPropertyName("healthRecommendations")]
        public List<string>? HealthRecommendations { get; set; }
    }
}
