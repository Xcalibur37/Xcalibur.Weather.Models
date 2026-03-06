namespace Xcalibur.Weather.Models.Helpers
{
    /// <summary>
    /// Open Meteo helper methods.
    /// </summary>
    public static class AqiValueHelper
    {
        /// <param name="value">The value.</param>
        extension(int? value)
        {
            /// <summary>
            /// Gets the aqi value description.
            /// </summary>
            /// <returns></returns>
            public string GetAqiValueDescription()
                => value switch
                {
                    null => "Unknown",
                    <= 50 => "Good",
                    <= 100 => "Moderate",
                    <= 150 => "Unhealthy: Sensitive",
                    <= 200 => "Unhealthy",
                    <= 300 => "Very Unhealthy",
                    _ => "Hazardous"
                };

            /// <summary>
            /// Gets the aqi value details.
            /// </summary>
            /// <returns></returns>
            public string GetAqiValueDetails()
                => value switch
                {
                    null => "Air quality is unknown.",
                    <= 50 => "Air quality is considered satisfactory, and air pollution poses little or no risk.",
                    <= 100 => "Air quality is acceptable; however, there may be a moderate health concern for a very small number of people who are unusually sensitive to air pollution.",
                    <= 150 => "Members of sensitive groups may experience health effects. The general public is not likely to be affected.",
                    <= 200 => "Everyone may begin to experience health effects; members of sensitive groups may experience more serious health effects.",
                    <= 300 => "Health warnings of emergency conditions. The entire population is more likely to be affected.",
                    _ => "Health alert: everyone may experience more serious health effects."
                };
        }
    }
}
