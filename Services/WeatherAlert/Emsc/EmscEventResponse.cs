using System.Text.Json.Serialization;

namespace Xcalibur.Weather.Models.Services.WeatherAlert.Emsc;

/// <summary>
/// EMSC earthquake event properties.
/// </summary>
public class EmscEventResponse
{
    /// <summary>
    /// Gets or sets the magnitude.
    /// </summary>
    /// <value>
    /// The magnitude.
    /// </value>
    [JsonPropertyName("mag")]
    public double? Magnitude { get; set; }

    /// <summary>
    /// Gets or sets the type of the magnitude.
    /// </summary>
    /// <value>
    /// The type of the magnitude.
    /// </value>
    [JsonPropertyName("magType")]
    public string? MagnitudeType { get; set; }

    /// <summary>
    /// Gets or sets the time.
    /// </summary>
    /// <value>
    /// The time.
    /// </value>
    [JsonPropertyName("time")]
    public string? Time { get; set; }

    /// <summary>
    /// Gets or sets the last update.
    /// </summary>
    /// <value>
    /// The last update.
    /// </value>
    [JsonPropertyName("lastupdate")]
    public string? LastUpdate { get; set; }

    /// <summary>
    /// Gets or sets the region.
    /// </summary>
    /// <value>
    /// The region.
    /// </value>
    [JsonPropertyName("flynn_region")]
    public string? Region { get; set; }

    /// <summary>
    /// Gets or sets the depth.
    /// </summary>
    /// <value>
    /// The depth.
    /// </value>
    [JsonPropertyName("depth")]
    public double? Depth { get; set; }

    /// <summary>
    /// Gets or sets the type of the event.
    /// </summary>
    /// <value>
    /// The type of the event.
    /// </value>
    [JsonPropertyName("evtype")]
    public string? EventType { get; set; }

    /// <summary>
    /// Gets or sets the authority.
    /// </summary>
    /// <value>
    /// The authority.
    /// </value>
    [JsonPropertyName("auth")]
    public string? Authority { get; set; }

    /// <summary>
    /// Gets or sets the unique identifier.
    /// </summary>
    /// <value>
    /// The unique identifier.
    /// </value>
    [JsonPropertyName("unid")]
    public string? UniqueId { get; set; }
}
