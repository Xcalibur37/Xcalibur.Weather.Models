using System.Text.Json.Serialization;
using Xcalibur.Weather.Models.Services.WeatherAlert.Base;

namespace Xcalibur.Weather.Models.Services.WeatherAlert.Emsc;

/// <summary>
/// European-Mediterranean Seismological Centre (EMSC) earthquake feed response.
/// Public feed: https://www.seismicportal.eu/fdsnws/event/1/query
/// </summary>
public class EmscAlertsResponse : BaseAlertsResponse
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
    /// Gets or sets the features.
    /// </summary>
    /// <value>
    /// The features.
    /// </value>
    [JsonPropertyName("features")]
    public List<EmscFeatureResponse>? Features { get; set; }
}
