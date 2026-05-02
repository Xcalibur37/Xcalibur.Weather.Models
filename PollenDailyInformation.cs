using Xcalibur.Weather.Models.WeatherProvider.GooglePollen.Forecast;

namespace Xcalibur.Weather.Models
{
    /// <summary>
    /// Daily pollen information for app consumption.
    /// </summary>
    public class PollenDailyInformation
    {
        #region Properties

        /// <summary>
        /// Gets or sets the date value.
        /// </summary>
        /// <value>
        /// The date value.
        /// </value>
        public string? DateValue { get; set; }

        /// <summary>
        /// Gets or sets the date object.
        /// </summary>
        /// <value>
        /// The date object.
        /// </value>
        public DateOnly? DateObject { get; set; }

        /// <summary>
        /// Gets or sets the pollen types.
        /// </summary>
        /// <value>
        /// The pollen types.
        /// </value>
        public List<PollenTypeInformation> PollenTypes { get; set; } = [];

        /// <summary>
        /// Gets or sets the plants.
        /// </summary>
        /// <value>
        /// The plants.
        /// </value>
        public List<PollenPlantInformation> Plants { get; set; } = [];

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="PollenDailyInformation" /> class.
        /// </summary>
        /// <param name="data">The data.</param>
        public PollenDailyInformation(DailyInfoModel? data = null)
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
        private void Map(DailyInfoModel? data)
        {
            if (data is null) return;

            if (data.Date is { Year: { } year, Month: { } month, Day: { } day })
            {
                DateObject = new DateOnly(year, month, day);
                DateValue = DateObject.Value.ToString("yyyy-MM-dd");
            }

            PollenTypes = data.PollenTypeInfo?.Select(x => new PollenTypeInformation(x)).ToList() ?? [];
            Plants = data.PlantInfo?.Select(x => new PollenPlantInformation(x)).ToList() ?? [];
        }

        #endregion
    }
}
