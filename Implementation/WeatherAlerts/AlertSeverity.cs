namespace Xcalibur.Weather.Models.Implementation.WeatherAlerts;

/// <summary>
/// Normalized severity levels for weather alerts based on CAP (Common Alerting Protocol) standard.
/// </summary>
public enum AlertSeverity
{
    /// <summary>
    /// Unknown or unspecified severity.
    /// </summary>
    Unknown = 0,

    /// <summary>
    /// Minimal to no known threat to life or property.
    /// </summary>
    Minor = 1,

    /// <summary>
    /// Possible threat to life or property.
    /// </summary>
    Moderate = 2,

    /// <summary>
    /// Significant threat to life or property.
    /// </summary>
    Severe = 3,

    /// <summary>
    /// Extraordinary threat to life or property.
    /// </summary>
    Extreme = 4
}
