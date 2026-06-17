using System.Xml.Serialization;

namespace Xcalibur.Weather.Models.Services.WeatherAlert.EnvironmentCanada
{
    /// <summary>
    /// Represents the root feed response from Environment Canada weather alerts.
    /// </summary>
    [XmlRoot("feed", Namespace = "http://www.w3.org/2005/Atom")]
    public class EnvironmentCanadaResponse
    {
        /// <summary>
        /// Gets or sets the feed title.
        /// </summary>
        [XmlElement("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Gets or sets the feed subtitle.
        /// </summary>
        [XmlElement("subtitle")]
        public string? Subtitle { get; set; }

        /// <summary>
        /// Gets or sets the last updated timestamp.
        /// </summary>
        [XmlElement("updated")]
        public string? Updated { get; set; }

        /// <summary>
        /// Gets or sets the feed ID.
        /// </summary>
        [XmlElement("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Gets or sets the logo URL.
        /// </summary>
        [XmlElement("logo")]
        public string? Logo { get; set; }

        /// <summary>
        /// Gets or sets the rights/copyright information.
        /// </summary>
        [XmlElement("rights")]
        public string? Rights { get; set; }

        /// <summary>
        /// Gets or sets the list of alert entries.
        /// </summary>
        [XmlElement("entry")]
        public List<EnvironmentCanadaEntryResponse> Entries { get; set; } = [];
    }
}
