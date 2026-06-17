using System.Xml.Serialization;

namespace Xcalibur.Weather.Models.Services.WeatherAlert.EnvironmentCanada;

/// <summary>
/// Represents an alert category.
/// </summary>
public class EnvironmentCanadaCategoryResponse
{
    /// <summary>
    /// Gets or sets the category term.
    /// </summary>
    [XmlAttribute("term")]
    public string? Term { get; set; }
}
