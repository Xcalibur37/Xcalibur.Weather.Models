using System.Text.RegularExpressions;

namespace Xcalibur.Weather.Models.Implementation.WeatherAlerts;

/// <summary>
/// Helper class for mapping weather alert string values to normalized enums.
/// </summary>
public static class AlertMapper
{
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

        return urgency.Trim().ToUpperInvariant() switch
        {
            var u when u.Contains("IMMEDIATE") => AlertUrgency.Immediate,
            var u when u.Contains("EXPECTED") => AlertUrgency.Expected,
            var u when u.Contains("FUTURE") => AlertUrgency.Future,
            var u when u.Contains("PAST") => AlertUrgency.Past,
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

        return severity.Trim().ToUpperInvariant() switch
        {
            "EXTREME" => AlertSeverity.Extreme,
            "SEVERE" => AlertSeverity.Severe,
            "MODERATE" => AlertSeverity.Moderate,
            "MINOR" => AlertSeverity.Minor,
            var s when s.Contains("EXTREME") => AlertSeverity.Extreme,
            var s when s.Contains("SEVERE") => AlertSeverity.Severe,
            var s when s.Contains("MODERATE") => AlertSeverity.Moderate,
            var s when s.Contains("MINOR") => AlertSeverity.Minor,
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
        if (Regex.IsMatch(normalized, @"\btornado\b", RegexOptions.IgnoreCase))
            return AlertEventType.Tornado;

        // Hurricane/Typhoon/Tropical
        if (Regex.IsMatch(normalized, @"\bhurricane\b", RegexOptions.IgnoreCase))
            return AlertEventType.Hurricane;
        if (Regex.IsMatch(normalized, @"\btyphoon\b", RegexOptions.IgnoreCase))
            return AlertEventType.Typhoon;
        if (Regex.IsMatch(normalized, @"\btropical\s*storm\b", RegexOptions.IgnoreCase))
            return AlertEventType.TropicalStorm;

        // Thunderstorm
        if (Regex.IsMatch(normalized, @"\bsevere\s*thunderstorm\b", RegexOptions.IgnoreCase))
            return AlertEventType.SevereThunderstorm;
        if (Regex.IsMatch(normalized, @"\bthunderstorm\b", RegexOptions.IgnoreCase))
            return AlertEventType.Thunderstorm;

        // Hail
        if (Regex.IsMatch(normalized, @"\bhail\b", RegexOptions.IgnoreCase))
            return AlertEventType.Hail;

        // Wind
        if (Regex.IsMatch(normalized, @"\b(high|strong|damaging|extreme)\s*wind\b", RegexOptions.IgnoreCase))
            return AlertEventType.HighWind;
        if (Regex.IsMatch(normalized, @"\bgale\b", RegexOptions.IgnoreCase))
            return AlertEventType.Gale;

        // Winter Weather
        if (Regex.IsMatch(normalized, @"\bblizzard\b", RegexOptions.IgnoreCase))
            return AlertEventType.Blizzard;
        if (Regex.IsMatch(normalized, @"\bwinter\s*storm\b", RegexOptions.IgnoreCase))
            return AlertEventType.WinterStorm;
        if (Regex.IsMatch(normalized, @"\b(heavy\s*)?snow(fall)?\b", RegexOptions.IgnoreCase) && !Regex.IsMatch(normalized, @"\bavalanche\b", RegexOptions.IgnoreCase))
            return AlertEventType.Snow;
        if (Regex.IsMatch(normalized, @"\b(ice|freezing|icing)\b", RegexOptions.IgnoreCase))
            return AlertEventType.Ice;
        if (Regex.IsMatch(normalized, @"\b(frost|freeze)\b", RegexOptions.IgnoreCase))
            return AlertEventType.Frost;
        if (Regex.IsMatch(normalized, @"\bavalanche\b", RegexOptions.IgnoreCase))
            return AlertEventType.Avalanche;

        // Temperature
        if (Regex.IsMatch(normalized, @"\b(excessive|extreme)\s*heat\b", RegexOptions.IgnoreCase))
            return AlertEventType.ExcessiveHeat;
        if (Regex.IsMatch(normalized, @"\bheat(\s*wave)?\b", RegexOptions.IgnoreCase))
            return AlertEventType.Heat;
        if (Regex.IsMatch(normalized, @"\b(extreme|excessive)\s*cold\b", RegexOptions.IgnoreCase))
            return AlertEventType.ExtremeCold;

        // Flood
        if (Regex.IsMatch(normalized, @"\bflash\s*flood\b", RegexOptions.IgnoreCase))
            return AlertEventType.FlashFlood;
        if (Regex.IsMatch(normalized, @"\bcoastal\s*flood\b", RegexOptions.IgnoreCase))
            return AlertEventType.CoastalFlood;
        if (Regex.IsMatch(normalized, @"\bflood\b", RegexOptions.IgnoreCase))
            return AlertEventType.Flood;
        if (Regex.IsMatch(normalized, @"\btsunami\b", RegexOptions.IgnoreCase))
            return AlertEventType.Tsunami;
        if (Regex.IsMatch(normalized, @"\bstorm\s*surge\b", RegexOptions.IgnoreCase))
            return AlertEventType.StormSurge;
        if (Regex.IsMatch(normalized, @"\bhigh\s*water\b", RegexOptions.IgnoreCase))
            return AlertEventType.HighWater;

        // Rain
        if (Regex.IsMatch(normalized, @"\b(heavy|torrential)\s*rain\b", RegexOptions.IgnoreCase))
            return AlertEventType.Rain;

        // Marine
        if (Regex.IsMatch(normalized, @"\bhigh\s*surf\b", RegexOptions.IgnoreCase))
            return AlertEventType.HighSurf;
        if (Regex.IsMatch(normalized, @"\brip\s*current\b", RegexOptions.IgnoreCase))
            return AlertEventType.RipCurrent;
        if (Regex.IsMatch(normalized, @"\bsmall\s*craft\b", RegexOptions.IgnoreCase))
            return AlertEventType.SmallCraft;

        // Fire
        if (Regex.IsMatch(normalized, @"\bred\s*flag\b", RegexOptions.IgnoreCase))
            return AlertEventType.RedFlag;
        if (Regex.IsMatch(normalized, @"\b(wild)?fire\b", RegexOptions.IgnoreCase))
            return AlertEventType.Fire;

        // Air Quality
        if (Regex.IsMatch(normalized, @"\bair\s*quality\b", RegexOptions.IgnoreCase))
            return AlertEventType.AirQuality;
        if (Regex.IsMatch(normalized, @"\bsmoke\b", RegexOptions.IgnoreCase))
            return AlertEventType.Smoke;
        if (Regex.IsMatch(normalized, @"\bdust\s*storm\b", RegexOptions.IgnoreCase))
            return AlertEventType.DustStorm;
        if (Regex.IsMatch(normalized, @"\bfog\b", RegexOptions.IgnoreCase))
            return AlertEventType.Fog;

        // Geophysical
        if (Regex.IsMatch(normalized, @"\bearthquake\b", RegexOptions.IgnoreCase))
            return AlertEventType.Earthquake;
        if (Regex.IsMatch(normalized, @"\bvolcan(o|ic)\b", RegexOptions.IgnoreCase))
            return AlertEventType.Volcano;
        if (Regex.IsMatch(normalized, @"\b(land|mud)slide\b", RegexOptions.IgnoreCase))
            return AlertEventType.Landslide;

        // Special
        if (Regex.IsMatch(normalized, @"\bspecial\s*weather\s*statement\b", RegexOptions.IgnoreCase))
            return AlertEventType.SpecialWeatherStatement;
        if (Regex.IsMatch(normalized, @"\bcivil\s*emergency\b", RegexOptions.IgnoreCase))
            return AlertEventType.CivilEmergency;
        if (Regex.IsMatch(normalized, @"\bhazardous\s*materials\b", RegexOptions.IgnoreCase))
            return AlertEventType.HazardousMaterials;
        if (Regex.IsMatch(normalized, @"\bnuclear\s*power\s*plant\b", RegexOptions.IgnoreCase))
            return AlertEventType.NuclearPowerPlant;

        return AlertEventType.Other;
    }

    /// <summary>
    /// Normalizes an event string for consistent matching.
    /// </summary>
    private static string NormalizeEventString(string eventType)
    {
        // Remove extra whitespace and common punctuation
        var normalized = Regex.Replace(eventType, @"\s+", " ").Trim();

        // Remove common suffixes
        normalized = Regex.Replace(normalized, @"\b(warning|watch|advisory|statement|alert)\b", "", RegexOptions.IgnoreCase);

        return normalized.Trim();
    }

    #endregion
}
