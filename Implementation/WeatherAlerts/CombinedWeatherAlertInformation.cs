using System.Globalization;
using System.Text.Json.Serialization;
using Xcalibur.Weather.Models.Services.WeatherAlert.Bom;
using Xcalibur.Weather.Models.Services.WeatherAlert.Dwd;
using Xcalibur.Weather.Models.Services.WeatherAlert.Emsc;
using Xcalibur.Weather.Models.Services.WeatherAlert.EnvironmentCanada;
using Xcalibur.Weather.Models.Services.WeatherAlert.Gdacs;
using Xcalibur.Weather.Models.Services.WeatherAlert.Meteoalarm;
using Xcalibur.Weather.Models.Services.WeatherAlert.Nws;

namespace Xcalibur.Weather.Models.Implementation.WeatherAlerts
{
    /// <summary>
    /// Combined weather alert information from multiple sources (Meteoalarm + NWS + GDACS + Environment Canada + BOM + EMSC + DWD).
    /// </summary>
    public class CombinedWeatherAlertInformation
    {
        /// <summary>
        /// Gets or sets the latitude.
        /// </summary>
        public double? Latitude { get; set; }

        /// <summary>
        /// Gets or sets the longitude.
        /// </summary>
        public double? Longitude { get; set; }

        /// <summary>
        /// Gets or sets the country/region code.
        /// </summary>
        public string? RegionCode { get; set; }

        /// <summary>
        /// Gets or sets the combined weather alerts from all sources.
        /// </summary>
        public List<WeatherAlertItem> Alerts { get; set; } = [];

        /// <summary>
        /// Gets or sets the data source name(s).
        /// </summary>
        public List<string> DataSources { get; set; } = [];

        /// <summary>
        /// Gets or sets the last update time.
        /// </summary>
        public DateTime? LastUpdated { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CombinedWeatherAlertInformation" /> class.
        /// </summary>
        [JsonConstructor]
        public CombinedWeatherAlertInformation()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CombinedWeatherAlertInformation" /> class.
        /// </summary>
        /// <param name="meteoalarmData">The Meteoalarm data.</param>
        /// <param name="nwsData">The NWS data.</param>
        /// <param name="gdacsData">The GDACS data.</param>
        /// <param name="environmentCanadaData">The Environment Canada data.</param>
        /// <param name="bomData">The BOM Australia data.</param>
        /// <param name="emscData">The EMSC earthquake data.</param>
        /// <param name="dwdData">The DWD weather warning data.</param>
        /// <param name="latitude">The latitude.</param>
        /// <param name="longitude">The longitude.</param>
        public CombinedWeatherAlertInformation(
            MeteoalarmAlertsResponse? meteoalarmData,
            NwsAlertsResponse? nwsData,
            GdacsAlertsResponse? gdacsData,
            EnvironmentCanadaAlertsResponse? environmentCanadaData,
            BomAlertsResponse? bomData,
            EmscAlertsResponse? emscData,
            DwdAlertsResponse? dwdData,
            string? latitude,
            string? longitude)
        {
            LastUpdated = DateTime.UtcNow;

            // Parse latitude if provided
            if (!string.IsNullOrEmpty(latitude) && double.TryParse(latitude, NumberStyles.Float, CultureInfo.InvariantCulture, out var lat))
            {
                Latitude = lat;
            }

            // Parse longitude if provided
            if (!string.IsNullOrEmpty(longitude) && double.TryParse(longitude, NumberStyles.Float, CultureInfo.InvariantCulture, out var lon))
            {
                Longitude = lon;
            }

            // Map data from each source to the combined alert items
            MapMeteoalarm(meteoalarmData);
            MapNws(nwsData);
            MapGdacs(gdacsData);
            MapEnvironmentCanada(environmentCanadaData);
            MapBom(bomData);
            MapEmsc(emscData);
            MapDwd(dwdData);
        }

        /// <summary>
        /// Maps Meteoalarm data to combined alert items.
        /// </summary>
        /// <param name="data">The Meteoalarm response data.</param>
        private void MapMeteoalarm(MeteoalarmAlertsResponse? data)
        {
            if (data?.Alerts is not { Count: > 0 }) return;

            // Add Meteoalarm as a data source
            DataSources.Add("Meteoalarm");
            RegionCode ??= data.Country;

            // Map each Meteoalarm alert to a WeatherAlertItem
            foreach (var alert in data.Alerts)
            {
                Alerts.Add(new WeatherAlertItem
                {
                    Id = alert.Id,
                    Source = "Meteoalarm",
                    Event = AlertMapper.MapEventType(alert.Event),
                    Headline = alert.Headline,
                    Description = alert.Description,
                    Instruction = alert.Instruction,
                    Severity = string.IsNullOrEmpty(alert.Severity) 
                        ? MapAwarenessLevelToSeverity(alert.AwarenessLevel) 
                        : AlertMapper.MapSeverity(alert.Severity),
                    Certainty = AlertMapper.MapCertainty(alert.Certainty),
                    Urgency = AlertMapper.MapUrgency(alert.Urgency),
                    AreaDescription = alert.Area,
                    SenderName = alert.SenderName,
                    Onset = ParseDateTime(alert.Onset),
                    Expires = ParseDateTime(alert.Expires),
                    Effective = ParseDateTime(alert.Effective)
                });
            }
        }

        /// <summary>
        /// Maps NWS data to combined alert items.
        /// </summary>
        /// <param name="data">The NWS response data.</param>
        private void MapNws(NwsAlertsResponse? data)
        {
            if (data?.Features is not { Count: > 0 }) return;

            // Add NWS as a data source
            DataSources.Add("NWS");

            // Map each NWS alert to a WeatherAlertItem
            foreach (var props in data.Features.Select(x => x.Properties).OfType<NwsAlertPropertiesResponse>())
            {
                // Map the NWS alert properties to a WeatherAlertItem
                Alerts.Add(new WeatherAlertItem
                {
                    Id = props.Id,
                    Source = "NWS",
                    Event = AlertMapper.MapEventType(props.Event),
                    Headline = props.Headline,
                    Description = props.Description,
                    Instruction = props.Instruction,
                    Severity = AlertMapper.MapSeverity(props.Severity),
                    Certainty = AlertMapper.MapCertainty(props.Certainty),
                    Urgency = AlertMapper.MapUrgency(props.Urgency),
                    AreaDescription = props.AreaDesc,
                    SenderName = props.SenderName,
                    Status = props.Status,
                    MessageType = props.MessageType,
                    Category = AlertMapper.MapCategory(props.Category),
                    Onset = ParseDateTime(props.Onset),
                    Expires = ParseDateTime(props.Expires),
                    Effective = ParseDateTime(props.Effective),
                    Ends = ParseDateTime(props.Ends),
                    Sent = ParseDateTime(props.Sent)
                });
            }
        }

        /// <summary>
        /// Maps GDACS data to combined alert items.
        /// </summary>
        /// <param name="data">The GDACS response data.</param>
        private void MapGdacs(GdacsAlertsResponse? data)
        {
            if (data?.Features is not { Count: > 0 }) return;

            // Add GDACS as a data source
            DataSources.Add("GDACS");

            // Map each GDACS feature to a WeatherAlertItem
            foreach (var props in data.Features.Select(x => x.Properties).OfType<GdacsEventResponse>())
            {
                // Map the GDACS feature properties to a WeatherAlertItem
                Alerts.Add(new WeatherAlertItem
                {
                    Id = props.EventId,
                    Source = "GDACS",
                    Event = AlertMapper.MapEventType(props.EventType),
                    Headline = props.EventName,
                    Description = props.Description,
                    Severity = MapGdacsAlertLevelToSeverity(props.AlertLevel),
                    AreaDescription = props.Country,
                    Category = AlertMapper.MapCategory(props.EventType),
                    Onset = ParseDateTime(props.FromDate),
                    Ends = ParseDateTime(props.ToDate)
                });
            }
        }

        /// <summary>
        /// Maps Environment Canada data to combined alert items.
        /// </summary>
        /// <param name="data">The Environment Canada response data.</param>
        private void MapEnvironmentCanada(EnvironmentCanadaAlertsResponse? data)
        {
            if (data?.Entries is not { Count: > 0 }) return;

            // Add Environment Canada as a data source
            DataSources.Add("Environment Canada");

            // Map each Environment Canada entry to a WeatherAlertItem
            foreach (var entry in data.Entries)
            {
                var capInfo = entry.CapAlert?.Info;
                if (capInfo is null) continue;

                // Map the Environment Canada CAP info to a WeatherAlertItem
                Alerts.Add(new WeatherAlertItem
                {
                    Id = entry.CapAlert?.Identifier ?? entry.Id,
                    Source = "Environment Canada",
                    Event = AlertMapper.MapEventType(capInfo.Event),
                    Headline = capInfo.Headline ?? entry.Title,
                    Description = capInfo.Description ?? entry.Summary,
                    Instruction = capInfo.Instruction,
                    Severity = AlertMapper.MapSeverity(capInfo.Severity),
                    Certainty = AlertMapper.MapCertainty(capInfo.Certainty),
                    Urgency = AlertMapper.MapUrgency(capInfo.Urgency),
                    AreaDescription = capInfo.Area?.AreaDesc,
                    SenderName = capInfo.SenderName,
                    Category = AlertMapper.MapCategory(capInfo.Category),
                    Effective = ParseDateTime(capInfo.Effective),
                    Expires = ParseDateTime(capInfo.Expires),
                    Sent = ParseDateTime(entry.CapAlert?.Sent),
                    Status = entry.CapAlert?.Status,
                    MessageType = entry.CapAlert?.MsgType
                });
            }
        }

        /// <summary>
        /// Maps BOM Australia data to combined alert items.
        /// </summary>
        /// <param name="data">The BOM response data.</param>
        private void MapBom(BomAlertsResponse? data)
        {
            if (data?.Warnings is not { Count: > 0 }) return;

            // Add BOM Australia as a data source
            DataSources.Add("BOM Australia");

            // Map each BOM warning to a WeatherAlertItem
            foreach (var warning in data.Warnings)
            {
                // Map the BOM warning properties to a WeatherAlertItem
                Alerts.Add(new WeatherAlertItem
                {
                    Id = warning.Id,
                    Source = "BOM Australia",
                    Event = AlertMapper.MapEventType(warning.Type),
                    Headline = warning.Title ?? warning.ShortTitle,
                    Description = warning.Description,
                    Severity = MapBomWarningLevelToSeverity(warning.WarningLevel),
                    AreaDescription = warning.Areas.Count > 0 ? string.Join(", ", warning.Areas) : warning.State,
                    Category = AlertMapper.MapCategory(warning.Type),
                    Status = warning.Phase,
                    Effective = ParseDateTime(warning.IssueTime),
                    Expires = ParseDateTime(warning.ExpiryTime)
                });
            }
        }

        /// <summary>
        /// Maps BOM warning level to severity string.
        /// </summary>
        /// <param name="warningLevel">The BOM warning level.</param>
        /// <returns>Severity string.</returns>
        private static AlertSeverity MapBomWarningLevelToSeverity(string? warningLevel) =>
            string.IsNullOrEmpty(warningLevel)
                ? AlertSeverity.Unknown
                : warningLevel.ToUpperInvariant() switch
                {
                    var level when level.Contains("EXTREME") => AlertSeverity.Extreme,
                    var level when level.Contains("SEVERE") => AlertSeverity.Severe,
                    var level when level.Contains("MODERATE") => AlertSeverity.Moderate,
                    var level when level.Contains("MINOR") => AlertSeverity.Minor,
                    _ => AlertSeverity.Moderate
                };

        /// <summary>
        /// Maps GDACS alert level to severity string.
        /// </summary>
        /// <param name="alertLevel">The GDACS alert level (Green, Orange, Red).</param>
        /// <returns>Severity string.</returns>
        private static AlertSeverity MapGdacsAlertLevelToSeverity(string? alertLevel) =>
            alertLevel?.ToUpperInvariant() switch
            {
                "GREEN" => AlertSeverity.Minor,
                "ORANGE" => AlertSeverity.Moderate,
                "RED" => AlertSeverity.Severe,
                _ => AlertSeverity.Unknown
            };

        /// <summary>
        /// Maps Meteoalarm awareness level to severity string.
        /// </summary>
        /// <param name="awarenessLevel">The awareness level (1=Green, 2=Yellow, 3=Orange, 4=Red).</param>
        /// <returns>Severity string.</returns>
        private static AlertSeverity MapAwarenessLevelToSeverity(int? awarenessLevel) =>
            awarenessLevel switch
            {
                1 => AlertSeverity.Minor,
                2 => AlertSeverity.Moderate,
                3 => AlertSeverity.Severe,
                4 => AlertSeverity.Extreme,
                _ => AlertSeverity.Unknown
            };

        /// <summary>
        /// Maps EMSC earthquake data to combined alert items.
        /// </summary>
        /// <param name="data">The EMSC response data.</param>
        private void MapEmsc(EmscAlertsResponse? data)
        {
            if (data?.Features is not { Count: > 0 }) return;

            // Add EMSC as a data source
            DataSources.Add("EMSC");

            // Map each EMSC feature to a WeatherAlertItem
            foreach (var feature in data.Features)
            {
                if (feature.Properties is null) continue;
                var props = feature.Properties;

                // Map the EMSC earthquake properties to a WeatherAlertItem
                Alerts.Add(new WeatherAlertItem
                {
                    Source = "EMSC",
                    Id = feature.Id ?? props.UniqueId,
                    Event = AlertEventType.Earthquake,
                    Headline = $"Magnitude {props.Magnitude:F1} earthquake - {props.Region}",
                    Description = $"Magnitude {props.Magnitude:F1} {props.MagnitudeType} earthquake at depth {props.Depth:F1} km in {props.Region}.",
                    Severity = MapMagnitudeToSeverity(props.Magnitude),
                    Urgency = AlertUrgency.Past,
                    Certainty = AlertCertainty.Observed,
                    Category = AlertCategory.Geo,
                    AreaDescription = props.Region,
                    Onset = ParseDateTime(props.Time),
                    Expires = null
                });
            }
        }

        /// <summary>
        /// Maps DWD warning data to combined alert items.
        /// </summary>
        /// <param name="data">The DWD response data.</param>
        private void MapDwd(DwdAlertsResponse? data)
        {
            if (data?.Warnings is not { Count: > 0 }) return;

            // Add DWD as a data source
            DataSources.Add("DWD");

            // Map each DWD warning to a WeatherAlertItem
            foreach (var warning in data.Warnings.Values.SelectMany(x => x.Values))
            {
                // Map the DWD warning properties to a WeatherAlertItem
                Alerts.Add(new WeatherAlertItem
                {
                    Source = "DWD",
                    Event = AlertMapper.MapEventType(warning.Event),
                    Headline = warning.Headline,
                    Description = warning.Description,
                    Instruction = warning.Instruction,
                    Severity = MapDwdLevelToSeverity(warning.Level),
                    Urgency = AlertUrgency.Expected,
                    Certainty = AlertCertainty.Likely,
                    Category = AlertCategory.Met,
                    AreaDescription = warning.RegionName,
                    Onset = warning.Start.HasValue ? DateTimeOffset.FromUnixTimeMilliseconds(warning.Start.Value).DateTime : null,
                    Expires = warning.End.HasValue ? DateTimeOffset.FromUnixTimeMilliseconds(warning.End.Value).DateTime : null
                });
            }
        }

        /// <summary>
        /// Maps earthquake magnitude to severity string.
        /// </summary>
        /// <param name="magnitude">The earthquake magnitude.</param>
        /// <returns>Severity string.</returns>
        private static AlertSeverity MapMagnitudeToSeverity(double? magnitude) =>
            !magnitude.HasValue
                ? AlertSeverity.Unknown
                : magnitude.Value switch
                {
                    < 4.0 => AlertSeverity.Minor,
                    < 5.0 => AlertSeverity.Moderate,
                    < 6.0 => AlertSeverity.Severe,
                    _ => AlertSeverity.Extreme
                };

        /// <summary>
        /// Maps DWD warning level to severity string.
        /// </summary>
        /// <param name="level">The DWD warning level (1-4).</param>
        /// <returns>Severity string.</returns>
        private static AlertSeverity MapDwdLevelToSeverity(int? level) =>
            level switch
            {
                1 => AlertSeverity.Minor,
                2 => AlertSeverity.Moderate,
                3 => AlertSeverity.Severe,
                4 => AlertSeverity.Extreme,
                _ => AlertSeverity.Unknown
            };

        /// <summary>
        /// Parses a date-time string safely.
        /// </summary>
        /// <param name="dateTimeString">The date-time string.</param>
        /// <returns>Parsed DateTime or null.</returns>
        private static DateTime? ParseDateTime(string? dateTimeString) =>
            !string.IsNullOrWhiteSpace(dateTimeString) && DateTime.TryParse(dateTimeString, CultureInfo.InvariantCulture, DateTimeStyles.None, out var result)
                ? result
                : null;
    }
}
