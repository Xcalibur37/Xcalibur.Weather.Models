using System.Xml.Serialization;

namespace Xcalibur.Weather.Models.Services.WeatherAlert.EnvironmentCanada
{
    /// <summary>
    /// Represents a single alert entry from Environment Canada.
    /// </summary>
    public class EnvironmentCanadaEntryResponse
    {
        /// <summary>
        /// Gets or sets the entry ID.
        /// </summary>
        [XmlElement("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Gets or sets the alert title.
        /// </summary>
        [XmlElement("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Gets or sets the last updated timestamp.
        /// </summary>
        [XmlElement("updated")]
        public string? Updated { get; set; }

        /// <summary>
        /// Gets or sets the published timestamp.
        /// </summary>
        [XmlElement("published")]
        public string? Published { get; set; }

        /// <summary>
        /// Gets or sets the author information.
        /// </summary>
        [XmlElement("author")]
        public EnvironmentCanadaAuthorResponse? Author { get; set; }

        /// <summary>
        /// Gets or sets the link to the full alert.
        /// </summary>
        [XmlElement("link")]
        public EnvironmentCanadaLinkResponse? Link { get; set; }

        /// <summary>
        /// Gets or sets the alert category.
        /// </summary>
        [XmlElement("category")]
        public EnvironmentCanadaCategoryResponse? Category { get; set; }

        /// <summary>
        /// Gets or sets the alert summary/description.
        /// </summary>
        [XmlElement("summary")]
        public string? Summary { get; set; }

        /// <summary>
        /// Gets or sets the CAP alert reference.
        /// </summary>
        [XmlElement("capAlert", Namespace = "urn:oasis:names:tc:emergency:cap:1.2")]
        public EnvironmentCanadaCapAlertResponse? CapAlert { get; set; }
    }
}
