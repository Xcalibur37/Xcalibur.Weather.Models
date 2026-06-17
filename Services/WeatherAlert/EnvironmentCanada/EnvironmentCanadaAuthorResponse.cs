using System.Xml.Serialization;

namespace Xcalibur.Weather.Models.Services.WeatherAlert.EnvironmentCanada;

/// <summary>
/// Represents the author of the alert.
/// </summary>
public class EnvironmentCanadaAuthorResponse
{
    /// <summary>
    /// Gets or sets the author name.
    /// </summary>
    [XmlElement("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Gets or sets the author URI.
    /// </summary>
    [XmlElement("uri")]
    public string? Uri { get; set; }
}
