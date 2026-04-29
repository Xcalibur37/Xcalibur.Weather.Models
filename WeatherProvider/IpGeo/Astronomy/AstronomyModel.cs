using System.Text.Json.Serialization;

namespace Xcalibur.Weather.Models.WeatherProvider.IpGeo.Astronomy
{
    /// <summary>
    /// Astronomy data model representing various celestial events and measurements.
    /// </summary>
    public class AstronomyModel
    {
        /// <summary>
        /// Gets or sets the date.
        /// </summary>
        /// <value>
        /// The date.
        /// </value>
        [JsonPropertyName("date")]
        public string? Date { get; set; }

        /// <summary>
        /// Gets or sets the current time.
        /// </summary>
        /// <value>
        /// The current time.
        /// </value>
        [JsonPropertyName("current_time")]
        public string? CurrentTime { get; set; }

        /// <summary>
        /// Gets or sets the mid night.
        /// </summary>
        /// <value>
        /// The mid night.
        /// </value>
        [JsonPropertyName("mid_night")]
        public string? MidNight { get; set; }

        /// <summary>
        /// Gets or sets the night end.
        /// </summary>
        /// <value>
        /// The night end.
        /// </value>
        [JsonPropertyName("night_end")]
        public string? NightEnd { get; set; }

        /// <summary>
        /// Gets or sets the morning.
        /// </summary>
        /// <value>
        /// The morning.
        /// </value>
        [JsonPropertyName("morning")]
        public MorningEveningModel? Morning { get; set; }

        /// <summary>
        /// Gets or sets the sunrise.
        /// </summary>
        /// <value>
        /// The sunrise.
        /// </value>
        [JsonPropertyName("sunrise")]
        public string? Sunrise { get; set; }

        /// <summary>
        /// Gets or sets the sunset.
        /// </summary>
        /// <value>
        /// The sunset.
        /// </value>
        [JsonPropertyName("sunset")]
        public string? Sunset { get; set; }

        /// <summary>
        /// Gets or sets the evening.
        /// </summary>
        /// <value>
        /// The evening.
        /// </value>
        [JsonPropertyName("evening")]
        public MorningEveningModel? Evening { get; set; }

        /// <summary>
        /// Gets or sets the night begin.
        /// </summary>
        /// <value>
        /// The night begin.
        /// </value>
        [JsonPropertyName("night_begin")]
        public string? NightBegin { get; set; }

        /// <summary>
        /// Gets or sets the sun status.
        /// </summary>
        /// <value>
        /// The sun status.
        /// </value>
        [JsonPropertyName("sun_status")]
        public string? SunStatus { get; set; }

        /// <summary>
        /// Gets or sets the solar noon.
        /// </summary>
        /// <value>
        /// The solar noon.
        /// </value>
        [JsonPropertyName("solar_noon")]
        public string? SolarNoon { get; set; }

        /// <summary>
        /// Gets or sets the length of the day.
        /// </summary>
        /// <value>
        /// The length of the day.
        /// </value>
        [JsonPropertyName("day_length")]
        public string? DayLength { get; set; }

        /// <summary>
        /// Gets or sets the sun altitude.
        /// </summary>
        /// <value>
        /// The sun altitude.
        /// </value>
        [JsonPropertyName("sun_altitude")]
        public double? SunAltitude { get; set; }

        /// <summary>
        /// Gets or sets the sun distance.
        /// </summary>
        /// <value>
        /// The sun distance.
        /// </value>
        [JsonPropertyName("sun_distance")]
        public double? SunDistance { get; set; }

        /// <summary>
        /// Gets or sets the sun azimuth.
        /// </summary>
        /// <value>
        /// The sun azimuth.
        /// </value>
        [JsonPropertyName("sun_azimuth")]
        public double? SunAzimuth { get; set; }

        /// <summary>
        /// Gets or sets the moon phase.
        /// </summary>
        /// <value>
        /// The moon phase.
        /// </value>
        [JsonPropertyName("moon_phase")]
        public string? MoonPhase { get; set; }

        /// <summary>
        /// Gets or sets the moonrise.
        /// </summary>
        /// <value>
        /// The moonrise.
        /// </value>
        [JsonPropertyName("moonrise")]
        public string? Moonrise { get; set; }

        /// <summary>
        /// Gets or sets the moonset.
        /// </summary>
        /// <value>
        /// The moonset.
        /// </value>
        [JsonPropertyName("moonset")]
        public string? Moonset { get; set; }

        /// <summary>
        /// Gets or sets the moon status.
        /// </summary>
        /// <value>
        /// The moon status.
        /// </value>
        [JsonPropertyName("moon_status")]
        public string? MoonStatus { get; set; }

        /// <summary>
        /// Gets or sets the moon altitude.
        /// </summary>
        /// <value>
        /// The moon altitude.
        /// </value>
        [JsonPropertyName("moon_altitude")]
        public double? MoonAltitude { get; set; }

        /// <summary>
        /// Gets or sets the moon distance.
        /// </summary>
        /// <value>
        /// The moon distance.
        /// </value>
        [JsonPropertyName("moon_distance")]
        public double? MoonDistance { get; set; }

        /// <summary>
        /// Gets or sets the moon azimuth.
        /// </summary>
        /// <value>
        /// The moon azimuth.
        /// </value>
        [JsonPropertyName("moon_azimuth")]
        public double? MoonAzimuth { get; set; }

        /// <summary>
        /// Gets or sets the moon parallactic angle.
        /// </summary>
        /// <value>
        /// The moon parallactic angle.
        /// </value>
        [JsonPropertyName("moon_parallactic_angle")]
        public double? MoonParallacticAngle { get; set; }

        /// <summary>
        /// Gets or sets the moon illumination percentage.
        /// </summary>
        /// <value>
        /// The moon illumination percentage.
        /// </value>
        [JsonPropertyName("moon_illumination_percentage")]
        public string? MoonIlluminationPercentage { get; set; }

        /// <summary>
        /// Gets or sets the moon angle.
        /// </summary>
        /// <value>
        /// The moon angle.
        /// </value>
        [JsonPropertyName("moon_angle")]
        public double? MoonAngle { get; set; }
    }
}
