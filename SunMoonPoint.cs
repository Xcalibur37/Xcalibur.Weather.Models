using Xcalibur.Weather.Models.WeatherProvider.IpGeo.Astronomy;

namespace Xcalibur.Weather.Models
{
    /// <summary>
    /// Sun Moon Point.
    /// </summary>
    public class SunMoonPoint
    {
        #region Properties

        /// <summary>
        /// Gets or sets the sunrise.
        /// </summary>
        /// <value>
        /// The sunrise.
        /// </value>
        public string? Sunrise { get; set; }

        /// <summary>
        /// Gets or sets the sunset.
        /// </summary>
        /// <value>
        /// The sunset.
        /// </value>
        public string? Sunset { get; set; }

        /// <summary>
        /// Gets or sets the length of the day.
        /// </summary>
        /// <value>
        /// The length of the day.
        /// </value>
        public string? DayLength { get; set; }

        /// <summary>
        /// Gets or sets the moonrise.
        /// </summary>
        /// <value>
        /// The moonrise.
        /// </value>
        public string? Moonrise { get; set; }

        /// <summary>
        /// Gets or sets the moonset.
        /// </summary>
        /// <value>
        /// The moonset.
        /// </value>
        public string? Moonset { get; set; }

        /// <summary>
        /// Gets or sets the moon phase.
        /// </summary>
        /// <value>
        /// The moon phase.
        /// </value>
        public string? MoonPhase { get; set; }

        /// <summary>
        /// Gets or sets the moon illumination percentage.
        /// </summary>
        /// <value>
        /// The moon illumination percentage.
        /// </value>
        public string? MoonIlluminationPercentage { get; set; }

        /// <summary>
        /// Gets or sets the moon angle.
        /// </summary>
        /// <value>
        /// The moon angle.
        /// </value>
        public double? MoonAngle { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="SunMoonPoint"/> class.
        /// </summary>
        /// <param name="data">The data.</param>
        public SunMoonPoint(AstronomyModel? data = null)
        {
            if (data is null) return;
            Map(data);
        }

        #endregion

        #region Methods

        /// <summary>
        /// Maps the specified data.
        /// </summary>
        /// <param name="data">The data.</param>
        private void Map(AstronomyModel? data)
        {
            if (data is null) return;
            
            // Sun
            Sunrise = data.Sunrise;
            Sunset = data.Sunset;
            DayLength = data.DayLength;
            
            // Moon
            Moonrise = data.Moonrise;
            Moonset = data.Moonset;
            MoonPhase = data.MoonPhase;
            MoonIlluminationPercentage = data.MoonIlluminationPercentage;
            MoonAngle = data.MoonAngle;
        }

        #endregion
    }
}
