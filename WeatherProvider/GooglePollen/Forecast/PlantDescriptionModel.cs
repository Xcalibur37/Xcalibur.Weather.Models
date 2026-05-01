using System.Text.Json.Serialization;

namespace Xcalibur.Weather.Models.WeatherProvider.GooglePollen.Forecast
{
    /// <summary>
    /// Detailed plant description returned by the Google Pollen API.
    /// </summary>
    public class PlantDescriptionModel
    {
        /// <summary>
        /// Gets or sets the plant type.
        /// </summary>
        [JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Gets or sets the biological family.
        /// </summary>
        [JsonPropertyName("family")]
        public string? Family { get; set; }

        /// <summary>
        /// Gets or sets the season.
        /// </summary>
        [JsonPropertyName("season")]
        public string? Season { get; set; }

        /// <summary>
        /// Gets or sets the special colors.
        /// </summary>
        [JsonPropertyName("specialColors")]
        public string? SpecialColors { get; set; }

        /// <summary>
        /// Gets or sets the special shapes.
        /// </summary>
        [JsonPropertyName("specialShapes")]
        public string? SpecialShapes { get; set; }

        /// <summary>
        /// Gets or sets cross-reaction information.
        /// </summary>
        [JsonPropertyName("crossReaction")]
        public string? CrossReaction { get; set; }

        /// <summary>
        /// Gets or sets the plant image URL.
        /// </summary>
        [JsonPropertyName("picture")]
        public string? Picture { get; set; }

        /// <summary>
        /// Gets or sets the close-up image URL.
        /// </summary>
        [JsonPropertyName("pictureCloseup")]
        public string? PictureCloseup { get; set; }
    }
}
