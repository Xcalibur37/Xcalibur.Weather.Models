namespace Xcalibur.Weather.Models.Implementation.WeatherAlerts;

/// <summary>
/// Normalized category types for weather alerts based on CAP (Common Alerting Protocol) standard.
/// </summary>
public enum AlertCategory
{
    /// <summary>
    /// Unknown or unspecified category.
    /// </summary>
    Unknown = 0,

    /// <summary>
    /// Meteorological (weather-related) alerts.
    /// </summary>
    Met = 1,

    /// <summary>
    /// Geophysical (earthquake, tsunami, volcanic activity, etc.).
    /// </summary>
    Geo = 2,

    /// <summary>
    /// General emergency and public safety.
    /// </summary>
    Safety = 3,

    /// <summary>
    /// Law enforcement, military, homeland and local/private security.
    /// </summary>
    Security = 4,

    /// <summary>
    /// Rescue and recovery.
    /// </summary>
    Rescue = 5,

    /// <summary>
    /// Fire suppression and rescue.
    /// </summary>
    Fire = 6,

    /// <summary>
    /// Medical and public health.
    /// </summary>
    Health = 7,

    /// <summary>
    /// Pollution and other environmental.
    /// </summary>
    Env = 8,

    /// <summary>
    /// Public and private transportation.
    /// </summary>
    Transport = 9,

    /// <summary>
    /// Utility, telecommunication, other non-transport infrastructure.
    /// </summary>
    Infra = 10,

    /// <summary>
    /// Chemical, Biological, Radiological, Nuclear or High-Yield Explosive threat or attack.
    /// </summary>
    CBRNE = 11,

    /// <summary>
    /// Other events.
    /// </summary>
    Other = 12
}
