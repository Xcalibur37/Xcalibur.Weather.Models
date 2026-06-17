using System.Xml.Serialization;

namespace Xcalibur.Weather.Models.Services.WeatherAlert.EnvironmentCanada;

/// <summary>
/// Represents the CAP info section with alert details.
/// </summary>
public class EnvironmentCanadaCapInfoResponse
{
    /// <summary>
    /// Gets or sets the language code.
    /// </summary>
    [XmlElement("language")]
    public string? Language { get; set; }

    /// <summary>
    /// Gets or sets the event category (Met, Geo, Safety, Security, Rescue, Fire, Health, Env, Transport, Infra, CBRNE, Other).
    /// </summary>
    [XmlElement("category")]
    public string? Category { get; set; }

    /// <summary>
    /// Gets or sets the event type/name.
    /// </summary>
    [XmlElement("event")]
    public string? Event { get; set; }

    /// <summary>
    /// Gets or sets the urgency (Immediate, Expected, Future, Past, Unknown).
    /// </summary>
    [XmlElement("urgency")]
    public string? Urgency { get; set; }

    /// <summary>
    /// Gets or sets the severity (Extreme, Severe, Moderate, Minor, Unknown).
    /// </summary>
    [XmlElement("severity")]
    public string? Severity { get; set; }

    /// <summary>
    /// Gets or sets the certainty (Observed, Likely, Possible, Unlikely, Unknown).
    /// </summary>
    [XmlElement("certainty")]
    public string? Certainty { get; set; }

    /// <summary>
    /// Gets or sets the effective timestamp.
    /// </summary>
    [XmlElement("effective")]
    public string? Effective { get; set; }

    /// <summary>
    /// Gets or sets the expires timestamp.
    /// </summary>
    [XmlElement("expires")]
    public string? Expires { get; set; }

    /// <summary>
    /// Gets or sets the sender name.
    /// </summary>
    [XmlElement("senderName")]
    public string? SenderName { get; set; }

    /// <summary>
    /// Gets or sets the headline/title.
    /// </summary>
    [XmlElement("headline")]
    public string? Headline { get; set; }

    /// <summary>
    /// Gets or sets the description.
    /// </summary>
    [XmlElement("description")]
    public string? Description { get; set; }

    /// <summary>
    /// Gets or sets the instruction.
    /// </summary>
    [XmlElement("instruction")]
    public string? Instruction { get; set; }

    /// <summary>
    /// Gets or sets the web URL for more information.
    /// </summary>
    [XmlElement("web")]
    public string? Web { get; set; }

    /// <summary>
    /// Gets or sets the affected area.
    /// </summary>
    [XmlElement("area")]
    public EnvironmentCanadaCapAreaResponse? Area { get; set; }
}
