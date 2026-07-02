namespace Xcalibur.Weather.Models.Implementation.WeatherAlerts;

/// <summary>
/// Normalized certainty levels for weather alerts based on CAP (Common Alerting Protocol) standard.
/// </summary>
public enum AlertCertainty
{
    /// <summary>
    /// Unknown or unspecified certainty.
    /// </summary>
    Unknown = 0,

    /// <summary>
    /// Determined to have occurred or to be ongoing.
    /// </summary>
    Observed = 1,

    /// <summary>
    /// Likely (probability greater than ~50%).
    /// </summary>
    Likely = 2,

    /// <summary>
    /// Possible but not likely (probability less than ~50%).
    /// </summary>
    Possible = 3,

    /// <summary>
    /// Not expected to occur (probability near zero).
    /// </summary>
    Unlikely = 4
}
