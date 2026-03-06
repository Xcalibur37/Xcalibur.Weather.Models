namespace Xcalibur.Weather.Models.WeatherProvider.OpenMeteo
{
    /// <summary>
    /// Open Meteo helper methods.
    /// </summary>
    public static class OpenMeteoHelper
    {
        /// <summary>
        /// Gets the weather code description.
        /// </summary>
        /// <param name="weatherCode">The weather code.</param>
        /// <returns></returns>
        public static string GetWeatherCodeDescription(this int? weatherCode)
            => weatherCode switch
            {
                0 => "Clear sky",
                1 => "Mainly clear",
                2 => "Partly cloudy",
                3 => "Overcast",
                30 => "Slight duststorm or sandstorm",
                31 or 32 => "Moderate duststorm or sandstorm",
                33 or 34 or 35 => "Severe duststorm or sandstorm",
                45 => "Fog",
                48 => "Depositing rime fog",
                51 => "Light drizzle",
                53 => "Moderate drizzle",
                55 => "Dense intensity drizzle",
                56 => "Light freezing drizzle",
                57 => "Dense intensity freezing drizzle",
                61 => "Slight rain",
                63 => "Moderate rain",
                65 => "Heavy intensity rain",
                66 => "Light freezing rain",
                67 => "Heavy intensity freezing rain",
                71 => "Slight snow fall",
                73 => "Moderate snow fall",
                75 => "Heavy intensity snow fall",
                77 => "Snow grains",
                80 => "Slight rain showers",
                81 => "Moderate rain showers",
                82 => "Violent rain showers",
                85 => "Slight snow showers",
                86 => "Heavy snow showers",
                95 => "Thunderstorm",
                96 => "Thunderstorm with slight hail",
                99 => "Thunderstorm with heavy hail",
                _ => "Unknown"
            };
    }
}
