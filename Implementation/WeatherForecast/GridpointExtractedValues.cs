using System.Text.Json.Serialization;

namespace Xcalibur.Weather.Models.Implementation.WeatherForecast
{
    /// <summary>
    /// Container for pre-extracted values from NWS gridpoint data.
    /// Used to pass detailed gridpoint values without creating a dependency on the Helpers project.
    /// </summary>
    public class GridpointExtractedValues
    {
        #region Properties

        /// <summary>
        /// Gets or sets the temperature in Celsius.
        /// </summary>
        public double? Temperature { get; set; }

        /// <summary>
        /// Gets or sets the apparent temperature in Celsius.
        /// </summary>
        public double? ApparentTemperature { get; set; }

        /// <summary>
        /// Gets or sets the relative humidity percentage.
        /// </summary>
        public double? RelativeHumidity { get; set; }

        /// <summary>
        /// Gets or sets the wind speed in km/h (will be converted to mph).
        /// </summary>
        public double? WindSpeed { get; set; }

        /// <summary>
        /// Gets or sets the wind direction in degrees.
        /// </summary>
        public double? WindDirection { get; set; }

        /// <summary>
        /// Gets or sets the wind gust speed in km/h (will be converted to mph).
        /// </summary>
        public double? WindGust { get; set; }

        /// <summary>
        /// Gets or sets the precipitation probability percentage.
        /// </summary>
        public double? Precipitation { get; set; }

        /// <summary>
        /// Gets or sets the dewpoint temperature in Celsius.
        /// </summary>
        public double? Dewpoint { get; set; }

        /// <summary>
        /// Gets or sets the sky cover percentage.
        /// </summary>
        public double? SkyCover { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="GridpointExtractedValues"/> class.
        /// </summary>
        [JsonConstructor]
        public GridpointExtractedValues()
        {
            
        }
        
        #endregion
    }
}
