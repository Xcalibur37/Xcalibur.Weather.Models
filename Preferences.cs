using System.ComponentModel;

namespace Xcalibur.Weather.Models;

/// <summary>
/// 
/// </summary>
public enum ThemeSelections
{
    /// <summary>
    /// The dark
    /// </summary>
    [Description("Dark")]
    Dark,
    /// <summary>
    /// The light
    /// </summary>
    [Description("Light")]
    Light
}
/// <summary>
/// 
/// </summary>
public enum TemperatureUnits
{
    /// <summary>
    /// The fahrenheit
    /// </summary>
    [Description("\u00B0F")]
    Fahrenheit,
    /// <summary>
    /// The celsius
    /// </summary>
    [Description("\u00B0C")]
    Celsius
}

/// <summary>
/// 
/// </summary>
public enum SoilMoistureUnits
{
    /// <summary>
    /// The percent
    /// </summary>
    [Description("%")]
    Percent,
    /// <summary>
    /// The index
    /// </summary>
    [Description("index")]
    Index
}

/// <summary>
/// 
/// </summary>
public enum TimeFormatUnits
{
    /// <summary>
    /// The twelve hr
    /// </summary>
    [Description("12h")]
    TwelveHr,
    /// <summary>
    /// The twenty four hr
    /// </summary>
    [Description("24h")]
    TwentyFourHr 
}

/// <summary>
/// 
/// </summary>
public enum DistanceUnits
{
    /// <summary>
    /// The imperial
    /// </summary>
    [Description("Imperial")]
    Imperial,
    /// <summary>
    /// The metric
    /// </summary>
    [Description("Metric")]
    Metric
}

/// <summary>
/// 
/// </summary>
public enum BarometerUnits
{
    /// <summary>
    /// The in hg
    /// </summary>
    [Description("inHg")]
    InHg,
    /// <summary>
    /// The mm hg
    /// </summary>
    [Description("mmHg")]
    MmHg,
    /// <summary>
    /// The h pa
    /// </summary>
    [Description("hPa")]
    HPa
}

/// <summary>
/// 
/// </summary>
public enum WindSpeedUnits
{
    /// <summary>
    /// The MPH
    /// </summary>
    [Description("mph")]
    Mph,
    /// <summary>
    /// The ft sec
    /// </summary>
    [Description("ft/s")]
    FtSec,
    /// <summary>
    /// The m sec
    /// </summary>
    [Description("m/s")]
    MSec,
    /// <summary>
    /// The km hr
    /// </summary>
    [Description("km/h")]
    KmHr,
    /// <summary>
    /// The knots
    /// </summary>
    [Description("knots")]
    Knots
}