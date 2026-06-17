using Xcalibur.Weather.Models.Services.GoogleWeatherAlerts.Response;

namespace Xcalibur.Weather.Models.Implementation.WeatherAlerts
{
    /// <summary>
    /// Weather alert information for app consumption.
    /// </summary>
    public class WeatherAlertInformation
    {
        #region Properties

        /// <summary>
        /// Gets or sets the region code.
        /// </summary>
        /// <value>
        /// The region code.
        /// </value>
        public string? RegionCode { get; set; }

        /// <summary>
        /// Gets or sets the weather alerts.
        /// </summary>
        /// <value>
        /// The weather alerts.
        /// </value>
        public List<WeatherAlertItem> Alerts { get; set; } = [];

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="WeatherAlertInformation" /> class.
        /// </summary>
        /// <param name="data">The data.</param>
        public WeatherAlertInformation(WeatherAlertsResponse? data = null)
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
        private void Map(WeatherAlertsResponse? data)
        {
            if (data is null) return;

            RegionCode = data.RegionCode;
            Alerts = data.WeatherAlerts?.Select(x => new WeatherAlertItem(x)).ToList() ?? [];
        }

        #endregion
    }
}
