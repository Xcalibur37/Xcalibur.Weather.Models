using System.Text.Json.Serialization;

namespace Xcalibur.Weather.Models.Services.WeatherAlert.Gdacs;

/// <summary>
/// Represents the geometry of a GDACS event.
/// </summary>
public class GdacsGeometryResponse
{
    /// <summary>
    /// Gets or sets the geometry type.
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// Gets or sets the coordinates [longitude, latitude].
    /// </summary>
    [JsonPropertyName("coordinates")]
    public List<double>? Coordinates { get; set; }
}
