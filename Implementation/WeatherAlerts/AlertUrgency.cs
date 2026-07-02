namespace Xcalibur.Weather.Models.Implementation.WeatherAlerts;

/// <summary>
/// Normalized urgency levels for weather alerts based on CAP (Common Alerting Protocol) standard.
/// </summary>
public enum AlertUrgency
{
    /// <summary>
    /// Unknown or unspecified urgency.
    /// </summary>
    Unknown = 0,

    /// <summary>
    /// Responsive action should be taken immediately.
    /// </summary>
    Immediate = 1,

    /// <summary>
    /// Responsive action should be taken soon (within next hour).
    /// </summary>
    Expected = 2,

    /// <summary>
    /// Responsive action should be taken in the near future.
    /// </summary>
    Future = 3,

    /// <summary>
    /// Responsive action is no longer required.
    /// </summary>
    Past = 4
}
