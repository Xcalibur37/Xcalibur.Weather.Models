using System.Text.Json.Serialization;

namespace Xcalibur.Weather.Models.WeatherProvider.OpenMeteo.CurrentWeather
{
    /// <summary>
    /// DTO for the Open‑Meteo "current" object.
    /// Matches the JSON you posted and is safe to use with System.Text.Json.
    /// </summary>
    public class CurrentWeatherModel
    {
        /// <summary>
        /// Gets or sets the time.
        /// </summary>
        /// <value>
        /// The time.
        /// </value>
        [JsonPropertyName("time")]
        public string? Time { get; set; }

        /// <summary>
        /// Gets or sets the interval.
        /// </summary>
        /// <value>
        /// The interval.
        /// </value>
        [JsonPropertyName("interval")]
        public int Interval { get; set; }

        /// <summary>
        /// Gets or sets the temperature.
        /// </summary>
        /// <value>
        /// The temperature.
        /// </value>
        [JsonPropertyName("temperature_2m")]
        public double? Temperature { get; set; }

        /// <summary>
        /// Gets or sets the relative humidity.
        /// </summary>
        /// <value>
        /// The relative humidity.
        /// </value>
        [JsonPropertyName("relative_humidity_2m")]
        public double? RelativeHumidity { get; set; }

        /// <summary>
        /// Gets or sets the apparent temperature.
        /// </summary>
        /// <value>
        /// The apparent temperature.
        /// </value>
        [JsonPropertyName("apparent_temperature")]
        public double? ApparentTemperature { get; set; }

        /// <summary>
        /// Gets or sets the precipitation.
        /// </summary>
        /// <value>
        /// The precipitation.
        /// </value>
        [JsonPropertyName("precipitation")]
        public double? Precipitation { get; set; }

        /// <summary>
        /// Gets or sets the rain.
        /// </summary>
        /// <value>
        /// The rain.
        /// </value>
        [JsonPropertyName("rain")]
        public double? Rain { get; set; }

        /// <summary>
        /// Gets or sets the showers.
        /// </summary>
        /// <value>
        /// The showers.
        /// </value>
        [JsonPropertyName("showers")]
        public double? Showers { get; set; }

        /// <summary>
        /// Gets or sets the snowfall.
        /// </summary>
        /// <value>
        /// The snowfall.
        /// </value>
        [JsonPropertyName("snowfall")]
        public double? Snowfall { get; set; }

        /// <summary>
        /// Gets or sets the weather code.
        /// </summary>
        /// <value>
        /// The weather code.
        /// </value>
        [JsonPropertyName("weather_code")]
        public int? WeatherCode
        {
            get;
            set
            {
                field = value;
                if (value == null) return;
                WeatherCodeValue = WeatherCode.GetWeatherCodeDescription();
            }
        }

        /// <summary>
        /// Gets or sets the weather code value.
        /// </summary>
        /// <value>
        /// The weather code value.
        /// </value>
        public string? WeatherCodeValue { get; set; }

        /// <summary>
        /// Gets or sets the cloud cover.
        /// </summary>
        /// <value>
        /// The cloud cover.
        /// </value>
        [JsonPropertyName("cloud_cover")]
        public double? CloudCover { get; set; }

        /// <summary>
        /// Gets or sets the pressure MSL.
        /// </summary>
        /// <value>
        /// The pressure MSL.
        /// </value>
        [JsonPropertyName("pressure_msl")]
        public double? PressureMsl { get; set; }

        /// <summary>
        /// Gets or sets the surface pressure.
        /// </summary>
        /// <value>
        /// The surface pressure.
        /// </value>
        [JsonPropertyName("surface_pressure")]
        public double? SurfacePressure { get; set; }

        /// <summary>
        /// Gets or sets the wind speed.
        /// </summary>
        /// <value>
        /// The wind speed.
        /// </value>
        [JsonPropertyName("wind_speed_10m")]
        public double? WindSpeed { get; set; }

        /// <summary>
        /// Gets or sets the wind direction.
        /// </summary>
        /// <value>
        /// The wind direction.
        /// </value>
        [JsonPropertyName("wind_direction_10m")]
        public int? WindDirection { get; set; }

        /// <summary>
        /// Gets or sets the wind gust.
        /// </summary>
        /// <value>
        /// The wind gust.
        /// </value>
        [JsonPropertyName("wind_gusts_10m")]
        public double? WindGust { get; set; }

        /// <summary>
        /// Gets or sets the is day.
        /// </summary>
        /// <value>
        /// The is day.
        /// </value>
        [JsonPropertyName("is_day")]
        public bool? IsDay { get; set; }
    }
}
