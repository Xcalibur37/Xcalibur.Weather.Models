using System.Text.Json.Serialization;
using Xcalibur.Weather.Models.Implementation.Base;
using Xcalibur.Weather.Models.Services.OpenMeteo.CurrentWeather;

namespace Xcalibur.Weather.Models.Implementation.WeatherForecast
{
    /// <summary>
    /// Detailed Forecast Point.
    /// </summary>
    /// <seealso cref="BaseForecastPoint" />
    public class DetailedForecastPoint : BaseForecastPoint
    {
        #region Properties

        /// <summary>
        /// Gets or sets the date object.
        /// </summary>
        /// <value>
        /// The date object.
        /// </value>
        public DateTime? DateObject { get; set; }

        /// <summary>
        /// Gets or sets the temperature.
        /// </summary>
        /// <value>
        /// The temperature.
        /// </value>
        public double? Temperature { get; set; }

        /// <summary>
        /// Gets or sets the relative humidity.
        /// </summary>
        /// <value>
        /// The relative humidity.
        /// </value>
        public double? RelativeHumidity { get; set; }

        /// <summary>
        /// Gets or sets the apparent temperature.
        /// </summary>
        /// <value>
        /// The apparent temperature.
        /// </value>
        public double? ApparentTemperature { get; set; }

        /// <summary>
        /// Gets or sets the precipitation.
        /// </summary>
        /// <value>
        /// The precipitation.
        /// </value>
        public double? Precipitation { get; set; }

        /// <summary>
        /// Gets or sets the rain.
        /// </summary>
        /// <value>
        /// The rain.
        /// </value>
        public double? Rain { get; set; }

        /// <summary>
        /// Gets or sets the showers.
        /// </summary>
        /// <value>
        /// The showers.
        /// </value>
        public double? Showers { get; set; }

        /// <summary>
        /// Gets or sets the snowfall.
        /// </summary>
        /// <value>
        /// The snowfall.
        /// </value>
        public double? Snowfall { get; set; }

        /// <summary>
        /// Gets or sets the pressure MSL.
        /// </summary>
        /// <value>
        /// The pressure MSL.
        /// </value>
        public double? PressureMsl { get; set; }

        /// <summary>
        /// Gets or sets the surface pressure.
        /// </summary>
        /// <value>
        /// The surface pressure.
        /// </value>
        public double? SurfacePressure { get; set; }

        /// <summary>
        /// Gets or sets the wind speed10m.
        /// </summary>
        /// <value>
        /// The wind speed10m.
        /// </value>
        public double? WindSpeed { get; set; }

        /// <summary>
        /// Gets or sets the wind direction10m.
        /// </summary>
        /// <value>
        /// The wind direction10m.
        /// </value>
        public int? WindDirection { get; set; }

        /// <summary>
        /// Gets or sets the wind gusts10m.
        /// </summary>
        /// <value>
        /// The wind gusts10m.
        /// </value>
        public double? WindGust { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="DetailedForecastPoint" /> class.
        /// </summary>
        [JsonConstructor]
        public DetailedForecastPoint()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DetailedForecastPoint" /> class.
        /// </summary>
        /// <param name="data">The data.</param>
        public DetailedForecastPoint(CurrentWeatherModel data)
        {
            Map(data);
        }

        #endregion

        #region Methods

        /// <summary>
        /// Maps the specified data.
        /// </summary>
        /// <param name="data">The data.</param>
        private void Map(CurrentWeatherModel? data)
        {
            if (data is null) return;

            // No precipitation data to build forecast points.
            var dateValue = data.Time;
            var localDate = DateTime.Parse(dateValue!);

            // Map data to forecast point
            DateValue = dateValue;
            DateObject = localDate;

            // Weather codes
            WeatherCode = data.WeatherCode;
            
            // Temp starts in Celsius by default.
            Temperature = data.Temperature;
            ApparentTemperature = data.ApparentTemperature;

            // Precipitation
            Precipitation = data.Precipitation;
            Rain = data.Rain;
            Showers = data.Showers;
            Snowfall = data.Snowfall;

            // Pressure
            PressureMsl = data.PressureMsl;
            SurfacePressure = data.SurfacePressure;

            // Wind
            WindSpeed = data.WindSpeed;
            WindGust = data.WindGust;
            WindDirection = data.WindDirection;

            // Humidity
            RelativeHumidity = data.RelativeHumidity;

            // Is Day Time
            IsDayTime = data.IsDay == 1;
        }
        
        #endregion
    }
}
