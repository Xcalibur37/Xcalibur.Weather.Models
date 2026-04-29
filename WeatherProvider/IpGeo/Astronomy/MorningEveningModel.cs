using System.Text.Json.Serialization;

namespace Xcalibur.Weather.Models.WeatherProvider.IpGeo.Astronomy
{
    /// <summary>
    /// Model representing morning and evening astronomical events.
    /// </summary>
    public class MorningEveningModel
    {
        /// <summary>
        /// Gets or sets the golden hour begin.
        /// </summary>
        /// <value>
        /// The golden hour begin.
        /// </value>
        [JsonPropertyName("golden_hour_begin")]
        public string? GoldenHourBegin { get; set; }

        /// <summary>
        /// Gets or sets the golden hour end.
        /// </summary>
        /// <value>
        /// The golden hour end.
        /// </value>
        [JsonPropertyName("golden_hour_end")]
        public string? GoldenHourEnd { get; set; }

        /// <summary>
        /// Gets or sets the blue hour begin.
        /// </summary>
        /// <value>
        /// The blue hour begin.
        /// </value>
        [JsonPropertyName("blue_hour_begin")]
        public string? BlueHourBegin { get; set; }

        /// <summary>
        /// Gets or sets the blue hour end.
        /// </summary>
        /// <value>
        /// The blue hour end.
        /// </value>
        [JsonPropertyName("blue_hour_end")]
        public string? BlueHourEnd { get; set; }

        /// <summary>
        /// Gets or sets the civil twilight begin.
        /// </summary>
        /// <value>
        /// The civil twilight begin.
        /// </value>
        [JsonPropertyName("civil_twilight_begin")]
        public string? CivilTwilightBegin { get; set; }

        /// <summary>
        /// Gets or sets the civil twilight end.
        /// </summary>
        /// <value>
        /// The civil twilight end.
        /// </value>
        [JsonPropertyName("civil_twilight_end")]
        public string? CivilTwilightEnd { get; set; }

        /// <summary>
        /// Gets or sets the nautical twilight begin.
        /// </summary>
        /// <value>
        /// The nautical twilight begin.
        /// </value>
        [JsonPropertyName("nautical_twilight_begin")]
        public string? NauticalTwilightBegin { get; set; }

        /// <summary>
        /// Gets or sets the nautical twilight end.
        /// </summary>
        /// <value>
        /// The nautical twilight end.
        /// </value>
        [JsonPropertyName("nautical_twilight_end")]
        public string? NauticalTwilightEnd { get; set; }

        /// <summary>
        /// Gets or sets the astronomical twilight begin.
        /// </summary>
        /// <value>
        /// The astronomical twilight begin.
        /// </value>
        [JsonPropertyName("astronomical_twilight_begin")]
        public string? AstronomicalTwilightBegin { get; set; }

        /// <summary>
        /// Gets or sets the astronomical twilight end.
        /// </summary>
        /// <value>
        /// The astronomical twilight end.
        /// </value>
        [JsonPropertyName("astronomical_twilight_end")]
        public string? AstronomicalTwilightEnd { get; set; }
    }
}
