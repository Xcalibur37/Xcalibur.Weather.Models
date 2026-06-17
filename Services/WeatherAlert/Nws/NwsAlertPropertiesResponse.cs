using System.Text.Json.Serialization;

namespace Xcalibur.Weather.Models.Services.WeatherAlert.Nws;

/// <summary>
/// Properties of an NWS alert.
/// </summary>
public class NwsAlertPropertiesResponse
{
    /// <summary>
    /// Gets or sets the alert identifier.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Gets or sets the area description.
    /// </summary>
    [JsonPropertyName("areaDesc")]
    public string? AreaDesc { get; set; }

    /// <summary>
    /// Gets or sets the geocode.
    /// </summary>
    [JsonPropertyName("geocode")]
    public NwsGeocodeResponse? Geocode { get; set; }

    /// <summary>
    /// Gets or sets the affected zones.
    /// </summary>
    [JsonPropertyName("affectedZones")]
    public List<string>? AffectedZones { get; set; }

    /// <summary>
    /// Gets or sets the sent time.
    /// </summary>
    [JsonPropertyName("sent")]
    public string? Sent { get; set; }

    /// <summary>
    /// Gets or sets the effective time.
    /// </summary>
    [JsonPropertyName("effective")]
    public string? Effective { get; set; }

    /// <summary>
    /// Gets or sets the onset time.
    /// </summary>
    [JsonPropertyName("onset")]
    public string? Onset { get; set; }

    /// <summary>
    /// Gets or sets the expires time.
    /// </summary>
    [JsonPropertyName("expires")]
    public string? Expires { get; set; }

    /// <summary>
    /// Gets or sets the ends time.
    /// </summary>
    [JsonPropertyName("ends")]
    public string? Ends { get; set; }

    /// <summary>
    /// Gets or sets the status.
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>
    /// Gets or sets the message type.
    /// </summary>
    [JsonPropertyName("messageType")]
    public string? MessageType { get; set; }

    /// <summary>
    /// Gets or sets the category.
    /// </summary>
    [JsonPropertyName("category")]
    public string? Category { get; set; }

    /// <summary>
    /// Gets or sets the severity.
    /// </summary>
    [JsonPropertyName("severity")]
    public string? Severity { get; set; }

    /// <summary>
    /// Gets or sets the certainty.
    /// </summary>
    [JsonPropertyName("certainty")]
    public string? Certainty { get; set; }

    /// <summary>
    /// Gets or sets the urgency.
    /// </summary>
    [JsonPropertyName("urgency")]
    public string? Urgency { get; set; }

    /// <summary>
    /// Gets or sets the event type.
    /// </summary>
    [JsonPropertyName("event")]
    public string? Event { get; set; }

    /// <summary>
    /// Gets or sets the sender.
    /// </summary>
    [JsonPropertyName("sender")]
    public string? Sender { get; set; }

    /// <summary>
    /// Gets or sets the sender name.
    /// </summary>
    [JsonPropertyName("senderName")]
    public string? SenderName { get; set; }

    /// <summary>
    /// Gets or sets the headline.
    /// </summary>
    [JsonPropertyName("headline")]
    public string? Headline { get; set; }

    /// <summary>
    /// Gets or sets the description.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// Gets or sets the instruction.
    /// </summary>
    [JsonPropertyName("instruction")]
    public string? Instruction { get; set; }

    /// <summary>
    /// Gets or sets the response type.
    /// </summary>
    [JsonPropertyName("response")]
    public string? Response { get; set; }

    /// <summary>
    /// Gets or sets the parameters.
    /// </summary>
    [JsonPropertyName("parameters")]
    public Dictionary<string, List<string>>? Parameters { get; set; }
}
