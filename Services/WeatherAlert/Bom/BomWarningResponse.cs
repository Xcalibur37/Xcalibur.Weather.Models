using System.Text.Json.Serialization;

namespace Xcalibur.Weather.Models.Services.WeatherAlert.Bom;

/// <summary>
/// Represents a single warning from BOM.
/// </summary>
public class BomWarningResponse
{
    /// <summary>
    /// Gets or sets the warning ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Gets or sets the warning type (e.g., severe-thunderstorm, fire-weather, flood).
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// Gets or sets the phase (e.g., alert, watch, cancel).
    /// </summary>
    [JsonPropertyName("phase")]
    public string? Phase { get; set; }

    /// <summary>
    /// Gets or sets the warning title/headline.
    /// </summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }

    /// <summary>
    /// Gets or sets a short title.
    /// </summary>
    [JsonPropertyName("short_title")]
    public string? ShortTitle { get; set; }

    /// <summary>
    /// Gets or sets the issue timestamp.
    /// </summary>
    [JsonPropertyName("issue_time")]
    public string? IssueTime { get; set; }

    /// <summary>
    /// Gets or sets the expiry timestamp.
    /// </summary>
    [JsonPropertyName("expiry_time")]
    public string? ExpiryTime { get; set; }

    /// <summary>
    /// Gets or sets the warning state/territory.
    /// </summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>
    /// Gets or sets the warning level/severity.
    /// </summary>
    [JsonPropertyName("warning_level")]
    public string? WarningLevel { get; set; }

    /// <summary>
    /// Gets or sets the areas affected.
    /// </summary>
    [JsonPropertyName("areas")]
    public List<string> Areas { get; set; } = [];

    /// <summary>
    /// Gets or sets the location IDs affected.
    /// </summary>
    [JsonPropertyName("location_ids")]
    public List<string> LocationIds { get; set; } = [];

    /// <summary>
    /// Gets or sets the warning description/details.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// Gets or sets the product ID.
    /// </summary>
    [JsonPropertyName("product_id")]
    public string? ProductId { get; set; }

    /// <summary>
    /// Gets or sets the warning URL.
    /// </summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

