using System.ComponentModel;

namespace Xcalibur.Weather.Models.Implementation.WeatherAlerts;

/// <summary>
/// Normalized urgency levels for weather alerts based on CAP (Common Alerting Protocol) standard.
/// </summary>
public enum AlertUrgency
{
    /// <summary>
    /// Unknown or unspecified urgency.
    /// </summary>
    [Description("Unknown or unspecified urgency")]
    Unknown = 0,

    /// <summary>
    /// Responsive action should be taken immediately.
    /// </summary>
    [Description("Responsive action should be taken immediately")]
    Immediate = 1,

    /// <summary>
    /// Responsive action should be taken soon (within next hour).
    /// </summary>
    [Description("Responsive action should be taken soon (within next hour)")]
    Expected = 2,

    /// <summary>
    /// Responsive action should be taken in the near future.
    /// </summary>
    [Description("Responsive action should be taken in the near future")]
    Future = 3,

    /// <summary>
    /// Responsive action is no longer required.
    /// </summary>
    [Description("Responsive action is no longer required")]
    Past = 4
}
