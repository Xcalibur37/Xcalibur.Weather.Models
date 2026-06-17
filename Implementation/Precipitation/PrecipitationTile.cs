using Xcalibur.Extensions.MVVM.V2.Models;

namespace Xcalibur.Weather.Models.Implementation.Precipitation
{
    /// <summary>
    /// Precipitation Details Tile
    /// </summary>
    /// <seealso cref="ModelBase" />
    public class PrecipitationTile : ModelBase
    {
        /// <summary>
        /// Gets or sets the header.
        /// </summary>
        /// <value>
        /// The header.
        /// </value>
        public string Header { get; private set => NotifyOfChange(value, ref field); }

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>
        /// The value.
        /// </value>
        public string? Value { get; private set => NotifyOfChange(value, ref field); }

        /// <summary>
        /// Gets the image path.
        /// </summary>
        /// <value>
        /// The image path.
        /// </value>
        public string? ImagePath { get; private set => NotifyOfChange(value, ref field); }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is visible.
        /// </summary>
        /// <value>
        ///  <c>true</c> if this instance is visible; otherwise, <c>false</c>.
        /// </value>
        public bool IsVisible { get; private set => NotifyOfChange(value, ref field); }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrecipitationTile" /> class.
        /// </summary>
        /// <param name="header">The header.</param>
        /// <param name="value">The value.</param>
        /// <param name="imagePath">The image path.</param>
        /// <param name="isVisible">if set to <c>true</c> [is visible].</param>
        public PrecipitationTile(string header, string? value, string imagePath, bool isVisible)
        {
            Header = header;
            Value = value;
            ImagePath = imagePath;
            IsVisible = isVisible;
        }
    }
}
