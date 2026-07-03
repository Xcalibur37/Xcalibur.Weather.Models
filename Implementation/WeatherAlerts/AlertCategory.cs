using System.ComponentModel;

namespace Xcalibur.Weather.Models.Implementation.WeatherAlerts;

/// <summary>
/// Normalized category types for weather alerts based on CAP (Common Alerting Protocol) standard.
/// </summary>
public enum AlertCategory
{
    /// <summary>
    /// Unknown or unspecified category.
    /// </summary>
    [Description("Unknown or unspecified category")]
    Unknown = 0,

    /// <summary>
    /// Meteorological (weather-related) alerts.
    /// </summary>
    [Description("Meteorological (weather-related) alerts")]
    Met = 1,

    /// <summary>
    /// Geophysical (earthquake, tsunami, volcanic activity, etc.).
    /// </summary>
    [Description("Geophysical (earthquake, tsunami, volcanic activity, etc.)")]
    Geo = 2,

    /// <summary>
    /// General emergency and public safety.
    /// </summary>
    [Description("General emergency and public safety")]
    Safety = 3,

    /// <summary>
    /// Law enforcement, military, homeland and local/private security.
    /// </summary>
    [Description("Law enforcement, military, homeland and local/private security")]
    Security = 4,

    /// <summary>
    /// Rescue and recovery.
    /// </summary>
    [Description("Rescue and recovery")]
    Rescue = 5,

    /// <summary>
    /// Fire suppression and rescue.
    /// </summary>
    [Description("Fire suppression and rescue")]
    Fire = 6,

    /// <summary>
    /// Medical and public health.
    /// </summary>
    [Description("Medical and public health")]
    Health = 7,

    /// <summary>
    /// Pollution and other environmental.
    /// </summary>
    [Description("Pollution and other environmental")]
    Env = 8,

    /// <summary>
    /// Public and private transportation.
    /// </summary>
    [Description("Public and private transportation")]
    Transport = 9,

    /// <summary>
    /// Utility, telecommunication, other non-transport infrastructure.
    /// </summary>
    [Description("Utility, telecommunication, other non-transport infrastructure")]
    Infra = 10,

    /// <summary>
    /// Chemical, Biological, Radiological, Nuclear or High-Yield Explosive threat or attack.
    /// </summary>
    [Description("Chemical, Biological, Radiological, Nuclear or High-Yield Explosive threat or attack")]
    CBRNE = 11,

    /// <summary>
    /// Other events.
    /// </summary>
    [Description("Other events")]
    Other = 12
}
