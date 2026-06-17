using System.Globalization;
using Xcalibur.Extensions.MVVM.V2.Models;
using Xcalibur.Weather.Models.Helpers;
using Xcalibur.Weather.Models.Services.Geocodio.Response;
using Xcalibur.Weather.Models.Services.OpenStreetMap.Response;

namespace Xcalibur.Weather.Models.Implementation.Geocoding
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
        /// Initializes a new instance of the <see cref="AddressLocationModel"/> class.
        /// </summary>
        /// <param name="data">The data.</param>
        public AddressLocationModel(GeocodioResultResponse? data = null)
        {
            if (data is null) return;
            Map(data);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddressLocationModel" /> class
        /// from an OpenStreetMap result.
        /// </summary>
        /// <param name="data">The OpenStreetMap result.</param>
        public AddressLocationModel(OpenStreetMapResultResponse data)
        {
            Map(data);
        }

        #endregion

        #region Methods

        /// <summary>
        /// Maps the specified data.
        /// </summary>
        /// <param name="data">The data.</param>
        private void Map(GeocodioResultResponse? data)
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
        /// Maps the specified OpenStreetMap data.
        /// </summary>
        /// <param name="data">The data.</param>
        private void Map(OpenStreetMapResultResponse data)
        {
            // Location
            Latitude = data.Lat ?? "0";
            Longitude = data.Lon ?? "0";

            // Address Components — city falls back to town then village
            City = data.Address?.City ?? data.Address?.Town ?? data.Address?.Village;
            County = data.Address?.County;
            State = data.Address?.State;
            Zip = data.Address?.Postcode;
            Country = data.Address?.Country;

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
