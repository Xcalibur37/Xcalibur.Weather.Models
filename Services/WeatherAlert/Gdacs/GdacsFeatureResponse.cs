using System.Text.Json.Serialization;

namespace Xcalibur.Weather.Models.Services.WeatherAlert.Gdacs;

/// <summary>
/// Represents a GDACS feature (GeoJSON format).
/// </summary>
public class GdacsFeatureResponse
{
    /// <summary>
    /// Gets or sets the feature type.
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// Gets or sets the properties containing event data.
    /// </summary>
    [JsonPropertyName("properties")]
    public GdacsEventResponse? Properties { get; set; }

    /// <summary>
    /// Gets or sets the geometry.
    /// </summary>
    [JsonPropertyName("geometry")]
    public GdacsGeometryResponse? Geometry { get; set; }
}
