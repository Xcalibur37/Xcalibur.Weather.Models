using System.Xml.Serialization;

namespace Xcalibur.Weather.Models.Services.WeatherAlert.EnvironmentCanada;

/// <summary>
/// Represents the affected geographic area.
/// </summary>
public class EnvironmentCanadaCapAreaResponse
{
    /// <summary>
    /// Gets or sets the area description.
    /// </summary>
    [XmlElement("areaDesc")]
    public string? AreaDesc { get; set; }

    /// <summary>
    /// Gets or sets the polygon coordinates.
    /// </summary>
    [XmlElement("polygon")]
    public string? Polygon { get; set; }

    /// <summary>
    /// Gets or sets geocode values.
    /// </summary>
    [XmlElement("geocode")]
    public List<EnvironmentCanadaGeocodeResponse> Geocodes { get; set; } = [];
}
