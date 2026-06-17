namespace Xcalibur.Weather.Models.Implementation
{
    /// <summary>
    /// Double Range.
    /// </summary>
    public class DoubleRange
    {
        /// <summary>
        /// Gets or sets from.
        /// </summary>
        /// <value>
        /// From.
        /// </value>
        public double From { get; set; }

        /// <summary>
        /// Converts to .
        /// </summary>
        /// <value>
        /// To.
        /// </value>
        public double To { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="DoubleRange"/> class.
        /// </summary>
        /// <param name="from">From.</param>
        /// <param name="to">To.</param>
        public DoubleRange(double from, double to)
        {
            From = from;
            To = to;
        }
    }
}
