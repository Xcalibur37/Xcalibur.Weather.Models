using System.Text.Json.Serialization;
using Xcalibur.Weather.Models.Implementation.Base;
using Xcalibur.Weather.Models.Services.OpenMeteo.HourlyWeather;

namespace Xcalibur.Weather.Models.Implementation.WeatherForecast
{
    /// <summary>
    /// Hourly Forecast Point.
    /// </summary>
    /// <seealso cref="BaseForecastPoint" />
    public class HourlyForecastPoint : BaseForecastPoint
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
        /// Gets or sets the dew point.
        /// </summary>
        /// <value>
        /// The dew point.
        /// </value>
        public double? DewPoint { get; set; }

        /// <summary>
        /// Gets or sets the apparent temperature.
        /// </summary>
        /// <value>
        /// The apparent temperature.
        /// </value>
        public double? ApparentTemperature { get; set; }

        /// <summary>
        /// Gets or sets the precipitation probability.
        /// </summary>
        /// <value>
        /// The precipitation probability.
        /// </value>
        public double? PrecipitationProbability { get; set; }

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
        /// Gets or sets the snow depth.
        /// </summary>
        /// <value>
        /// The snow depth.
        /// </value>
        public double? SnowDepth { get; set; }

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
        /// Gets or sets the cloud cover.
        /// </summary>
        /// <value>
        /// The cloud cover.
        /// </value>
        public double? CloudCover { get; set; }

        /// <summary>
        /// Gets or sets the visibility.
        /// </summary>
        /// <value>
        /// The visibility.
        /// </value>
        public double? Visibility { get; set; }

        /// <summary>
        /// Gets or sets the wind speed at 10m.
        /// </summary>
        /// <value>
        /// The wind speed10m.
        /// </value>
        public double? WindSpeed { get; set; }

        /// <summary>
        /// Gets or sets the wind direction at 10m.
        /// </summary>
        /// <value>
        /// The wind direction10m.
        /// </value>
        public double? WindDirection { get; set; }

        /// <summary>
        /// Gets or sets the wind gusts at 10m.
        /// </summary>
        /// <value>
        /// The wind gusts10m.
        /// </value>
        public double? WindGust { get; set; }

        /// <summary>
        /// Gets or sets the uv index maximum.
        /// </summary>
        /// <value>
        /// The uv index maximum.
        /// </value>
        // ReSharper disable once InconsistentNaming
        public double? UVIndex { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="HourlyForecastPoint"/> class.
        /// </summary>
        [JsonConstructor]
        public HourlyForecastPoint()
        {
            
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DetailedForecastPoint" /> class.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <param name="index">The index.</param>
        /// <param name="isCurrent">if set to <c>true</c> [is current].</param>
        public HourlyForecastPoint(HourlyWeatherModel? data = null, int index = 0, bool isCurrent = false)
        {
            if (data is null) return;
            Map(data, index, isCurrent);
        }

        #endregion

        #region Methods

        /// <summary>
        /// Maps the specified data.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <param name="index">The index.</param>
        /// <param name="isCurrent">if set to <c>true</c> [is current].</param>
        private void Map(HourlyWeatherModel? data, int index, bool isCurrent = false)
        {
            // Validate index bounds for primary time array
            if (data?.Time is null || index < 0 || index >= data.Time.Length) return;

            // Map data to forecast point
            var dateValue = data.Time[index];
            DateValue = dateValue;
            DateObject = DateTime.Parse(dateValue!);

            // Weather codes
            WeatherCode = data.WeatherCodes is not null && index < data.WeatherCodes.Length 
                ? data.WeatherCodes[index] 
                : null;

            // Temp starts in Celsius by default.
            Temperature = data.Temperature2m is not null && index < data.Temperature2m.Length 
                ? data.Temperature2m[index] 
                : null;
            ApparentTemperature = data.ApparentTemperature is not null && index < data.ApparentTemperature.Length 
                ? data.ApparentTemperature[index] 
                : null;

            // Humidity
            RelativeHumidity = data.RelativeHumidity2m is not null && index < data.RelativeHumidity2m.Length 
                ? data.RelativeHumidity2m[index] 
                : null;

            // Dew Point
            DewPoint = data.DewPoint2m is not null && index < data.DewPoint2m.Length 
                ? data.DewPoint2m[index] 
                : null;

            // Precipitation
            PrecipitationProbability = data.PrecipitationProbability is not null && index < data.PrecipitationProbability.Length 
                ? data.PrecipitationProbability[index] 
                : null;
            Precipitation = data.Precipitation is not null && index < data.Precipitation.Length 
                ? data.Precipitation[index] 
                : null;
            Rain = data.Rain is not null && index < data.Rain.Length 
                ? data.Rain[index] 
                : null;
            Showers = data.Showers is not null && index < data.Showers.Length 
                ? data.Showers[index] 
                : null;
            Snowfall = data.Snowfall is not null && index < data.Snowfall.Length 
                ? data.Snowfall[index] 
                : null;
            SnowDepth = data.SnowDepth is not null && index < data.SnowDepth.Length 
                ? data.SnowDepth[index] 
                : null;

            // Pressure
            PressureMsl = data.PressureMsl is not null && index < data.PressureMsl.Length 
                ? data.PressureMsl[index] 
                : null;
            SurfacePressure = data.SurfacePressure is not null && index < data.SurfacePressure.Length 
                ? data.SurfacePressure[index] 
                : null;

            // Cloud Cover
            CloudCover = data.CloudCover is not null && index < data.CloudCover.Length 
                ? data.CloudCover[index] 
                : null;

            // Visibility
            Visibility = data.Visibility is not null && index < data.Visibility.Length 
                ? data.Visibility[index] 
                : null;

            // Wind
            WindSpeed = data.WindSpeed10m is not null && index < data.WindSpeed10m.Length 
                ? data.WindSpeed10m[index] 
                : null;
            WindDirection = data.WindDirection10m is not null && index < data.WindDirection10m.Length 
                ? data.WindDirection10m[index] 
                : null;
            WindGust = data.WindGusts10m is not null && index < data.WindGusts10m.Length 
                ? data.WindGusts10m[index] 
                : null;

            // UV Index
            UVIndex = data.UVIndex is not null && index < data.UVIndex.Length 
                ? data.UVIndex[index] 
                : null;

            // Is Day Time
            IsDayTime = data.IsDay is not null && index < data.IsDay.Length && data.IsDay[index] == 1;

            // Is Current
            IsCurrent = isCurrent;
        }

        #endregion
    }
}
