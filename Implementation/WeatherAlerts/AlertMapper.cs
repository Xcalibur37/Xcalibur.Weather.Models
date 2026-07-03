using System.Text.RegularExpressions;

namespace Xcalibur.Weather.Models.Implementation.WeatherAlerts;

/// <summary>
/// Helper class for mapping weather alert string values to normalized enums.
/// </summary>
public static partial class AlertMapper
{
    #region Compiled Regex Patterns

    // Event Type Patterns
    [GeneratedRegex(@"\btornado\b", RegexOptions.IgnoreCase | RegexOptions.Compiled)]
    private static partial Regex TornadoPattern();

    [GeneratedRegex(@"\bhurricane\b", RegexOptions.IgnoreCase | RegexOptions.Compiled)]
    private static partial Regex HurricanePattern();

    [GeneratedRegex(@"\btyphoon\b", RegexOptions.IgnoreCase | RegexOptions.Compiled)]
    private static partial Regex TyphoonPattern();

    [GeneratedRegex(@"\btropical\s*storm\b", RegexOptions.IgnoreCase | RegexOptions.Compiled)]
    private static partial Regex TropicalStormPattern();

    [GeneratedRegex(@"\bsevere\s*thunderstorm\b", RegexOptions.IgnoreCase | RegexOptions.Compiled)]
    private static partial Regex SevereThunderstormPattern();

    [GeneratedRegex(@"\bthunderstorm\b", RegexOptions.IgnoreCase | RegexOptions.Compiled)]
    private static partial Regex ThunderstormPattern();

    [GeneratedRegex(@"\bhail\b", RegexOptions.IgnoreCase | RegexOptions.Compiled)]
    private static partial Regex HailPattern();

    [GeneratedRegex(@"\b(high|strong|damaging|extreme)\s*wind\b", RegexOptions.IgnoreCase | RegexOptions.Compiled)]
    private static partial Regex HighWindPattern();

    [GeneratedRegex(@"\bgale\b", RegexOptions.IgnoreCase | RegexOptions.Compiled)]
    private static partial Regex GalePattern();

    [GeneratedRegex(@"\bblizzard\b", RegexOptions.IgnoreCase | RegexOptions.Compiled)]
    private static partial Regex BlizzardPattern();

    [GeneratedRegex(@"\bwinter\s*storm\b", RegexOptions.IgnoreCase | RegexOptions.Compiled)]
    private static partial Regex WinterStormPattern();

    [GeneratedRegex(@"\b(heavy\s*)?snow(fall)?\b", RegexOptions.IgnoreCase | RegexOptions.Compiled)]
    private static partial Regex SnowPattern();

    [GeneratedRegex(@"\bavalanche\b", RegexOptions.IgnoreCase | RegexOptions.Compiled)]
    private static partial Regex AvalanchePattern();

    [GeneratedRegex(@"\b(ice|freezing|icing)\b", RegexOptions.IgnoreCase | RegexOptions.Compiled)]
    private static partial Regex IcePattern();

    [GeneratedRegex(@"\b(frost|freeze)\b", RegexOptions.IgnoreCase | RegexOptions.Compiled)]
    private static partial Regex FrostPattern();

    [GeneratedRegex(@"\b(excessive|extreme)\s*heat\b", RegexOptions.IgnoreCase | RegexOptions.Compiled)]
    private static partial Regex ExcessiveHeatPattern();

    [GeneratedRegex(@"\bheat(\s*wave)?\b", RegexOptions.IgnoreCase | RegexOptions.Compiled)]
    private static partial Regex HeatPattern();

    [GeneratedRegex(@"\b(extreme|excessive)\s*cold\b", RegexOptions.IgnoreCase | RegexOptions.Compiled)]
    private static partial Regex ExtremeColdPattern();

    [GeneratedRegex(@"\bflash\s*flood\b", RegexOptions.IgnoreCase | RegexOptions.Compiled)]
    private static partial Regex FlashFloodPattern();

    [GeneratedRegex(@"\bcoastal\s*flood\b", RegexOptions.IgnoreCase | RegexOptions.Compiled)]
    private static partial Regex CoastalFloodPattern();

    [GeneratedRegex(@"\bflood\b", RegexOptions.IgnoreCase | RegexOptions.Compiled)]
    private static partial Regex FloodPattern();

    [GeneratedRegex(@"\btsunami\b", RegexOptions.IgnoreCase | RegexOptions.Compiled)]
    private static partial Regex TsunamiPattern();

    [GeneratedRegex(@"\bstorm\s*surge\b", RegexOptions.IgnoreCase | RegexOptions.Compiled)]
    private static partial Regex StormSurgePattern();

    [GeneratedRegex(@"\bhigh\s*water\b", RegexOptions.IgnoreCase | RegexOptions.Compiled)]
    private static partial Regex HighWaterPattern();

    [GeneratedRegex(@"\b(heavy|torrential)\s*rain\b", RegexOptions.IgnoreCase | RegexOptions.Compiled)]
    private static partial Regex RainPattern();

    [GeneratedRegex(@"\bhigh\s*surf\b", RegexOptions.IgnoreCase | RegexOptions.Compiled)]
    private static partial Regex HighSurfPattern();

    [GeneratedRegex(@"\brip\s*current\b", RegexOptions.IgnoreCase | RegexOptions.Compiled)]
    private static partial Regex RipCurrentPattern();

    [GeneratedRegex(@"\bsmall\s*craft\b", RegexOptions.IgnoreCase | RegexOptions.Compiled)]
    private static partial Regex SmallCraftPattern();

    [GeneratedRegex(@"\bred\s*flag\b", RegexOptions.IgnoreCase | RegexOptions.Compiled)]
    private static partial Regex RedFlagPattern();

    [GeneratedRegex(@"\b(wild)?fire\b", RegexOptions.IgnoreCase | RegexOptions.Compiled)]
    private static partial Regex FirePattern();

    [GeneratedRegex(@"\bair\s*quality\b", RegexOptions.IgnoreCase | RegexOptions.Compiled)]
    private static partial Regex AirQualityPattern();

    [GeneratedRegex(@"\bsmoke\b", RegexOptions.IgnoreCase | RegexOptions.Compiled)]
    private static partial Regex SmokePattern();

    [GeneratedRegex(@"\bdust\s*storm\b", RegexOptions.IgnoreCase | RegexOptions.Compiled)]
    private static partial Regex DustStormPattern();

    [GeneratedRegex(@"\bfog\b", RegexOptions.IgnoreCase | RegexOptions.Compiled)]
    private static partial Regex FogPattern();

    [GeneratedRegex(@"\bearthquake\b", RegexOptions.IgnoreCase | RegexOptions.Compiled)]
    private static partial Regex EarthquakePattern();

    [GeneratedRegex(@"\bvolcan(o|ic)\b", RegexOptions.IgnoreCase | RegexOptions.Compiled)]
    private static partial Regex VolcanoPattern();

    [GeneratedRegex(@"\b(land|mud)slide\b", RegexOptions.IgnoreCase | RegexOptions.Compiled)]
    private static partial Regex LandslidePattern();

    [GeneratedRegex(@"\bspecial\s*weather\s*statement\b", RegexOptions.IgnoreCase | RegexOptions.Compiled)]
    private static partial Regex SpecialWeatherStatementPattern();

    [GeneratedRegex(@"\bcivil\s*emergency\b", RegexOptions.IgnoreCase | RegexOptions.Compiled)]
    private static partial Regex CivilEmergencyPattern();

    [GeneratedRegex(@"\bhazardous\s*materials\b", RegexOptions.IgnoreCase | RegexOptions.Compiled)]
    private static partial Regex HazardousMaterialsPattern();

    [GeneratedRegex(@"\bnuclear\s*power\s*plant\b", RegexOptions.IgnoreCase | RegexOptions.Compiled)]
    private static partial Regex NuclearPowerPlantPattern();

    // Normalization Patterns
    [GeneratedRegex(@"\s+", RegexOptions.Compiled)]
    private static partial Regex WhitespacePattern();

    [GeneratedRegex(@"\b(warning|watch|advisory|statement|alert)\b", RegexOptions.IgnoreCase | RegexOptions.Compiled)]
    private static partial Regex CommonSuffixPattern();

    #endregion
    #region Urgency Mapping

    /// <summary>
    /// Maps an urgency string to the normalized AlertUrgency enum.
    /// </summary>
    /// <param name="urgency">The urgency string from any service.</param>
    /// <returns>The normalized AlertUrgency enum value.</returns>
    public static AlertUrgency MapUrgency(string? urgency)
    {
        if (string.IsNullOrWhiteSpace(urgency))
            return AlertUrgency.Unknown;

        // Normalize the urgency string for consistent matching
        return urgency.Trim().ToUpperInvariant() switch
        {
            "IMMEDIATE" => AlertUrgency.Immediate,
            "EXPECTED" => AlertUrgency.Expected,
            "FUTURE" => AlertUrgency.Future,
            "PAST" => AlertUrgency.Past,
            _ => AlertUrgency.Unknown
        };
    }

    #endregion

    #region Certainty Mapping

    /// <summary>
    /// Maps a certainty string to the normalized AlertCertainty enum.
    /// </summary>
    /// <param name="certainty">The certainty string from any service.</param>
    /// <returns>The normalized AlertCertainty enum value.</returns>
    public static AlertCertainty MapCertainty(string? certainty)
    {
        if (string.IsNullOrWhiteSpace(certainty))
            return AlertCertainty.Unknown;

        // Normalize the certainty string for consistent matching
        return certainty.Trim().ToUpperInvariant() switch
        {
            "OBSERVED" => AlertCertainty.Observed,
            "LIKELY" => AlertCertainty.Likely,
            "POSSIBLE" => AlertCertainty.Possible,
            "UNLIKELY" => AlertCertainty.Unlikely,
            _ => AlertCertainty.Unknown
        };
    }

    #endregion

    #region Category Mapping

    /// <summary>
    /// Maps a category string to the normalized AlertCategory enum.
    /// </summary>
    /// <param name="category">The category string from any service.</param>
    /// <returns>The normalized AlertCategory enum value.</returns>
    public static AlertCategory MapCategory(string? category)
    {
        if (string.IsNullOrWhiteSpace(category))
            return AlertCategory.Unknown;

        // Normalize the category string for consistent matching
        return category.Trim().ToUpperInvariant() switch
        {
            "MET" => AlertCategory.Met,
            "GEO" => AlertCategory.Geo,
            "SAFETY" => AlertCategory.Safety,
            "SECURITY" => AlertCategory.Security,
            "RESCUE" => AlertCategory.Rescue,
            "FIRE" => AlertCategory.Fire,
            "HEALTH" => AlertCategory.Health,
            "ENV" => AlertCategory.Env,
            "TRANSPORT" => AlertCategory.Transport,
            "INFRA" => AlertCategory.Infra,
            "CBRNE" => AlertCategory.CBRNE,
            "OTHER" => AlertCategory.Other,
            var c when c.Contains("WEATHER") || c.Contains("METEOROLOG") => AlertCategory.Met,
            var c when c.Contains("EARTHQUAKE") || c.Contains("SEISMIC") || c.Contains("TSUNAMI") || c.Contains("VOLCANIC") => AlertCategory.Geo,
            var c when c.Contains("FIRE") => AlertCategory.Fire,
            var c when c.Contains("ENVIRONMENT") || c.Contains("POLLUTION") => AlertCategory.Env,
            _ => AlertCategory.Other
        };
    }

    #endregion

    #region Severity Mapping

    /// <summary>
    /// Maps a severity string to the normalized AlertSeverity enum.
    /// </summary>
    /// <param name="severity">The severity string from any service.</param>
    /// <returns>The normalized AlertSeverity enum value.</returns>
    public static AlertSeverity MapSeverity(string? severity)
    {
        if (string.IsNullOrWhiteSpace(severity))
            return AlertSeverity.Unknown;

        // Normalize the severity string for consistent matching
        return severity.Trim().ToUpperInvariant() switch
        {
            "EXTREME" => AlertSeverity.Extreme,
            "SEVERE" => AlertSeverity.Severe,
            "MODERATE" => AlertSeverity.Moderate,
            "MINOR" => AlertSeverity.Minor,
            _ => AlertSeverity.Unknown
        };
    }

    #endregion

    #region Event Type Mapping

    /// <summary>
    /// Maps an event string to the normalized AlertEventType enum.
    /// </summary>
    /// <param name="eventType">The event type string from any service.</param>
    /// <returns>The normalized AlertEventType enum value.</returns>
    public static AlertEventType MapEventType(string? eventType)
    {
        if (string.IsNullOrWhiteSpace(eventType))
            return AlertEventType.Unknown;

        var normalized = NormalizeEventString(eventType);

        // Tornado
        if (TornadoPattern().IsMatch(normalized))
            return AlertEventType.Tornado;

        // Hurricane/Typhoon/Tropical
        if (HurricanePattern().IsMatch(normalized))
            return AlertEventType.Hurricane;
        if (TyphoonPattern().IsMatch(normalized))
            return AlertEventType.Typhoon;
        if (TropicalStormPattern().IsMatch(normalized))
            return AlertEventType.TropicalStorm;

        // Thunderstorm
        if (SevereThunderstormPattern().IsMatch(normalized))
            return AlertEventType.SevereThunderstorm;
        if (ThunderstormPattern().IsMatch(normalized))
            return AlertEventType.Thunderstorm;

        // Hail
        if (HailPattern().IsMatch(normalized))
            return AlertEventType.Hail;

        // Wind
        if (HighWindPattern().IsMatch(normalized))
            return AlertEventType.HighWind;
        if (GalePattern().IsMatch(normalized))
            return AlertEventType.Gale;

        // Winter Weather
        if (BlizzardPattern().IsMatch(normalized))
            return AlertEventType.Blizzard;
        if (WinterStormPattern().IsMatch(normalized))
            return AlertEventType.WinterStorm;
        if (SnowPattern().IsMatch(normalized) && !AvalanchePattern().IsMatch(normalized))
            return AlertEventType.Snow;
        if (IcePattern().IsMatch(normalized))
            return AlertEventType.Ice;
        if (FrostPattern().IsMatch(normalized))
            return AlertEventType.Frost;
        if (AvalanchePattern().IsMatch(normalized))
            return AlertEventType.Avalanche;

        // Temperature
        if (ExcessiveHeatPattern().IsMatch(normalized))
            return AlertEventType.ExcessiveHeat;
        if (HeatPattern().IsMatch(normalized))
            return AlertEventType.Heat;
        if (ExtremeColdPattern().IsMatch(normalized))
            return AlertEventType.ExtremeCold;

        // Flood
        if (FlashFloodPattern().IsMatch(normalized))
            return AlertEventType.FlashFlood;
        if (CoastalFloodPattern().IsMatch(normalized))
            return AlertEventType.CoastalFlood;
        if (FloodPattern().IsMatch(normalized))
            return AlertEventType.Flood;
        if (TsunamiPattern().IsMatch(normalized))
            return AlertEventType.Tsunami;
        if (StormSurgePattern().IsMatch(normalized))
            return AlertEventType.StormSurge;
        if (HighWaterPattern().IsMatch(normalized))
            return AlertEventType.HighWater;

        // Rain
        if (RainPattern().IsMatch(normalized))
            return AlertEventType.Rain;

        // Marine
        if (HighSurfPattern().IsMatch(normalized))
            return AlertEventType.HighSurf;
        if (RipCurrentPattern().IsMatch(normalized))
            return AlertEventType.RipCurrent;
        if (SmallCraftPattern().IsMatch(normalized))
            return AlertEventType.SmallCraft;

        // Fire
        if (RedFlagPattern().IsMatch(normalized))
            return AlertEventType.RedFlag;
        if (FirePattern().IsMatch(normalized))
            return AlertEventType.Fire;

        // Air Quality
        if (AirQualityPattern().IsMatch(normalized))
            return AlertEventType.AirQuality;
        if (SmokePattern().IsMatch(normalized))
            return AlertEventType.Smoke;
        if (DustStormPattern().IsMatch(normalized))
            return AlertEventType.DustStorm;
        if (FogPattern().IsMatch(normalized))
            return AlertEventType.Fog;

        // Geophysical
        if (EarthquakePattern().IsMatch(normalized))
            return AlertEventType.Earthquake;
        if (VolcanoPattern().IsMatch(normalized))
            return AlertEventType.Volcano;
        if (LandslidePattern().IsMatch(normalized))
            return AlertEventType.Landslide;

        // Special
        if (SpecialWeatherStatementPattern().IsMatch(normalized))
            return AlertEventType.SpecialWeatherStatement;
        if (CivilEmergencyPattern().IsMatch(normalized))
            return AlertEventType.CivilEmergency;
        if (HazardousMaterialsPattern().IsMatch(normalized))
            return AlertEventType.HazardousMaterials;
        if (NuclearPowerPlantPattern().IsMatch(normalized))
            return AlertEventType.NuclearPowerPlant;

        // If no specific match is found, return Other
        return AlertEventType.Other;
    }

    /// <summary>
    /// Normalizes an event string for consistent matching.
    /// </summary>
    private static string NormalizeEventString(string eventType)
    {
        // Remove extra whitespace and common punctuation
        var normalized = WhitespacePattern().Replace(eventType, " ").Trim();

        // Remove common suffixes
        normalized = CommonSuffixPattern().Replace(normalized, "");

        // Remove any remaining non-alphanumeric characters except spaces
        return normalized.Trim();
    }

    #endregion
}
