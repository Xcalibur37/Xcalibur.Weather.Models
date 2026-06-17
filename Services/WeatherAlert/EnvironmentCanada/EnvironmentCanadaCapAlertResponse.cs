using System.Xml.Serialization;

namespace Xcalibur.Weather.Models.Services.WeatherAlert.EnvironmentCanada;

/// <summary>
/// Represents the CAP (Common Alerting Protocol) alert details.
/// </summary>
public class EnvironmentCanadaCapAlertResponse
{
    /// <summary>
    /// Gets or sets the alert identifier.
    /// </summary>
    [XmlElement("identifier")]
    public string? Identifier { get; set; }

    /// <summary>
    /// Gets or sets the sender ID.
    /// </summary>
    [XmlElement("sender")]
    public string? Sender { get; set; }

    /// <summary>
    /// Gets or sets the sent timestamp.
    /// </summary>
    [XmlElement("sent")]
    public string? Sent { get; set; }

    /// <summary>
    /// Gets or sets the alert status (Actual, Exercise, System, Test, Draft).
    /// </summary>
    [XmlElement("status")]
    public string? Status { get; set; }

    /// <summary>
    /// Gets or sets the message type (Alert, Update, Cancel, Ack, Error).
    /// </summary>
    [XmlElement("msgType")]
    public string? MsgType { get; set; }

    /// <summary>
    /// Gets or sets the scope (Public, Restricted, Private).
    /// </summary>
    [XmlElement("scope")]
    public string? Scope { get; set; }

    /// <summary>
    /// Gets or sets the alert information section.
    /// </summary>
    [XmlElement("info")]
    public EnvironmentCanadaCapInfoResponse? Info { get; set; }
}

