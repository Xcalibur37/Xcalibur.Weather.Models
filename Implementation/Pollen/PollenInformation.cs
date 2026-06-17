using Xcalibur.Weather.Models.Services.Atmospore.Response;

namespace Xcalibur.Weather.Models.Implementation.Pollen
{
    /// <summary>
    /// App-facing Atmospore pollen information aggregate.
    /// </summary>
    public class PollenInformation
    {
        #region Properties

        /// <summary>
        /// Gets or sets the UTC timestamp at which the forecast was generated.
        /// </summary>
        public string? GeneratedAt { get; set; }

        /// <summary>
        /// Gets or sets the latitude.
        /// </summary>
        public double? Latitude { get; set; }

        /// <summary>
        /// Gets or sets the longitude.
        /// </summary>
        public double? Longitude { get; set; }

        /// <summary>
        /// Gets or sets the units for pollen count values.
        /// </summary>
        public string? Units { get; set; }

        /// <summary>
        /// Gets or sets the daily forecast entries.
        /// </summary>
        public List<PollenDailyEntry> Days { get; set; } = [];

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="PollenInformation" /> class.
        /// </summary>
        /// <param name="data">The data.</param>
        public PollenInformation(PollenResponse? data = null)
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
        private void Map(PollenResponse data)
        {
            GeneratedAt = data.Meta?.GeneratedAt;
            Latitude = data.Meta?.Location?.Lat;
            Longitude = data.Meta?.Location?.Lon;
            Units = data.Meta?.Units;
            Days = data.Data?.Select(x => new PollenDailyEntry(x)).ToList() ?? [];
        }

        #endregion
    }
}
