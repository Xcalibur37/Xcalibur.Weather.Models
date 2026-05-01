using System.Text.Json.Serialization;

namespace Xcalibur.Weather.Models.WeatherProvider.GooglePollen.Forecast
{
    /// <summary>
    /// Index information describing pollen severity.
    /// </summary>
    public class IndexInfoModel
    {
        /// <summary>
        /// Gets or sets the index code.
        /// </summary>
        [JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>
        /// Gets or sets the display name.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the numeric index value.
        /// </summary>
        [JsonPropertyName("value")]
        public int? Value { get; set; }

        /// <summary>
        /// Gets or sets the category.
        /// </summary>
        [JsonPropertyName("category")]
        public string? Category { get; set; }

        /// <summary>
        /// Gets or sets the index description.
        /// </summary>
        [JsonPropertyName("indexDescription")]
        public string? IndexDescription { get; set; }

        /// <summary>
        /// Gets or sets the color.
        /// </summary>
        [JsonPropertyName("color")]
        public ColorModel? Color { get; set; }
    }
}
