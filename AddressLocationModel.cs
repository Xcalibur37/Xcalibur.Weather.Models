using System.Globalization;
using Xcalibur.Extensions.MVVM.V2.Models;
using Xcalibur.Weather.Models.Helpers;
using Xcalibur.Weather.Models.WeatherProvider.Geocodio;

namespace Xcalibur.Weather.Models
{
    /// <summary>
    /// Address Location Model.
    /// </summary>
    public class AddressLocationModel : ModelBase
    {
        #region Properties

        /// <summary>
        /// Gets the key.
        /// </summary>
        /// <value>
        /// The key.
        /// </value>
        public string Key { get; set; } = "";

        /// <summary>
        /// Gets the city.
        /// </summary>
        /// <value>
        /// The city.
        /// </value>
        public string? City { get; set; }

        /// <summary>
        /// Gets the county.
        /// </summary>
        /// <value>
        /// The county.
        /// </value>
        public string? County { get; set; }

        /// <summary>
        /// Gets the state.
        /// </summary>
        /// <value>
        /// The state.
        /// </value>
        public string? State { get; set; }

        /// <summary>
        /// Gets the zip.
        /// </summary>
        /// <value>
        /// The zip.
        /// </value>
        public string? Zip { get; set; }

        /// <summary>
        /// Gets the country.
        /// </summary>
        /// <value>
        /// The country.
        /// </value>
        public string? Country { get; set; }

        /// <summary>
        /// Gets the latitude.
        /// </summary>
        /// <value>
        /// The latitude.
        /// </value>
        public string? Latitude { get; set; }

        /// <summary>
        /// Gets the longitude.
        /// </summary>
        /// <value>
        /// The longitude.
        /// </value>
        public string? Longitude { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is selected.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is selected; otherwise, <c>false</c>.
        /// </value>
        public bool IsSelected
        {
            get; 
            set => NotifyOfChange(value, ref field);
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="SunMoonPoint" /> class.
        /// </summary>
        /// <param name="data">The data.</param>
        public AddressLocationModel(GeocodioResult? data = null)
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
        private void Map(GeocodioResult? data)
        {
            if (data is null) return;

            // Location
            Latitude = data.Location?.Latitude.ToString(CultureInfo.InvariantCulture) ?? "0";
            Longitude = data.Location?.Longitude.ToString(CultureInfo.InvariantCulture) ?? "0";

            // Address Components
            City = data.AddressComponents?.City;
            County = data.AddressComponents?.County;
            State = data.AddressComponents?.State;
            Zip = data.AddressComponents?.Zip;
            Country = data.AddressComponents?.Country;

            // Key
            Key = CreateKey();
        }

        /// <summary>
        /// Creates the key.
        /// </summary>
        /// <returns></returns>
        private string CreateKey()
            => SecurityHelper.Base64Encode($"{Latitude},{Longitude}");

        #endregion
    }
}
