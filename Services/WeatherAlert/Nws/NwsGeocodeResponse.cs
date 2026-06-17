using System.Text.Json.Serialization;

namespace Xcalibur.Weather.Models.Services.WeatherAlert.Nws;

/// <summary>
/// Geocode information for an NWS alert.
/// </summary>
public class NwsGeocodeResponse
{
    /// <summary>
    /// Gets or sets the SAME codes.
    /// </summary>
    [JsonPropertyName("SAME")]
    public List<string>? Same { get; set; }

    /// <summary>
    /// Gets or sets the UGC codes.
    /// </summary>
    [JsonPropertyName("UGC")]
    public List<string>? Ugc { get; set; }
}
