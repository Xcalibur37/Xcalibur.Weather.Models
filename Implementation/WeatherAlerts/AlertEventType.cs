using System.ComponentModel;

namespace Xcalibur.Weather.Models.Implementation.WeatherAlerts;

/// <summary>
/// Normalized event types for weather alerts.
/// Based on common event types from NWS, Environment Canada, Meteoalarm, and other services.
/// </summary>
public enum AlertEventType
{
    /// <summary>
    /// Unknown or unspecified event type.
    /// </summary>
    [Description("Unknown or unspecified event type")]
    Unknown = 0,

    // Severe Weather Events
    /// <summary>
    /// Tornado warning or watch.
    /// </summary>
    [Description("Tornado warning or watch")]
    Tornado = 100,

    /// <summary>
    /// Severe thunderstorm.
    /// </summary>
    [Description("Severe thunderstorm")]
    SevereThunderstorm = 101,

    /// <summary>
    /// Thunderstorm with lightning.
    /// </summary>
    [Description("Thunderstorm with lightning")]
    Thunderstorm = 102,

    /// <summary>
    /// Hail storm.
    /// </summary>
    [Description("Hail storm")]
    Hail = 103,

    /// <summary>
    /// Strong or damaging winds.
    /// </summary>
    [Description("Strong or damaging winds")]
    HighWind = 104,

    /// <summary>
    /// Hurricane or tropical cyclone.
    /// </summary>
    [Description("Hurricane or tropical cyclone")]  
    Hurricane = 105,

    /// <summary>
    /// Tropical storm.
    /// </summary>
    [Description("Tropical storm")]
    TropicalStorm = 106,

    /// <summary>
    /// Typhoon (Pacific hurricane).
    /// </summary>
    [Description("Typhoon (Pacific hurricane)")]
    Typhoon = 107,

    // Winter Weather Events
    /// <summary>
    /// Blizzard conditions.
    /// </summary>
    [Description("Blizzard conditions")]
    Blizzard = 200,

    /// <summary>
    /// Winter storm.
    /// </summary>
    [Description("Winter storm")]
    WinterStorm = 201,

    /// <summary>
    /// Heavy snow.
    /// </summary>
    [Description("Heavy snow")]
    Snow = 202,

    /// <summary>
    /// Ice storm or freezing conditions.
    /// </summary>
    [Description("Ice storm or freezing conditions")]
    Ice = 203,

    /// <summary>
    /// Frost or freeze warning.
    /// </summary>
    [Description("Frost or freeze warning")]
    Frost = 204,

    /// <summary>
    /// Avalanche warning.
    /// </summary>
    [Description("Avalanche warning")]
    Avalanche = 205,

    // Temperature Extremes
    /// <summary>
    /// Excessive heat.
    /// </summary>
    [Description("Excessive heat")]
    ExcessiveHeat = 300,

    /// <summary>
    /// Heat wave or high temperature.
    /// </summary>
    [Description("Heat wave or high temperature")]
    Heat = 301,

    /// <summary>
    /// Extreme cold or wind chill.
    /// </summary>
    [Description("Extreme cold or wind chill")]
    ExtremeCold = 302,

    // Water-Related Events
    /// <summary>
    /// Flood warning.
    /// </summary>
    [Description("Flood warning")]
    Flood = 400,

    /// <summary>
    /// Flash flood.
    /// </summary>
    [Description("Flash flood")]
    FlashFlood = 401,

    /// <summary>
    /// Coastal flood.
    /// </summary>
    [Description("Coastal flood")]
    CoastalFlood = 402,

    /// <summary>
    /// Heavy rain.
    /// </summary>
    [Description("Heavy rain")]
    Rain = 403,

    /// <summary>
    /// Tsunami warning.
    /// </summary>
    [Description("Tsunami warning")]
    Tsunami = 404,

    /// <summary>
    /// Storm surge.
    /// </summary>
    [Description("Storm surge")]
    StormSurge = 405,

    /// <summary>
    /// High water or river flooding.
    /// </summary>
    [Description("High water or river flooding")]
    HighWater = 406,

    // Marine/Coastal Events
    /// <summary>
    /// High surf or dangerous waves.
    /// </summary>
    [Description("High surf or dangerous waves")]
    HighSurf = 500,

    /// <summary>
    /// Rip current warning.
    /// </summary>
    [Description("Rip current warning")]
    RipCurrent = 501,

    /// <summary>
    /// Small craft advisory.
    /// </summary>
    [Description("Small craft advisory")]
    SmallCraft = 502,

    /// <summary>
    /// Gale warning.
    /// </summary>
    [Description("Gale warning")]
    Gale = 503,

    // Fire Weather Events
    /// <summary>
    /// Wildfire or forest fire.
    /// </summary>
    [Description("Wildfire or forest fire")]
    Fire = 600,

    /// <summary>
    /// Red flag warning (fire weather).
    /// </summary>
    [Description("Red flag warning (fire weather)")]
    RedFlag = 601,

    // Air Quality Events
    /// <summary>
    /// Poor air quality.
    /// </summary>
    [Description("Poor air quality")]
    AirQuality = 700,

    /// <summary>
    /// Smoke advisory.
    /// </summary>
    [Description("Smoke advisory")]
    Smoke = 701,

    /// <summary>
    /// Dust storm.
    /// </summary>
    [Description("Dust storm")]
    DustStorm = 702,

    /// <summary>
    /// Fog advisory.
    /// </summary>
    [Description("Fog advisory")]
    Fog = 703,

    // Geophysical Events
    /// <summary>
    /// Earthquake.
    /// </summary>
    [Description("Earthquake")]
    Earthquake = 800,

    /// <summary>
    /// Volcanic activity.
    /// </summary>
    [Description("Volcanic activity")]
    Volcano = 801,

    /// <summary>
    /// Landslide or mudslide.
    /// </summary>
    [Description("Landslide or mudslide")]
    Landslide = 802,

    // Other Events
    /// <summary>
    /// Special weather statement.
    /// </summary>
    [Description("Special weather statement")]
    SpecialWeatherStatement = 900,

    /// <summary>
    /// Civil emergency or disaster.
    /// </summary>
    [Description("Civil emergency or disaster")]
    CivilEmergency = 901,

    /// <summary>
    /// Hazardous materials incident.
    /// </summary>
    [Description("Hazardous materials incident")]   
    HazardousMaterials = 902,

    /// <summary>
    /// Nuclear power plant warning.
    /// </summary>
    [Description("Nuclear power plant warning")]
    NuclearPowerPlant = 903,

    /// <summary>
    /// Other event type not covered by standard categories.
    /// </summary>
    [Description("Other event type not covered by standard categories")]
    Other = 999
}
