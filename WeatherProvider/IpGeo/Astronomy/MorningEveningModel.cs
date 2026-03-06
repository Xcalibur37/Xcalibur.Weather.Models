using System.Text.Json.Serialization;

namespace Xcalibur.Weather.Models.WeatherProvider.IpGeo.Astronomy
{
    /// <summary>
    /// Model representing morning and evening astronomical events.
    /// </summary>
    public class MorningEveningModel
    {
        [JsonPropertyName("golden_hour_begin")]
        public string? GoldenHourBegin { get; set; }

        [JsonPropertyName("golden_hour_end")]
        public string? GoldenHourEnd { get; set; }

        [JsonPropertyName("blue_hour_begin")]
        public string? BlueHourBegin { get; set; }

        [JsonPropertyName("blue_hour_end")]
        public string? BlueHourEnd { get; set; }

        [JsonPropertyName("civil_twilight_begin")]
        public string? CivilTwilightBegin { get; set; }

        [JsonPropertyName("civil_twilight_end")]
        public string? CivilTwilightEnd { get; set; }

        [JsonPropertyName("nautical_twilight_begin")]
        public string? NauticalTwilightBegin { get; set; }

        [JsonPropertyName("nautical_twilight_end")]
        public string? NauticalTwilightEnd { get; set; }

        [JsonPropertyName("astronomical_twilight_begin")]
        public string? AstronomicalTwilightBegin { get; set; }

        [JsonPropertyName("astronomical_twilight_end")]
        public string? AstronomicalTwilightEnd { get; set; }
    }
}
