using System.Xml.Serialization;

namespace Xcalibur.Weather.Models.Services.WeatherAlert.EnvironmentCanada;

/// <summary>
/// Represents a geocode key-value pair.
/// </summary>
public class EnvironmentCanadaGeocodeResponse
{
    /// <summary>
    /// Gets or sets the geocode name/type.
    /// </summary>
    [XmlElement("valueName")]
    public string? ValueName { get; set; }

    /// <summary>
    /// Gets or sets the geocode value.
    /// </summary>
    [XmlElement("value")]
    public string? Value { get; set; }
}
