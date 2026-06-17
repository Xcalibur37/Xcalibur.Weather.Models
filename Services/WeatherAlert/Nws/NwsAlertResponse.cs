using System.Text.Json.Serialization;

namespace Xcalibur.Weather.Models.Services.WeatherAlert.Nws;

/// <summary>
/// Represents a single National Weather Service alert.
/// </summary>
public class NwsAlertResponse
{
    /// <summary>
    /// Gets or sets the alert identifier.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Gets or sets the alert type.
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// Gets or sets the properties.
    /// </summary>
    [JsonPropertyName("properties")]
    public NwsAlertPropertiesResponse? Properties { get; set; }
}

