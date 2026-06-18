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
        #region Properties

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

        #endregion

        #region Constructors

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
        /// <param name="dwdData">The DWD weather warnings data.</param>
        /// <param name="latitude">The latitude.</param>
        /// <param name="longitude">The longitude.</param>
        public CombinedWeatherAlertInformation(
            MeteoalarmResponse? meteoalarmData,
            NwsAlertsResponse? nwsData,
            GdacsResponse? gdacsData,
            EnvironmentCanadaResponse? environmentCanadaData,
            BomAlertsResponse? bomData,
            EmscResponse? emscData,
            DwdAlertsResponse? dwdData,
            string? latitude,
            string? longitude)
        {
            LastUpdated = DateTime.UtcNow;

            if (!string.IsNullOrEmpty(latitude) && double.TryParse(latitude, out var lat))
                Latitude = lat;

            if (!string.IsNullOrEmpty(longitude) && double.TryParse(longitude, out var lon))
                Longitude = lon;

            MapMeteoalarm(meteoalarmData);
            MapNws(nwsData);
            MapGdacs(gdacsData);
            MapEnvironmentCanada(environmentCanadaData);
            MapBom(bomData);
            MapEmsc(emscData);
            MapDwd(dwdData);
        }

        #endregion

        #region Methods

        /// <summary>
        /// Maps Meteoalarm data to combined alert items.
        /// </summary>
        /// <param name="data">The Meteoalarm response data.</param>
        private void MapMeteoalarm(MeteoalarmResponse? data)
        {
            if (data?.Alerts is null || data.Alerts.Count == 0) return;

            DataSources.Add("Meteoalarm");
            RegionCode ??= data.Country;

            foreach (var alert in data.Alerts)
            {
                var item = new WeatherAlertItem
                {
                    Id = alert.Id,
                    Source = "Meteoalarm",
                    Event = alert.Event,
                    Headline = alert.Headline,
                    Description = alert.Description,
                    Instruction = alert.Instruction,
                    Severity = alert.Severity ?? MapAwarenessLevelToSeverity(alert.AwarenessLevel),
                    Certainty = alert.Certainty,
                    Urgency = alert.Urgency,
                    AreaDescription = alert.Area,
                    SenderName = alert.SenderName,
                    Onset = ParseDateTime(alert.Onset),
                    Expires = ParseDateTime(alert.Expires),
                    Effective = ParseDateTime(alert.Effective)
                };

                Alerts.Add(item);
            }
        }

        /// <summary>
        /// Maps NWS data to combined alert items.
        /// </summary>
        /// <param name="data">The NWS response data.</param>
        private void MapNws(NwsAlertsResponse? data)
        {
            if (data?.Features is null || data.Features.Count == 0) return;

            DataSources.Add("NWS");

            foreach (var feature in data.Features)
            {
                var props = feature.Properties;
                if (props is null) continue;

                var item = new WeatherAlertItem
                {
                    Id = props.Id,
                    Source = "NWS",
                    Event = props.Event,
                    Headline = props.Headline,
                    Description = props.Description,
                    Instruction = props.Instruction,
                    Severity = props.Severity,
                    Certainty = props.Certainty,
                    Urgency = props.Urgency,
                    AreaDescription = props.AreaDesc,
                    SenderName = props.SenderName,
                    Status = props.Status,
                    MessageType = props.MessageType,
                    Category = props.Category,
                    Onset = ParseDateTime(props.Onset),
                    Expires = ParseDateTime(props.Expires),
                    Effective = ParseDateTime(props.Effective),
                    Ends = ParseDateTime(props.Ends),
                    Sent = ParseDateTime(props.Sent)
                };

                Alerts.Add(item);
            }
        }

        /// <summary>
        /// Maps GDACS data to combined alert items.
        /// </summary>
        /// <param name="data">The GDACS response data.</param>
        private void MapGdacs(GdacsResponse? data)
        {
            if (data?.Features is null || data.Features.Count == 0) return;

            DataSources.Add("GDACS");

            foreach (var feature in data.Features)
            {
                var props = feature.Properties;
                if (props is null) continue;

                var item = new WeatherAlertItem
                {
                    Id = props.EventId,
                    Source = "GDACS",
                    Event = props.EventType,
                    Headline = props.EventName,
                    Description = props.Description,
                    Severity = MapGdacsAlertLevelToSeverity(props.AlertLevel),
                    AreaDescription = props.Country,
                    Category = props.EventType,
                    Onset = ParseDateTime(props.FromDate),
                    Ends = ParseDateTime(props.ToDate)
                };

                Alerts.Add(item);
            }
        }

        /// <summary>
        /// Maps Environment Canada data to combined alert items.
        /// </summary>
        /// <param name="data">The Environment Canada response data.</param>
        private void MapEnvironmentCanada(EnvironmentCanadaResponse? data)
        {
            if (data?.Entries is null || data.Entries.Count == 0) return;

            DataSources.Add("Environment Canada");

            foreach (var entry in data.Entries)
            {
                var capInfo = entry.CapAlert?.Info;
                if (capInfo is null) continue;

                var item = new WeatherAlertItem
                {
                    Id = entry.CapAlert?.Identifier ?? entry.Id,
                    Source = "Environment Canada",
                    Event = capInfo.Event,
                    Headline = capInfo.Headline ?? entry.Title,
                    Description = capInfo.Description ?? entry.Summary,
                    Instruction = capInfo.Instruction,
                    Severity = capInfo.Severity,
                    Certainty = capInfo.Certainty,
                    Urgency = capInfo.Urgency,
                    AreaDescription = capInfo.Area?.AreaDesc,
                    SenderName = capInfo.SenderName,
                    Category = capInfo.Category,
                    Effective = ParseDateTime(capInfo.Effective),
                    Expires = ParseDateTime(capInfo.Expires),
                    Sent = ParseDateTime(entry.CapAlert?.Sent),
                    Status = entry.CapAlert?.Status,
                    MessageType = entry.CapAlert?.MsgType
                };

                Alerts.Add(item);
            }
        }

        /// <summary>
        /// Maps BOM Australia data to combined alert items.
        /// </summary>
        /// <param name="data">The BOM response data.</param>
        private void MapBom(BomAlertsResponse? data)
        {
            if (data?.Warnings is null || data.Warnings.Count == 0) return;

            DataSources.Add("BOM Australia");

            foreach (var warning in data.Warnings)
            {
                var item = new WeatherAlertItem
                {
                    Id = warning.Id,
                    Source = "BOM Australia",
                    Event = warning.Type,
                    Headline = warning.Title ?? warning.ShortTitle,
                    Description = warning.Description,
                    Severity = MapBomWarningLevelToSeverity(warning.WarningLevel),
                    AreaDescription = warning.Areas.Count > 0 ? string.Join(", ", warning.Areas) : warning.State,
                    Category = warning.Type,
                    Status = warning.Phase,
                    Effective = ParseDateTime(warning.IssueTime),
                    Expires = ParseDateTime(warning.ExpiryTime)
                };

                Alerts.Add(item);
            }
        }

        /// <summary>
        /// Maps BOM warning level to severity string.
        /// </summary>
        /// <param name="warningLevel">The BOM warning level.</param>
        /// <returns>Severity string.</returns>
        private static string MapBomWarningLevelToSeverity(string? warningLevel)
        {
            if (string.IsNullOrEmpty(warningLevel)) return "Unknown";

            // BOM uses terms like "Severe", "Extreme", "Moderate"
            return warningLevel.ToUpperInvariant() switch
            {
                var level when level.Contains("EXTREME") => "Extreme",
                var level when level.Contains("SEVERE") => "Severe",
                var level when level.Contains("MODERATE") => "Moderate",
                var level when level.Contains("MINOR") => "Minor",
                _ => "Moderate"
            };
        }

        /// <summary>
        /// Maps GDACS alert level to severity string.
        /// </summary>
        /// <param name="alertLevel">The GDACS alert level (Green, Orange, Red).</param>
        /// <returns>Severity string.</returns>
        private static string MapGdacsAlertLevelToSeverity(string? alertLevel)
        {
            return alertLevel?.ToUpperInvariant() switch
            {
                "GREEN" => "Minor",
                "ORANGE" => "Moderate",
                "RED" => "Severe",
                _ => "Unknown"
            };
        }

        /// <summary>
        /// Maps Meteoalarm awareness level to severity string.
        /// </summary>
        /// <param name="awarenessLevel">The awareness level (1=Green, 2=Yellow, 3=Orange, 4=Red).</param>
        /// <returns>Severity string.</returns>
        private static string MapAwarenessLevelToSeverity(int? awarenessLevel)
        {
            return awarenessLevel switch
            {
                1 => "Minor",
                2 => "Moderate",
                3 => "Severe",
                4 => "Extreme",
                _ => "Unknown"
            };
        }

        /// <summary>
        /// Maps EMSC earthquake data to combined alert items.
        /// </summary>
        /// <param name="data">The EMSC response data.</param>
        private void MapEmsc(EmscResponse? data)
        {
            if (data?.Features is null || data.Features.Count == 0) return;

            DataSources.Add("EMSC");

            foreach (var feature in data.Features)
            {
                if (feature.Properties is null) continue;

                var props = feature.Properties;
                var coords = feature.Geometry?.Coordinates;

                var item = new WeatherAlertItem
                {
                    Source = "EMSC",
                    Id = feature.Id ?? props.UniqueId,
                    Event = "earthquake",
                    Headline = $"Magnitude {props.Magnitude:F1} earthquake - {props.Region}",
                    Description = $"Magnitude {props.Magnitude:F1} {props.MagnitudeType} earthquake at depth {props.Depth:F1} km in {props.Region}.",
                    Severity = MapMagnitudeToSeverity(props.Magnitude),
                    Urgency = "Past",
                    Certainty = "Observed",
                    Category = "Geo",
                    AreaDescription = props.Region,
                    Onset = ParseDateTime(props.Time),
                    Expires = null
                };

                // Note: Coordinates available in feature.Geometry.Coordinates but WeatherAlertItem doesn't store lat/lon

                Alerts.Add(item);
            }
        }

        /// <summary>
        /// Maps DWD warning data to combined alert items.
        /// </summary>
        /// <param name="data">The DWD response data.</param>
        private void MapDwd(DwdAlertsResponse? data)
        {
            if (data?.Warnings is null || data.Warnings.Count == 0) return;

            DataSources.Add("DWD");

            foreach (var regionWarnings in data.Warnings.Values)
            {
                foreach (var warning in regionWarnings.Values)
                {
                    var item = new WeatherAlertItem
                    {
                        Source = "DWD",
                        Event = warning.Event,
                        Headline = warning.Headline,
                        Description = warning.Description,
                        Instruction = warning.Instruction,
                        Severity = MapDwdLevelToSeverity(warning.Level),
                        Urgency = "Expected",
                        Certainty = "Likely",
                        Category = "Met",
                        AreaDescription = warning.RegionName,
                        Onset = warning.Start.HasValue ? DateTimeOffset.FromUnixTimeMilliseconds(warning.Start.Value).DateTime : null,
                        Expires = warning.End.HasValue ? DateTimeOffset.FromUnixTimeMilliseconds(warning.End.Value).DateTime : null
                    };

                    Alerts.Add(item);
                }
            }
        }

        /// <summary>
        /// Maps earthquake magnitude to severity string.
        /// </summary>
        /// <param name="magnitude">The earthquake magnitude.</param>
        /// <returns>Severity string.</returns>
        private static string MapMagnitudeToSeverity(double? magnitude)
        {
            if (!magnitude.HasValue) return "Unknown";

            return magnitude.Value switch
            {
                < 4.0 => "Minor",
                < 5.0 => "Moderate",
                < 6.0 => "Severe",
                _ => "Extreme"
            };
        }

        /// <summary>
        /// Maps DWD warning level to severity string.
        /// </summary>
        /// <param name="level">The DWD warning level (1-4).</param>
        /// <returns>Severity string.</returns>
        private static string MapDwdLevelToSeverity(int? level)
        {
            return level switch
            {
                1 => "Minor",
                2 => "Moderate",
                3 => "Severe",
                4 => "Extreme",
                _ => "Unknown"
            };
        }

        /// <summary>
        /// Parses a date-time string safely.
        /// </summary>
        /// <param name="dateTimeString">The date-time string.</param>
        /// <returns>Parsed DateTime or null.</returns>
        private static DateTime? ParseDateTime(string? dateTimeString)
        {
            if (string.IsNullOrWhiteSpace(dateTimeString)) return null;

            return DateTime.TryParse(dateTimeString, out var result) ? result : null;
        }

        #endregion
    }
}
