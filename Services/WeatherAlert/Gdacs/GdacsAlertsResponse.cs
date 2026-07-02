using System.Text.Json.Serialization;
using Xcalibur.Weather.Models.Services.WeatherAlert.Base;

namespace Xcalibur.Weather.Models.Services.WeatherAlert.Gdacs;

/// <summary>
/// Top-level response from the GDACS API.
/// </summary>
public class GdacsAlertsResponse : BaseAlertsResponse
{
    /// <summary>
    /// Gets or sets the count of events.
    /// </summary>
    [JsonPropertyName("count")]
    public int? Count { get; set; }

    /// <summary>
    /// Gets or sets the list of events.
    /// </summary>
    [JsonPropertyName("features")]
    public List<GdacsFeatureResponse>? Features { get; set; }
}

