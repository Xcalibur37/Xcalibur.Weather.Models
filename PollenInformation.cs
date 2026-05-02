using Xcalibur.Weather.Models.WeatherProvider.GooglePollen.Forecast;

namespace Xcalibur.Weather.Models
{
    /// <summary>
    /// Pollen information for app consumption.
    /// </summary>
    public class PollenInformation
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
        /// Gets or sets the daily forecasts.
        /// </summary>
        /// <value>
        /// The daily forecasts.
        /// </value>
        public List<PollenDailyInformation> DailyForecasts { get; set; } = new();

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="PollenInformation" /> class.
        /// </summary>
        /// <param name="data">The data.</param>
        public PollenInformation(PollenForecastResponse? data = null)
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
        private void Map(PollenForecastResponse? data)
        {
            if (data is null) return;

            RegionCode = data.RegionCode;
            DailyForecasts = data.DailyInfo?.Select(x => new PollenDailyInformation(x)).ToList() ?? [];
        }

        #endregion
    }
}
