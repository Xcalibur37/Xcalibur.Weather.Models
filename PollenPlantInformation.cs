using Xcalibur.Weather.Models.WeatherProvider.GooglePollen.Forecast;

namespace Xcalibur.Weather.Models
{
    /// <summary>
    /// Plant pollen information for app consumption.
    /// </summary>
    public class PollenPlantInformation
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
        /// Gets or sets the plant type.
        /// </summary>
        /// <value>
        /// The plant type.
        /// </value>
        public string? Type { get; set; }

        /// <summary>
        /// Gets or sets the family.
        /// </summary>
        /// <value>
        /// The family.
        /// </value>
        public string? Family { get; set; }

        /// <summary>
        /// Gets or sets the season.
        /// </summary>
        /// <value>
        /// The season.
        /// </value>
        public string? Season { get; set; }

        /// <summary>
        /// Gets or sets the special colors.
        /// </summary>
        /// <value>
        /// The special colors.
        /// </value>
        public string? SpecialColors { get; set; }

        /// <summary>
        /// Gets or sets the special shapes.
        /// </summary>
        /// <value>
        /// The special shapes.
        /// </value>
        public string? SpecialShapes { get; set; }

        /// <summary>
        /// Gets or sets the cross reaction.
        /// </summary>
        /// <value>
        /// The cross reaction.
        /// </value>
        public string? CrossReaction { get; set; }

        /// <summary>
        /// Gets or sets the picture.
        /// </summary>
        /// <value>
        /// The picture.
        /// </value>
        public string? Picture { get; set; }

        /// <summary>
        /// Gets or sets the picture closeup.
        /// </summary>
        /// <value>
        /// The picture closeup.
        /// </value>
        public string? PictureCloseup { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="PollenPlantInformation" /> class.
        /// </summary>
        /// <param name="data">The data.</param>
        public PollenPlantInformation(PlantInfoModel? data = null)
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
        private void Map(PlantInfoModel? data)
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

            Type = data.PlantDescription?.Type;
            Family = data.PlantDescription?.Family;
            Season = data.PlantDescription?.Season;
            SpecialColors = data.PlantDescription?.SpecialColors;
            SpecialShapes = data.PlantDescription?.SpecialShapes;
            CrossReaction = data.PlantDescription?.CrossReaction;
            Picture = data.PlantDescription?.Picture;
            PictureCloseup = data.PlantDescription?.PictureCloseup;
        }

        #endregion
    }
}
