using Xcalibur.Weather.Models.WeatherProvider.GoogleWeatherAlerts;

namespace Xcalibur.Weather.Models
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
        /// Gets or sets the severity.
        /// </summary>
        /// <value>
        /// The severity.
        /// </value>
        public string? Severity { get; set; }

        /// <summary>
        /// Gets or sets the certainty.
        /// </summary>
        /// <value>
        /// The certainty.
        /// </value>
        public string? Certainty { get; set; }

        /// <summary>
        /// Gets or sets the urgency.
        /// </summary>
        /// <value>
        /// The urgency.
        /// </value>
        public string? Urgency { get; set; }

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

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="WeatherAlertItem" /> class.
        /// </summary>
        /// <param name="data">The data.</param>
        public WeatherAlertItem(WeatherAlertModel? data = null)
        {
            if (data is null) return;
            Map(data);
        }

        #endregion

        #region Methods

        /// <summary>
        /// Maps the specified data.
        /// </summary>
        /// <param name="data">The data.</param>
        private void Map(WeatherAlertModel? data)
        {
            if (data is null) return;

            AlertId = data.AlertId;
            Title = data.AlertTitle?.Text;
            EventType = data.EventType;
            AreaName = data.AreaName;
            Description = data.Description;
            Severity = data.Severity;
            Certainty = data.Certainty;
            Urgency = data.Urgency;
            Instructions = data.Instruction ?? [];
            Polygon = data.Polygon;
            Publisher = data.DataSource?.Publisher;

            if (DateTime.TryParse(data.StartTime, out var start))
                StartTime = start;

            if (DateTime.TryParse(data.ExpirationTime, out var expiry))
                ExpirationTime = expiry;
        }

        #endregion
    }
}
