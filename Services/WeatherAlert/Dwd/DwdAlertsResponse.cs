using System.Text.Json.Serialization;
using Xcalibur.Weather.Models.Services.WeatherAlert.Base;

namespace Xcalibur.Weather.Models.Services.WeatherAlert.Dwd;

/// <summary>
/// DWD (Deutscher Wetterdienst) warnings response.
/// Public feed: https://www.dwd.de/DWD/warnungen/warnapp/json/warnings.json
/// </summary>
public class DwdAlertsResponse : BaseAlertsResponse
{
    /// <summary>
    /// Gets or sets the time.
    /// </summary>
    /// <value>
    /// The time.
    /// </value>
    [JsonPropertyName("time")]
    public long? Time { get; set; }


    /// <summary>
    /// Gets or sets the warnings.
    /// </summary>
    /// <value>
    /// The warnings.
    /// </value>
    [JsonPropertyName("warnings")]
    public Dictionary<string, Dictionary<string, DwdWarningResponse>>? Warnings { get; set; }


    /// <summary>
    /// Gets or sets the vorab information.
    /// </summary>
    /// <value>
    /// The vorab information.
    /// </value>
    [JsonPropertyName("vorabInformation")]
    public Dictionary<string, Dictionary<string, DwdWarningResponse>>? VorabInformation { get; set; }
}
