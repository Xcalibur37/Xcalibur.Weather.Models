using System.Text.Json.Serialization;
using Xcalibur.Weather.Models.Services.OpenMeteo.Base;

namespace Xcalibur.Weather.Models.Services.OpenMeteo.HourlyWeather
{
    /// <summary>
    /// Hourly arrays (times and parallel value arrays)
    /// </summary>
    /// <seealso cref="BaseModel" />
    public class HourlyWeatherModel : BaseModel
    {
        /// <summary>
        /// Gets or sets the temperature2m.
        /// </summary>
        /// <value>
        /// The temperature2m.
        /// </value>
        [JsonPropertyName("temperature_2m")]
        public double?[]? Temperature2m { get; set; }

        /// <summary>
        /// Gets or sets the relative humidity2m.
        /// </summary>
        /// <value>
        /// The relative humidity2m.
        /// </value>
        [JsonPropertyName("relative_humidity_2m")]
        public double?[]? RelativeHumidity2m { get; set; }

        /// <summary>
        /// Gets or sets the dew point2m.
        /// </summary>
        /// <value>
        /// The dew point2m.
        /// </value>
        [JsonPropertyName("dew_point_2m")]
        public double?[]? DewPoint2m { get; set; }

        /// <summary>
        /// Gets or sets the apparent temperature.
        /// </summary>
        /// <value>
        /// The apparent temperature.
        /// </value>
        [JsonPropertyName("apparent_temperature")]
        public double?[]? ApparentTemperature { get; set; }

        /// <summary>
        /// Gets or sets the precipitation probability.
        /// </summary>
        /// <value>
        /// The precipitation probability.
        /// </value>
        [JsonPropertyName("precipitation_probability")]
        public double?[]? PrecipitationProbability { get; set; }

        /// <summary>
        /// Gets or sets the precipitation.
        /// </summary>
        /// <value>
        /// The precipitation.
        /// </value>
        [JsonPropertyName("precipitation")]
        public double?[]? Precipitation { get; set; }

        /// <summary>
        /// Gets or sets the rain.
        /// </summary>
        /// <value>
        /// The rain.
        /// </value>
        [JsonPropertyName("rain")]
        public double?[]? Rain { get; set; }

        /// <summary>
        /// Gets or sets the showers.
        /// </summary>
        /// <value>
        /// The showers.
        /// </value>
        [JsonPropertyName("showers")]
        public double?[]? Showers { get; set; }

        /// <summary>
        /// Gets or sets the snowfall.
        /// </summary>
        /// <value>
        /// The snowfall.
        /// </value>
        [JsonPropertyName("snowfall")]
        public double?[]? Snowfall { get; set; }

        /// <summary>
        /// Gets or sets the snow depth.
        /// </summary>
        /// <value>
        /// The snow depth.
        /// </value>
        [JsonPropertyName("snow_depth")]
        public double?[]? SnowDepth { get; set; }

        /// <summary>
        /// Gets or sets the pressure MSL.
        /// </summary>
        /// <value>
        /// The pressure MSL.
        /// </value>
        [JsonPropertyName("pressure_msl")]
        public double?[]? PressureMsl { get; set; }

        /// <summary>
        /// Gets or sets the surface pressure.
        /// </summary>
        /// <value>
        /// The surface pressure.
        /// </value>
        [JsonPropertyName("surface_pressure")]
        public double?[]? SurfacePressure { get; set; }

        /// <summary>
        /// Gets or sets the cloud cover.
        /// </summary>
        /// <value>
        /// The cloud cover.
        /// </value>
        [JsonPropertyName("cloud_cover")]
        public double?[]? CloudCover { get; set; }

        /// <summary>
        /// Gets or sets the visibility.
        /// </summary>
        /// <value>
        /// The visibility.
        /// </value>
        [JsonPropertyName("visibility")]
        public double?[]? Visibility { get; set; }

        /// <summary>
        /// Gets or sets the wind speed10m.
        /// </summary>
        /// <value>
        /// The wind speed10m.
        /// </value>
        [JsonPropertyName("wind_speed_10m")]
        public double?[]? WindSpeed10m { get; set; }

        /// <summary>
        /// Gets or sets the wind direction10m.
        /// </summary>
        /// <value>
        /// The wind direction10m.
        /// </value>
        [JsonPropertyName("wind_direction_10m")]
        public double?[]? WindDirection10m { get; set; }

        /// <summary>
        /// Gets or sets the wind gusts10m.
        /// </summary>
        /// <value>
        /// The wind gusts10m.
        /// </value>
        [JsonPropertyName("wind_gusts_10m")]
        public double?[]? WindGusts10m { get; set; }

        /// <summary>
        /// Gets or sets the uv index maximum.
        /// </summary>
        /// <value>
        /// The uv index maximum.
        /// </value>
        [JsonPropertyName("uv_index")]
        // ReSharper disable once InconsistentNaming
        public double?[]? UVIndex { get; set; }

        /// <summary>
        /// Gets or sets the is day.
        /// </summary>
        /// <value>
        /// The is day.
        /// </value>
        [JsonPropertyName("is_day")]
        public int?[]? IsDay { get; set; }
    }
}
