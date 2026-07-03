using System.ComponentModel;

namespace Xcalibur.Weather.Models.Implementation.WeatherAlerts;

/// <summary>
/// Normalized severity levels for weather alerts based on CAP (Common Alerting Protocol) standard.
/// </summary>
public enum AlertSeverity
{
    /// <summary>
    /// Unknown or unspecified severity.
    /// </summary>
    [Description("Unknown or unspecified severity")]
    Unknown = 0,

    /// <summary>
    /// Minimal to no known threat to life or property.
    /// </summary>
    [Description("Minimal to no known threat to life or property")]
    Minor = 1,

    /// <summary>
    /// Possible threat to life or property.
    /// </summary>
    [Description("Possible threat to life or property")]
    Moderate = 2,

    /// <summary>
    /// Significant threat to life or property.
    /// </summary>
    [Description("Significant threat to life or property")]
    Severe = 3,

    /// <summary>
    /// Extraordinary threat to life or property.
    /// </summary>
    [Description("Extraordinary threat to life or property")]
    Extreme = 4
}
