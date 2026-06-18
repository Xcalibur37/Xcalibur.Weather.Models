using System.Text.Json.Serialization;
using Xcalibur.Extensions.MVVM.V2.Models;

namespace Xcalibur.Weather.Models.Implementation.Base
{
    /// <summary>
    /// Base class for forecast point.
    /// </summary>
    /// <seealso cref="ModelBase" />
    public abstract class BaseForecastPoint : ModelBase
    {
        #region Properties

        /// <summary>
        /// Gets or sets the date time.
        /// </summary>
        /// <value>
        /// The date time.
        /// </value>
        public string? DateValue { get; set; }

        /// <summary>
        /// Gets or sets the weather code.
        /// </summary>
        /// <value>
        /// The weather code.
        /// </value>
        public int? WeatherCode { get; set; }

        /// <summary>
        /// Gets or sets the weather code value.
        /// </summary>
        /// <value>
        /// The weather code value.
        /// </value>
        public string? WeatherCodeValue { get; set; } = "";

        /// <summary>
        /// Gets or sets the is day time.
        /// </summary>
        /// <value>
        /// The is day time.
        /// </value>
        public bool IsDayTime { get; set; } = true;

        /// <summary>
        /// Gets or sets the is current date.
        /// </summary>
        /// <value>
        /// The is current date.
        /// </value>
        public bool IsCurrent { get; set; } = false;

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseForecastPoint"/> class.
        /// </summary>
        [JsonConstructor]
        protected BaseForecastPoint()
        {
            
        }

        #endregion
    }
}
