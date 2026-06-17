using System.Xml.Serialization;

namespace Xcalibur.Weather.Models.Services.WeatherAlert.EnvironmentCanada;

/// <summary>
/// Represents a link to the full alert.
/// </summary>
public class EnvironmentCanadaLinkResponse
{
    /// <summary>
    /// Gets or sets the link href.
    /// </summary>
    [XmlAttribute("href")]
    public string? Href { get; set; }

    /// <summary>
    /// Gets or sets the link type.
    /// </summary>
    [XmlAttribute("type")]
    public string? Type { get; set; }
}
