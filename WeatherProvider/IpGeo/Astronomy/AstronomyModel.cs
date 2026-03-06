using System.Text.Json.Serialization;

namespace Xcalibur.Weather.Models.WeatherProvider.IpGeo.Astronomy
{
    /// <summary>
    /// Astronomy data model representing various celestial events and measurements.
    /// </summary>
    public class AstronomyModel
    {
        [JsonPropertyName("date")]
        public string? Date { get; set; }

        [JsonPropertyName("current_time")]
        public string? CurrentTime { get; set; }

        [JsonPropertyName("mid_night")]
        public string? MidNight { get; set; }

        [JsonPropertyName("night_end")]
        public string? NightEnd { get; set; }

        [JsonPropertyName("morning")]
        public MorningEveningModel? Morning { get; set; }

        [JsonPropertyName("sunrise")]
        public string? Sunrise { get; set; }

        [JsonPropertyName("sunset")]
        public string? Sunset { get; set; }

        [JsonPropertyName("evening")]
        public MorningEveningModel? Evening { get; set; }

        [JsonPropertyName("night_begin")]
        public string? NightBegin { get; set; }

        [JsonPropertyName("sun_status")]
        public string? SunStatus { get; set; }

        [JsonPropertyName("solar_noon")]
        public string? SolarNoon { get; set; }

        [JsonPropertyName("day_length")]
        public string? DayLength { get; set; }

        [JsonPropertyName("sun_altitude")]
        public double? SunAltitude { get; set; }

        [JsonPropertyName("sun_distance")]
        public double? SunDistance { get; set; }

        [JsonPropertyName("sun_azimuth")]
        public double? SunAzimuth { get; set; }

        [JsonPropertyName("moon_phase")]
        public string? MoonPhase { get; set; }

        [JsonPropertyName("moonrise")]
        public string? Moonrise { get; set; }

        [JsonPropertyName("moonset")]
        public string? Moonset { get; set; }

        [JsonPropertyName("moon_status")]
        public string? MoonStatus { get; set; }

        [JsonPropertyName("moon_altitude")]
        public double? MoonAltitude { get; set; }

        [JsonPropertyName("moon_distance")]
        public double? MoonDistance { get; set; }

        [JsonPropertyName("moon_azimuth")]
        public double? MoonAzimuth { get; set; }

        [JsonPropertyName("moon_parallactic_angle")]
        public double? MoonParallacticAngle { get; set; }

        [JsonPropertyName("moon_illumination_percentage")]
        public string? MoonIlluminationPercentage { get; set; }

        [JsonPropertyName("moon_angle")]
        public double? MoonAngle { get; set; }
    }
}
