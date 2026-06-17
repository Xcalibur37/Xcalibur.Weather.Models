using System.Text.Json.Serialization;

namespace Xcalibur.Weather.Models.Services.WeatherAlert.Emsc;

/// <summary>
/// EMSC earthquake feature (GeoJSON-like).
/// </summary>
public class EmscFeatureResponse
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
    /// Gets or sets the identifier.
    /// </summary>
    /// <value>
    /// The identifier.
    /// </value>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Gets or sets the properties.
    /// </summary>
    /// <value>
    /// The properties.
    /// </value>
    [JsonPropertyName("properties")]
    public EmscEventResponse? Properties { get; set; }

    /// <summary>
    /// Gets or sets the geometry.
    /// </summary>
    /// <value>
    /// The geometry.
    /// </value>
    [JsonPropertyName("geometry")]
    public EmscGeometryResponse? Geometry { get; set; }
}
