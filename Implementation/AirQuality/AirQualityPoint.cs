using Xcalibur.Weather.Models.Helpers;
using Xcalibur.Weather.Models.Services.OpenMeteo.CurrentAirQuality;

namespace Xcalibur.Weather.Models.Implementation.AirQuality
{
    /// <summary>
    /// Air Quality Point.
    /// </summary>
    public class AirQualityPoint
    {
        #region Properties 
        
        /// <summary>
        /// Gets or sets the time.
        /// </summary>
        /// <value>
        /// The time.
        /// </value>
        public string? Time { get; set; }

        /// <summary>
        /// Gets or sets the interval.
        /// </summary>
        /// <value>
        /// The interval.
        /// </value>
        public int Interval { get; set; }

        /// <summary>
        /// Gets or sets the us aqi.
        /// </summary>
        /// <value>
        /// The us aqi.
        /// </value>
        public int? UsAqi
        {
            get;
            set
            {
                field = value;
                UsAqiValue = value.GetAqiValueDescription();
                UsAqiDetails = value.GetAqiValueDetails();
            }
        }

        /// <summary>
        /// Gets or sets the US AQI value.
        /// </summary>
        /// <value>
        /// The US AQI value.
        /// </value>
        public string? UsAqiValue { get; private set; }

        /// <summary>
        /// Gets the US AQI details.
        /// </summary>
        /// <value>
        /// The US AQI details.
        /// </value>
        public string? UsAqiDetails { get; private set; }

        /// <summary>
        /// Gets or sets the PM10.
        /// </summary>
        /// <value>
        /// The PM10.
        /// </value>
        public double? Pm10 { get; set; }

        /// <summary>
        /// Gets or sets the carbon monoxide.
        /// </summary>
        /// <value>
        /// The carbon monoxide.
        /// </value>
        public double? CarbonMonoxide { get; set; }

        /// <summary>
        /// Gets or sets the PM2 5.
        /// </summary>
        /// <value>
        /// The PM2 5.
        /// </value>
        public double? Pm25 { get; set; }

        /// <summary>
        /// Gets or sets the nitrogen dioxide.
        /// </summary>
        /// <value>
        /// The nitrogen dioxide.
        /// </value>
        public double? NitrogenDioxide { get; set; }

        /// <summary>
        /// Gets or sets the sulphur dioxide.
        /// </summary>
        /// <value>
        /// The sulphur dioxide.
        /// </value>
        public double? SulphurDioxide { get; set; }

        /// <summary>
        /// Gets or sets the ozone.
        /// </summary>
        /// <value>
        /// The ozone.
        /// </value>
        public double? Ozone { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="AirQualityPoint" /> class.
        /// </summary>
        /// <param name="data">The data.</param>
        public AirQualityPoint(AirQualityModel? data = null)
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
        private void Map(AirQualityModel? data)
        {
            if (data is null) return;
            Time = data.Time;
            Interval = data.Interval;
            UsAqi = data.UsAqi;
            Pm10 = data.Pm10;
            CarbonMonoxide = data.CarbonMonoxide;
            Pm25 = data.Pm2_5;
            NitrogenDioxide = data.NitrogenDioxide;
            SulphurDioxide = data.SulphurDioxide;
            Ozone = data.Ozone;
        }

        #endregion
    }
}
