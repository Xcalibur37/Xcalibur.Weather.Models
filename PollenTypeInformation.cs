using Xcalibur.Weather.Models.WeatherProvider.GooglePollen.Forecast;

namespace Xcalibur.Weather.Models
{
    /// <summary>
    /// Pollen type information for app consumption.
    /// </summary>
    public class PollenTypeInformation
    {
        #region Properties

        /// <summary>
        /// Gets or sets the code.
        /// </summary>
        /// <value>
        /// The code.
        /// </value>
        public string? Code { get; set; }

        /// <summary>
        /// Gets or sets the display name.
        /// </summary>
        /// <value>
        /// The display name.
        /// </value>
        public string? DisplayName { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is in season.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is in season; otherwise, <c>false</c>.
        /// </value>
        public bool? InSeason { get; set; }

        /// <summary>
        /// Gets or sets the index code.
        /// </summary>
        /// <value>
        /// The index code.
        /// </value>
        public string? IndexCode { get; set; }

        /// <summary>
        /// Gets or sets the index display name.
        /// </summary>
        /// <value>
        /// The index display name.
        /// </value>
        public string? IndexDisplayName { get; set; }

        /// <summary>
        /// Gets or sets the index value.
        /// </summary>
        /// <value>
        /// The index value.
        /// </value>
        public int? IndexValue { get; set; }

        /// <summary>
        /// Gets or sets the category.
        /// </summary>
        /// <value>
        /// The category.
        /// </value>
        public string? Category { get; set; }

        /// <summary>
        /// Gets or sets the index description.
        /// </summary>
        /// <value>
        /// The index description.
        /// </value>
        public string? IndexDescription { get; set; }

        /// <summary>
        /// Gets or sets the color red component.
        /// </summary>
        /// <value>
        /// The color red component.
        /// </value>
        public double? ColorRed { get; set; }

        /// <summary>
        /// Gets or sets the color green component.
        /// </summary>
        /// <value>
        /// The color green component.
        /// </value>
        public double? ColorGreen { get; set; }

        /// <summary>
        /// Gets or sets the color blue component.
        /// </summary>
        /// <value>
        /// The color blue component.
        /// </value>
        public double? ColorBlue { get; set; }

        /// <summary>
        /// Gets or sets the health recommendations.
        /// </summary>
        /// <value>
        /// The health recommendations.
        /// </value>
        public List<string> HealthRecommendations { get; set; } = new();

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="PollenTypeInformation" /> class.
        /// </summary>
        /// <param name="data">The data.</param>
        public PollenTypeInformation(PollenTypeInfoModel? data = null)
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
        private void Map(PollenTypeInfoModel? data)
        {
            if (data is null) return;

            Code = data.Code;
            DisplayName = data.DisplayName;
            InSeason = data.InSeason;

            IndexCode = data.IndexInfo?.Code;
            IndexDisplayName = data.IndexInfo?.DisplayName;
            IndexValue = data.IndexInfo?.Value;
            Category = data.IndexInfo?.Category;
            IndexDescription = data.IndexInfo?.IndexDescription;
            ColorRed = data.IndexInfo?.Color?.Red;
            ColorGreen = data.IndexInfo?.Color?.Green;
            ColorBlue = data.IndexInfo?.Color?.Blue;

            HealthRecommendations = data.HealthRecommendations?.ToList() ?? new List<string>();
        }

        #endregion
    }
}
