using Xcalibur.Weather.Models.Services.Atmospore.Response;

namespace Xcalibur.Weather.Models.Implementation.Pollen
{
    /// <summary>
    /// App-facing pollen entry for a single species on a given day.
    /// </summary>
    public class PollenItem
    {
        #region Properties

        /// <summary>
        /// Gets or sets the species identifier code (e.g., "birch", "grass").
        /// </summary>
        public string? Species { get; set; }

        /// <summary>
        /// Gets or sets the human-readable display name of the species.
        /// </summary>
        public string? DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the pollen category (e.g., tree, grass, weed).
        /// </summary>
        public string? Category { get; set; }

        /// <summary>
        /// Gets or sets the pollen concentration value (grains/m³).
        /// </summary>
        public double? Value { get; set; }

        /// <summary>
        /// Gets or sets the risk level description (e.g., low, moderate, high, very high).
        /// </summary>
        public string? RiskLevel { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="PollenItem" /> class.
        /// </summary>
        /// <param name="speciesCode">The species code key.</param>
        /// <param name="data">The species entry data.</param>
        public PollenItem(string? speciesCode = null, PollenSpeciesEntryResponse? data = null)
        {
            if (data is null) return;
            Species = speciesCode;
            Map(data);
        }

        #endregion

        #region Methods

        /// <summary>
        /// Maps the specified data.
        /// </summary>
        /// <param name="data">The data.</param>
        private void Map(PollenSpeciesEntryResponse data)
        {
            DisplayName = data.DisplayName;
            Category = data.Category;
            Value = data.Value;
            RiskLevel = data.RiskLevel;
        }

        #endregion
    }
}
