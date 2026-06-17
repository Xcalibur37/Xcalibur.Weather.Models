using System.Text.Json.Serialization;

namespace Xcalibur.Weather.Models.Services.OpenMeteo.Base
{
    /// <summary>
    /// Base class for all Open-Meteo API response root objects.
    /// </summary>
    public abstract class BaseResponse
    {
        /// <summary>
        /// Gets or sets the latitude.
        /// </summary>
        [JsonPropertyName("latitude")]
        public double Latitude { get; set; }

        /// <summary>
        /// Gets or sets the longitude.
        /// </summary>
        [JsonPropertyName("longitude")]
        public double Longitude { get; set; }

        /// <summary>
        /// Gets or sets the generation time in milliseconds.
        /// </summary>
        [JsonPropertyName("generationtime_ms")]
        public double GenerationTimeMs { get; set; }

        /// <summary>
        /// Gets or sets the UTC offset in seconds.
        /// </summary>
        [JsonPropertyName("utc_offset_seconds")]
        public int UtcOffsetSeconds { get; set; }

        /// <summary>
        /// Gets or sets the timezone.
        /// </summary>
        [JsonPropertyName("timezone")]
        public string? Timezone { get; set; }

        /// <summary>
        /// Gets or sets the timezone abbreviation.
        /// </summary>
        [JsonPropertyName("timezone_abbreviation")]
        public string? TimezoneAbbreviation { get; set; }

        /// <summary>
        /// Gets or sets the elevation.
        /// </summary>
        [JsonPropertyName("elevation")]
        public double Elevation { get; set; }
    }
}
