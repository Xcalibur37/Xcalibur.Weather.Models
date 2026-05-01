using System.Text.Json.Serialization;

namespace Xcalibur.Weather.Models.WeatherProvider.GooglePollen.Forecast
{
    /// <summary>
    /// RGB color representation returned by the Google Pollen API.
    /// </summary>
    public class ColorModel
    {
        /// <summary>
        /// Gets or sets the red component.
        /// </summary>
        [JsonPropertyName("red")]
        public double? Red { get; set; }

        /// <summary>
        /// Gets or sets the green component.
        /// </summary>
        [JsonPropertyName("green")]
        public double? Green { get; set; }

        /// <summary>
        /// Gets or sets the blue component.
        /// </summary>
        [JsonPropertyName("blue")]
        public double? Blue { get; set; }
    }
}
