using System.Text.Json.Serialization;

namespace Xcalibur.Weather.Models.Services.WeatherAlert.Emsc;

/// <summary>
/// EMSC geometry (point coordinates).
/// </summary>
public class EmscGeometryResponse
{
    /// <summary>
    /// Gets or sets the type.
    /// </summary>
    /// <value>
    /// The type.
    /// </value>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// Gets or sets the coordinates.
    /// </summary>
    /// <value>
    /// The coordinates.
    /// </value>
    [JsonPropertyName("coordinates")]
    public List<double>? Coordinates { get; set; }
}
