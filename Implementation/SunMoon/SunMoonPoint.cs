using System.Text.Json.Serialization;
using Xcalibur.Weather.Models.Services.Astronomy.Response;

namespace Xcalibur.Weather.Models.Implementation.SunMoon
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
        /// Gets or sets the golden hour time.
        /// </summary>
        /// <value>
        /// The golden hour.
        /// </value>
        public string? GoldenHour { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="SunMoonPoint"/> class.
        /// </summary>
        [JsonConstructor]   
        public SunMoonPoint()
        {
            
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SunMoonPoint"/> class.
        /// </summary>
        /// <param name="data">The data.</param>
        public SunMoonPoint(AstronomyResponse? data = null)
        {
            if (data is null) return;
            Map(data);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SunMoonPoint"/> class
        /// from a <see cref="SunriseSunsetResultResponse"/>.
        /// </summary>
        /// <param name="data">The SunriseSunset.io result response.</param>
        public SunMoonPoint(SunriseSunsetResultResponse data)
        {
            Map(data);
        }

        #endregion

        #region Methods

        /// <summary>
        /// Maps the specified data.
        /// </summary>
        /// <param name="data">The data.</param>
        private void Map(AstronomyResponse? data)
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
        }

        /// <summary>
        /// Maps the specified data from a <see cref="SunriseSunsetResultResponse"/>.
        /// </summary>
        /// <param name="data">The SunriseSunset.io result response.</param>
        private void Map(SunriseSunsetResultResponse data)
        {
            // Sun
            Sunrise = data.Sunrise;
            Sunset = data.Sunset;
            DayLength = data.DayLength;

            // Moon
            Moonrise = data.Moonrise;
            Moonset = data.Moonset;
            MoonPhase = data.MoonPhase;
            MoonIlluminationPercentage = data.MoonIllumination?.ToString("F2");
            GoldenHour = data.GoldenHour;
        }

        #endregion
    }
}
