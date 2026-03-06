using System.Text.Json.Serialization;
using Xcalibur.Weather.Models.WeatherProvider.OpenMeteo.Base;

namespace Xcalibur.Weather.Models.WeatherProvider.OpenMeteo.HourlyWeather
{
    // Hourly arrays (times and parallel value arrays)
    public class HourlyWeatherModel : BaseModel
    {
        [JsonPropertyName("temperature_2m")]
        public double?[]? Temperature2m { get; set; }

        [JsonPropertyName("relative_humidity_2m")]
        public double?[]? RelativeHumidity2m { get; set; }

        [JsonPropertyName("dew_point_2m")]
        public double?[]? DewPoint2m { get; set; }

        [JsonPropertyName("apparent_temperature")]
        public double?[]? ApparentTemperature { get; set; }

        [JsonPropertyName("precipitation_probability")]
        public double?[]? PrecipitationProbability { get; set; }

        [JsonPropertyName("precipitation")]
        public double?[]? Precipitation { get; set; }

        [JsonPropertyName("rain")]
        public double?[]? Rain { get; set; }

        [JsonPropertyName("showers")]
        public double?[]? Showers { get; set; }

        [JsonPropertyName("snowfall")]
        public double?[]? Snowfall { get; set; }

        [JsonPropertyName("snow_depth")]
        public double?[]? SnowDepth { get; set; }

        [JsonPropertyName("pressure_msl")]
        public double?[]? PressureMsl { get; set; }

        [JsonPropertyName("surface_pressure")]
        public double?[]? SurfacePressure { get; set; }

        [JsonPropertyName("cloud_cover")]
        public double?[]? CloudCover { get; set; }

        [JsonPropertyName("visibility")]
        public double?[]? Visibility { get; set; }

        [JsonPropertyName("wind_speed_10m")]
        public double?[]? WindSpeed10m { get; set; }

        [JsonPropertyName("wind_direction_10m")]
        public double?[]? WindDirection10m { get; set; }

        [JsonPropertyName("wind_gusts_10m")]
        public double?[]? WindGusts10m { get; set; }
    }
}
