using System.Text.Json.Serialization;

namespace Xcalibur.Weather.Models.Services.WeatherAlert.Bom;

/// <summary>
/// Represents metadata about the BOM warnings feed.
/// </summary>
public class BomMetadataResponse
{
    /// <summary>
    /// Gets or sets the response timestamp.
    /// </summary>
    [JsonPropertyName("response_timestamp")]
    public string? ResponseTimestamp { get; set; }

    /// <summary>
    /// Gets or sets the issue timestamp.
    /// </summary>
    [JsonPropertyName("issue_time")]
    public string? IssueTime { get; set; }

    /// <summary>
    /// Gets or sets the copyright information.
    /// </summary>
    [JsonPropertyName("copyright")]
    public string? Copyright { get; set; }

    /// <summary>
    /// Gets or sets the feed ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}
