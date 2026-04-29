using System.Text.Json.Serialization;

namespace Xcalibur.Weather.Models.WeatherProvider.OpenMeteo.CurrentWeather
{
    /// <summary>
    /// DTO for the Open‑Meteo current weather response.
    /// </summary>
    public class CurrentWeatherResponse
    {
        /// <summary>
        /// Gets or sets the latitude.
        /// </summary>
        /// <value>
        /// The latitude.
        /// </value>
        [JsonPropertyName("latitude")]
        public double Latitude { get; set; }

        /// <summary>
        /// Gets or sets the longitude.
        /// </summary>
        /// <value>
        /// The longitude.
        /// </value>
        [JsonPropertyName("longitude")]
        public double Longitude { get; set; }

        /// <summary>
        /// Gets or sets the generation time ms.
        /// </summary>
        /// <value>
        /// The generation time ms.
        /// </value>
        [JsonPropertyName("generationtime_ms")]
        public double GenerationTimeMs { get; set; }

        /// <summary>
        /// Gets or sets the UTC offset seconds.
        /// </summary>
        /// <value>
        /// The UTC offset seconds.
        /// </value>
        [JsonPropertyName("utc_offset_seconds")]
        public int UtcOffsetSeconds { get; set; }

        /// <summary>
        /// Gets or sets the timezone.
        /// </summary>
        /// <value>
        /// The timezone.
        /// </value>
        [JsonPropertyName("timezone")]
        public string? Timezone { get; set; }

        /// <summary>
        /// Gets or sets the timezone abbreviation.
        /// </summary>
        /// <value>
        /// The timezone abbreviation.
        /// </value>
        [JsonPropertyName("timezone_abbreviation")]
        public string? TimezoneAbbreviation { get; set; }

        /// <summary>
        /// Gets or sets the elevation.
        /// </summary>
        /// <value>
        /// The elevation.
        /// </value>
        [JsonPropertyName("elevation")]
        public double Elevation { get; set; }

        /// <summary>
        /// Gets or sets the current units.
        /// </summary>
        /// <value>
        /// The current units.
        /// </value>
        [JsonPropertyName("current_units")]
        public CurrentWeatherUnits? CurrentUnits { get; set; }

        /// <summary>
        /// Gets or sets the current.
        /// </summary>
        /// <value>
        /// The current.
        /// </value>
        [JsonPropertyName("current")]
        public CurrentWeatherModel? Current { get; set; }
    }
}
