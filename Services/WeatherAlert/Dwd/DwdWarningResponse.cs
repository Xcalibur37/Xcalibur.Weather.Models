using System.Text.Json.Serialization;

namespace Xcalibur.Weather.Models.Services.WeatherAlert.Dwd;

/// <summary>
/// DWD warning details.
/// </summary>
public class DwdWarningResponse
{
    /// <summary>
    /// Gets or sets the start.
    /// </summary>
    /// <value>
    /// The start.
    /// </value>
    [JsonPropertyName("start")]
    public long? Start { get; set; }

    /// <summary>
    /// Gets or sets the end.
    /// </summary>
    /// <value>
    /// The end.
    /// </value>
    [JsonPropertyName("end")]
    public long? End { get; set; }

    /// <summary>
    /// Gets or sets the event.
    /// </summary>
    /// <value>
    /// The event.
    /// </value>
    [JsonPropertyName("event")]
    public string? Event { get; set; }

    /// <summary>
    /// Gets or sets the headline.
    /// </summary>
    /// <value>
    /// The headline.
    /// </value>
    [JsonPropertyName("headline")]
    public string? Headline { get; set; }

    /// <summary>
    /// Gets or sets the description.
    /// </summary>
    /// <value>
    /// The description.
    /// </value>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// Gets or sets the instruction.
    /// </summary>
    /// <value>
    /// The instruction.
    /// </value>
    [JsonPropertyName("instruction")]
    public string? Instruction { get; set; }

    /// <summary>
    /// Gets or sets the level.
    /// </summary>
    /// <value>
    /// The level.
    /// </value>
    [JsonPropertyName("level")]
    public int? Level { get; set; }

    /// <summary>
    /// Gets or sets the type.
    /// </summary>
    /// <value>
    /// The type.
    /// </value>
    [JsonPropertyName("type")]
    public int? Type { get; set; }

    /// <summary>
    /// Gets or sets the altitude start.
    /// </summary>
    /// <value>
    /// The altitude start.
    /// </value>
    [JsonPropertyName("altitudeStart")]
    public int? AltitudeStart { get; set; }

    /// <summary>
    /// Gets or sets the altitude end.
    /// </summary>
    /// <value>
    /// The altitude end.
    /// </value>
    [JsonPropertyName("altitudeEnd")]
    public int? AltitudeEnd { get; set; }

    /// <summary>
    /// Gets or sets the state short.
    /// </summary>
    /// <value>
    /// The state short.
    /// </value>
    [JsonPropertyName("stateShort")]
    public string? StateShort { get; set; }

    /// <summary>
    /// Gets or sets the name of the region.
    /// </summary>
    /// <value>
    /// The name of the region.
    /// </value>
    [JsonPropertyName("regionName")]
    public string? RegionName { get; set; }
}
