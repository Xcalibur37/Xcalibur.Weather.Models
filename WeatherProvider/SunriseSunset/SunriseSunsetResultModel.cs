using System.Text.Json.Serialization;

namespace Xcalibur.Weather.Models.WeatherProvider.SunriseSunset
{
    /// <summary>
    /// The <c>results</c> payload returned by the SunriseSunset.io JSON API.
    /// </summary>
    public class SunriseSunsetResultModel
    {
        /// <summary>Gets or sets the date of the calculation.</summary>
        [JsonPropertyName("date")]
        public string? Date { get; set; }

        /// <summary>Gets or sets the sunrise time.</summary>
        [JsonPropertyName("sunrise")]
        public string? Sunrise { get; set; }

        /// <summary>Gets or sets the sunset time.</summary>
        [JsonPropertyName("sunset")]
        public string? Sunset { get; set; }

        /// <summary>Gets or sets the first light (astronomical dawn) time.</summary>
        [JsonPropertyName("first_light")]
        public string? FirstLight { get; set; }

        /// <summary>Gets or sets the last light (astronomical dusk) time.</summary>
        [JsonPropertyName("last_light")]
        public string? LastLight { get; set; }

        /// <summary>Gets or sets the civil dawn time.</summary>
        [JsonPropertyName("dawn")]
        public string? Dawn { get; set; }

        /// <summary>Gets or sets the civil dusk time.</summary>
        [JsonPropertyName("dusk")]
        public string? Dusk { get; set; }

        /// <summary>Gets or sets the solar noon time.</summary>
        [JsonPropertyName("solar_noon")]
        public string? SolarNoon { get; set; }

        /// <summary>Gets or sets the golden hour time.</summary>
        [JsonPropertyName("golden_hour")]
        public string? GoldenHour { get; set; }

        /// <summary>Gets or sets the total day length (HH:mm:ss).</summary>
        [JsonPropertyName("day_length")]
        public string? DayLength { get; set; }

        /// <summary>Gets or sets the nautical twilight begin time.</summary>
        [JsonPropertyName("nautical_twilight_begin")]
        public string? NauticalTwilightBegin { get; set; }

        /// <summary>Gets or sets the nautical twilight end time.</summary>
        [JsonPropertyName("nautical_twilight_end")]
        public string? NauticalTwilightEnd { get; set; }

        /// <summary>Gets or sets the IANA timezone name.</summary>
        [JsonPropertyName("timezone")]
        public string? Timezone { get; set; }

        /// <summary>Gets or sets the UTC offset in minutes.</summary>
        [JsonPropertyName("utc_offset")]
        public int? UtcOffset { get; set; }

        /// <summary>Gets or sets the current sun altitude in degrees.</summary>
        [JsonPropertyName("sun_altitude")]
        public double? SunAltitude { get; set; }

        /// <summary>Gets or sets the current sun azimuth in degrees.</summary>
        [JsonPropertyName("sun_azimuth")]
        public double? SunAzimuth { get; set; }

        /// <summary>Gets or sets the sunrise azimuth in degrees.</summary>
        [JsonPropertyName("sunrise_azimuth")]
        public double? SunriseAzimuth { get; set; }

        /// <summary>Gets or sets the sunset azimuth in degrees.</summary>
        [JsonPropertyName("sunset_azimuth")]
        public double? SunsetAzimuth { get; set; }

        /// <summary>Gets or sets the moonrise time.</summary>
        [JsonPropertyName("moonrise")]
        public string? Moonrise { get; set; }

        /// <summary>Gets or sets the moonset time.</summary>
        [JsonPropertyName("moonset")]
        public string? Moonset { get; set; }

        /// <summary>Gets or sets the moon illumination percentage (0–100).</summary>
        [JsonPropertyName("moon_illumination")]
        public double? MoonIllumination { get; set; }

        /// <summary>Gets or sets the moon phase name.</summary>
        [JsonPropertyName("moon_phase")]
        public string? MoonPhase { get; set; }

        /// <summary>Gets or sets the moon phase value (0–1).</summary>
        [JsonPropertyName("moon_phase_value")]
        public double? MoonPhaseValue { get; set; }

        /// <summary>Gets or sets a value indicating whether the moon is always above the horizon.</summary>
        [JsonPropertyName("moon_always_up")]
        public bool? MoonAlwaysUp { get; set; }

        /// <summary>Gets or sets a value indicating whether the moon is always below the horizon.</summary>
        [JsonPropertyName("moon_always_down")]
        public bool? MoonAlwaysDown { get; set; }

        /// <summary>Gets or sets the elevation of the location in metres.</summary>
        [JsonPropertyName("elevation")]
        public double? Elevation { get; set; }
    }
}
