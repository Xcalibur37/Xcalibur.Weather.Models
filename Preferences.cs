using System.ComponentModel;

namespace Xcalibur.Weather.Models;

public enum ThemeSelections
{
    [Description("Dark")]
    Dark,
    [Description("Light")]
    Light
}
public enum TemperatureUnits
{
    [Description("\u00B0F")]
    Fahrenheit,
    [Description("\u00B0C")]
    Celsius
}

public enum SoilMoistureUnits
{
    [Description("%")]
    Percent,
    [Description("index")]
    Index
}

public enum TimeFormatUnits
{
    [Description("12h")]
    TwelveHr,
    [Description("24h")]
    TwentyFourHr 
}

public enum DistanceUnits
{
    [Description("Imperial")]
    Imperial,
    [Description("Metric")]
    Metric
}

public enum BarometerUnits
{
    [Description("inHg")]
    InHg,
    [Description("mmHg")]
    MmHg,
    [Description("hPa")]
    HPa
}

public enum WindSpeedUnits
{
    [Description("mph")]
    Mph,
    [Description("ft/s")]
    FtSec,
    [Description("m/s")]
    MSec,
    [Description("km/h")]
    KmHr,
    [Description("knots")]
    Knots
}