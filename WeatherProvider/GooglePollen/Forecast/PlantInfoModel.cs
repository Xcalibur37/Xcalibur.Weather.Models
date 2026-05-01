using System.Text.Json.Serialization;

namespace Xcalibur.Weather.Models.WeatherProvider.GooglePollen.Forecast
{
    /// <summary>
    /// Plant-specific pollen information.
    /// </summary>
    public class PlantInfoModel
    {
        /// <summary>
        /// Gets or sets the plant code.
        /// </summary>
        [JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>
        /// Gets or sets the display name.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the plant is currently in season.
        /// </summary>
        [JsonPropertyName("inSeason")]
        public bool? InSeason { get; set; }

        /// <summary>
        /// Gets or sets the index information.
        /// </summary>
        [JsonPropertyName("indexInfo")]
        public IndexInfoModel? IndexInfo { get; set; }

        /// <summary>
        /// Gets or sets the plant description.
        /// </summary>
        [JsonPropertyName("plantDescription")]
        public PlantDescriptionModel? PlantDescription { get; set; }
    }
}
