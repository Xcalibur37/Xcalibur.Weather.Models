using System.Text.Json.Serialization;
using Xcalibur.Weather.Models.Services.Atmospore.Response;

namespace Xcalibur.Weather.Models.Implementation.Pollen
{
    /// <summary>
    /// App-facing pollen data for a single forecast day.
    /// </summary>
    public class PollenDailyEntry
    {
        #region Properties

        /// <summary>
        /// Gets or sets the forecast date (yyyy-MM-dd).
        /// </summary>
        public string? Date { get; set; }

        /// <summary>
        /// Gets or sets the overall risk level for the day (e.g., low, moderate, high, very high).
        /// </summary>
        public string? OverallRisk { get; set; }

        /// <summary>
        /// Gets or sets the per-species pollen items for this day.
        /// </summary>
        public List<PollenItem> Species { get; set; } = [];

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="PollenDailyEntry"/> class.
        /// </summary>
        [JsonConstructor]   
        public PollenDailyEntry()
        {
            
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PollenDailyEntry" /> class.
        /// </summary>
        /// <param name="data">The data.</param>
        public PollenDailyEntry(PollenEntryResponse? data = null)
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
        private void Map(PollenEntryResponse data)
        {
            Date = data.Date;
            OverallRisk = data.OverallRisk;
            Species = data.Species?
                .Select(kvp => new PollenItem(kvp.Key, kvp.Value))
                .ToList() ?? [];
        }

        #endregion
    }
}
