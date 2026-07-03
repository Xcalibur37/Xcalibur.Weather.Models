using System.ComponentModel;

namespace Xcalibur.Weather.Models.Implementation.WeatherAlerts;

/// <summary>
/// Normalized certainty levels for weather alerts based on CAP (Common Alerting Protocol) standard.
/// </summary>
public enum AlertCertainty
{
    /// <summary>
    /// Unknown or unspecified certainty.
    /// </summary>
    [Description("Unknown or unspecified certainty")]
    Unknown = 0,

    /// <summary>
    /// Determined to have occurred or to be ongoing.
    /// </summary>
    [Description("Determined to have occurred or to be ongoing")]
    Observed = 1,

    /// <summary>
    /// Likely (probability greater than ~50%).
    /// </summary>
    [Description("Likely (probability greater than ~50%)")]
    Likely = 2,

    /// <summary>
    /// Possible but not likely (probability less than ~50%).
    /// </summary>
    [Description("Possible but not likely (probability less than ~50%)")]
    Possible = 3,

    /// <summary>
    /// Not expected to occur (probability near zero).
    /// </summary>
    [Description("Not expected to occur (probability near zero)")]
    Unlikely = 4
}
