using System.Text.Json.Serialization;
using Xcalibur.Weather.Models.Services.GoogleWeatherAlerts.Response;

namespace Xcalibur.Weather.Models.Implementation.WeatherAlerts
{
    /// <summary>
    /// A single weather alert item for app consumption.
    /// </summary>
    public class WeatherAlertItem
    {
        #region Properties

        /// <summary>
        /// Gets or sets the alert identifier.
        /// </summary>
        /// <value>
        /// The alert identifier.
        /// </value>
        public string? AlertId { get; set; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        public string? Title { get; set; }

        /// <summary>
        /// Gets or sets the type of the event.
        /// </summary>
        /// <value>
        /// The type of the event.
        /// </value>
        public string? EventType { get; set; }

        /// <summary>
        /// Gets or sets the name of the area.
        /// </summary>
        /// <value>
        /// The name of the area.
        /// </value>
        public string? AreaName { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        public string? Description { get; set; }

        /// <summary>
        /// Gets or sets the normalized severity enum value.
        /// </summary>
        /// <value>
        /// The severity.
        /// </value>
        public AlertSeverity Severity { get; set; }

        /// <summary>
        /// Gets or sets the normalized certainty enum value.
        /// </summary>
        /// <value>
        /// The certainty.
        /// </value>
        public AlertCertainty Certainty { get; set; }

        /// <summary>
        /// Gets or sets the normalized urgency enum value.
        /// </summary>
        /// <value>
        /// The urgency.
        /// </value>
        public AlertUrgency Urgency { get; set; }

        /// <summary>
        /// Gets or sets the instructions.
        /// </summary>
        /// <value>
        /// The instructions.
        /// </value>
        public List<string> Instructions { get; set; } = [];

        /// <summary>
        /// Gets or sets the start time.
        /// </summary>
        /// <value>
        /// The start time.
        /// </value>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Gets or sets the expiration time.
        /// </summary>
        /// <value>
        /// The expiration time.
        /// </value>
        public DateTime? ExpirationTime { get; set; }

        /// <summary>
        /// Gets or sets the publisher.
        /// </summary>
        /// <value>
        /// The publisher.
        /// </value>
        public string? Publisher { get; set; }

        /// <summary>
        /// Gets or sets the polygon as a GeoJSON string describing the alert area.
        /// </summary>
        /// <value>
        /// The polygon.
        /// </value>
        public string? Polygon { get; set; }

        /// <summary>
        /// Gets or sets the alert source (e.g., "Google", "Meteoalarm", "NWS").
        /// </summary>
        /// <value>
        /// The source.
        /// </value>
        public string? Source { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier from the source.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string? Id { get; set; }

        /// <summary>
        /// Gets or sets the normalized event type enum value.
        /// </summary>
        /// <value>
        /// The event.
        /// </value>
        public AlertEventType Event { get; set; }

        /// <summary>
        /// Gets or sets the headline.
        /// </summary>
        /// <value>
        /// The headline.
        /// </value>
        public string? Headline { get; set; }

        /// <summary>
        /// Gets or sets the instruction.
        /// </summary>
        /// <value>
        /// The instruction.
        /// </value>
        public string? Instruction { get; set; }

        /// <summary>
        /// Gets or sets the area description.
        /// </summary>
        /// <value>
        /// The area description.
        /// </value>
        public string? AreaDescription { get; set; }

        /// <summary>
        /// Gets or sets the sender name.
        /// </summary>
        /// <value>
        /// The name of the sender.
        /// </value>
        public string? SenderName { get; set; }

        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        /// <value>
        /// The status.
        /// </value>
        public string? Status { get; set; }

        /// <summary>
        /// Gets or sets the message type.
        /// </summary>
        /// <value>
        /// The type of the message.
        /// </value>
        public string? MessageType { get; set; }

        /// <summary>
        /// Gets or sets the normalized category enum value.
        /// </summary>
        /// <value>
        /// The category.
        /// </value>
        public AlertCategory Category { get; set; }

        /// <summary>
        /// Gets or sets the onset time.
        /// </summary>
        /// <value>
        /// The onset.
        /// </value>
        public DateTime? Onset { get; set; }

        /// <summary>
        /// Gets or sets the expires time.
        /// </summary>
        /// <value>
        /// The expires.
        /// </value>
        public DateTime? Expires { get; set; }

        /// <summary>
        /// Gets or sets the effective time.
        /// </summary>
        /// <value>
        /// The effective.
        /// </value>
        public DateTime? Effective { get; set; }

        /// <summary>
        /// Gets or sets the ends time.
        /// </summary>
        /// <value>
        /// The ends.
        /// </value>
        public DateTime? Ends { get; set; }

        /// <summary>
        /// Gets or sets the sent time.
        /// </summary>
        /// <value>
        /// The sent.
        /// </value>
        public DateTime? Sent { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="WeatherAlertItem" /> class.
        /// </summary>
        /// <param name="data">The data.</param>
        public WeatherAlertItem(WeatherAlertResponse? data = null)
        {
            if (data is null) return;
            Map(data);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WeatherAlertItem" /> class.
        /// Default constructor for custom initialization.
        /// </summary>
        [JsonConstructor]
        public WeatherAlertItem()
        {
        }

        #endregion

        #region Methods

        /// <summary>
        /// Maps the specified data.
        /// </summary>
        /// <param name="data">The data.</param>
        private void Map(WeatherAlertResponse? data)
        {
            if (data is null) return;

            // Map the properties from the WeatherAlertResponse to the WeatherAlertItem
            Source = "Google";
            AlertId = data.AlertId;
            Id = data.AlertId;
            Title = data.AlertTitle?.Text;
            EventType = data.EventType;
            Event = AlertMapper.MapEventType(data.EventType);
            AreaName = data.AreaName;
            AreaDescription = data.AreaName;
            Description = data.Description;
            Severity = AlertMapper.MapSeverity(data.Severity);
            Certainty = AlertMapper.MapCertainty(data.Certainty);
            Urgency = AlertMapper.MapUrgency(data.Urgency);
            Instructions = data.Instruction ?? [];
            Instruction = string.Join(" ", data.Instruction ?? []);
            Polygon = data.Polygon;
            Publisher = data.DataSource?.Publisher;
            SenderName = data.DataSource?.Publisher;

            // Map the category if available
            if (DateTime.TryParse(data.StartTime, out var start))
            {
                StartTime = start;
                Onset = start;
                Effective = start;
            }

            // Map the expiration time if available
            if (DateTime.TryParse(data.ExpirationTime, out var expiry))
            {
                ExpirationTime = expiry;
                Expires = expiry;
            }
        }

        #endregion
    }
}
