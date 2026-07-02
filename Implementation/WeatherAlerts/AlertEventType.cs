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
    Unknown = 0,

    // Severe Weather Events
    /// <summary>
    /// Tornado warning or watch.
    /// </summary>
    Tornado = 100,

    /// <summary>
    /// Severe thunderstorm.
    /// </summary>
    SevereThunderstorm = 101,

    /// <summary>
    /// Thunderstorm with lightning.
    /// </summary>
    Thunderstorm = 102,

    /// <summary>
    /// Hail storm.
    /// </summary>
    Hail = 103,

    /// <summary>
    /// Strong or damaging winds.
    /// </summary>
    HighWind = 104,

    /// <summary>
    /// Hurricane or tropical cyclone.
    /// </summary>
    Hurricane = 105,

    /// <summary>
    /// Tropical storm.
    /// </summary>
    TropicalStorm = 106,

    /// <summary>
    /// Typhoon (Pacific hurricane).
    /// </summary>
    Typhoon = 107,

    // Winter Weather Events
    /// <summary>
    /// Blizzard conditions.
    /// </summary>
    Blizzard = 200,

    /// <summary>
    /// Winter storm.
    /// </summary>
    WinterStorm = 201,

    /// <summary>
    /// Heavy snow.
    /// </summary>
    Snow = 202,

    /// <summary>
    /// Ice storm or freezing conditions.
    /// </summary>
    Ice = 203,

    /// <summary>
    /// Frost or freeze warning.
    /// </summary>
    Frost = 204,

    /// <summary>
    /// Avalanche warning.
    /// </summary>
    Avalanche = 205,

    // Temperature Extremes
    /// <summary>
    /// Excessive heat.
    /// </summary>
    ExcessiveHeat = 300,

    /// <summary>
    /// Heat wave or high temperature.
    /// </summary>
    Heat = 301,

    /// <summary>
    /// Extreme cold or wind chill.
    /// </summary>
    ExtremeCold = 302,

    // Water-Related Events
    /// <summary>
    /// Flood warning.
    /// </summary>
    Flood = 400,

    /// <summary>
    /// Flash flood.
    /// </summary>
    FlashFlood = 401,

    /// <summary>
    /// Coastal flood.
    /// </summary>
    CoastalFlood = 402,

    /// <summary>
    /// Heavy rain.
    /// </summary>
    Rain = 403,

    /// <summary>
    /// Tsunami warning.
    /// </summary>
    Tsunami = 404,

    /// <summary>
    /// Storm surge.
    /// </summary>
    StormSurge = 405,

    /// <summary>
    /// High water or river flooding.
    /// </summary>
    HighWater = 406,

    // Marine/Coastal Events
    /// <summary>
    /// High surf or dangerous waves.
    /// </summary>
    HighSurf = 500,

    /// <summary>
    /// Rip current warning.
    /// </summary>
    RipCurrent = 501,

    /// <summary>
    /// Small craft advisory.
    /// </summary>
    SmallCraft = 502,

    /// <summary>
    /// Gale warning.
    /// </summary>
    Gale = 503,

    // Fire Weather Events
    /// <summary>
    /// Wildfire or forest fire.
    /// </summary>
    Fire = 600,

    /// <summary>
    /// Red flag warning (fire weather).
    /// </summary>
    RedFlag = 601,

    // Air Quality Events
    /// <summary>
    /// Poor air quality.
    /// </summary>
    AirQuality = 700,

    /// <summary>
    /// Smoke advisory.
    /// </summary>
    Smoke = 701,

    /// <summary>
    /// Dust storm.
    /// </summary>
    DustStorm = 702,

    /// <summary>
    /// Fog advisory.
    /// </summary>
    Fog = 703,

    // Geophysical Events
    /// <summary>
    /// Earthquake.
    /// </summary>
    Earthquake = 800,

    /// <summary>
    /// Volcanic activity.
    /// </summary>
    Volcano = 801,

    /// <summary>
    /// Landslide or mudslide.
    /// </summary>
    Landslide = 802,

    // Other Events
    /// <summary>
    /// Special weather statement.
    /// </summary>
    SpecialWeatherStatement = 900,

    /// <summary>
    /// Civil emergency or disaster.
    /// </summary>
    CivilEmergency = 901,

    /// <summary>
    /// Hazardous materials incident.
    /// </summary>
    HazardousMaterials = 902,

    /// <summary>
    /// Nuclear power plant warning.
    /// </summary>
    NuclearPowerPlant = 903,

    /// <summary>
    /// Other event type not covered by standard categories.
    /// </summary>
    Other = 999
}
