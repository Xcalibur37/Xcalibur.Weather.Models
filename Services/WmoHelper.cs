namespace Xcalibur.Weather.Models.Services
{
    /// <summary>
    /// WMO (World Meteorological Organization) 4677 weather code helper methods.
    /// </summary>
    public static class WmoHelper
    {
        // WMO 4677 weather code descriptions.
        // https://www.nodc.noaa.gov/archive/arc0021/0002199/1.1/data/0-data/HTML/WMO-CODE/WMO4677.HTM
        private static readonly Dictionary<int, string> WeatherCodeDescriptions = new()
        {
            { 0,  "Clear sky" },
            { 1,  "Mainly clear" },
            { 2,  "Partly cloudy" },
            { 3,  "Overcast" },
            { 4,  "Smoke" },
            { 5,  "Haze" },
            { 6,  "Widespread dust" },
            { 7,  "Dust or sand whirls" },
            { 8,  "Dust or sand whirls" },
            { 9,  "Duststorm or sandstorm" },
            { 10, "Mist" },
            { 11, "Shallow fog or ice" },
            { 12, "Shallow fog or ice" },
            { 13, "Lightning visible" },
            { 14, "Precipitation in sight" },
            { 17, "Thunderstorm, no rain" },
            { 18, "Squalls" },
            { 19, "Funnel clouds" },
            { 20, "Drizzle, or snow grains" },
            { 21, "Rain" },
            { 22, "Snow" },
            { 23, "Rain and snow" },
            { 24, "Freezing rain" },
            { 25, "Rain showers" },
            { 26, "Snow showers" },
            { 27, "Hail showers" },
            { 28, "Fog" },
            { 29, "Thunderstorm" },
            { 30, "Slight duststorm or sandstorm" },
            { 31, "Moderate duststorm or sandstorm" },
            { 32, "Moderate duststorm or sandstorm" },
            { 33, "Severe duststorm or sandstorm" },
            { 34, "Severe duststorm or sandstorm" },
            { 35, "Severe duststorm or sandstorm" },
            { 36, "Moderate blowing snow" },
            { 37, "Heavy drifting snow" },
            { 38, "Moderate blowing snow" },
            { 39, "Heavy drifting snow" },
            { 40, "Fog" },
            { 41, "Fog" },
            { 42, "Fog" },
            { 43, "Fog" },
            { 44, "Fog" },
            { 45, "Fog" },
            { 46, "Fog" },
            { 47, "Fog" },
            { 48, "Fog" },
            { 49, "Fog" },
            { 50, "Light drizzle" },
            { 51, "Light drizzle" },
            { 52, "Moderate drizzle" },
            { 53, "Moderate drizzle" },
            { 54, "Dense intensity drizzle" },
            { 55, "Dense intensity drizzle" },
            { 56, "Light freezing drizzle" },
            { 57, "Dense intensity freezing drizzle" },
            { 58, "Drizzle and rain" },
            { 59, "Drizzle and rain" },
            { 60, "Slight rain" },
            { 61, "Slight rain" },
            { 62, "Moderate rain" },
            { 63, "Moderate rain" },
            { 64, "Heavy intensity rain" },
            { 65, "Heavy intensity rain" },
            { 66, "Light freezing rain" },
            { 67, "Heavy intensity freezing rain" },
            { 68, "Rain or drizzle and snow" },
            { 69, "Rain or drizzle and snow" },
            { 70, "Intermittent snow fall" },
            { 71, "Slight snow fall" },
            { 72, "Moderate snow fall" },
            { 73, "Moderate snow fall" },
            { 74, "Heavy intensity snow fall" },
            { 75, "Heavy intensity snow fall" },
            { 76, "Diamond dust" },
            { 77, "Snow grains" },
            { 78, "Snow crystals" },
            { 79, "Ice pellets" },
            { 80, "Slight rain showers" },
            { 81, "Moderate rain showers" },
            { 82, "Violent rain showers" },
            { 83, "Light rain/snow mix" },
            { 84, "Moderate rain/snow mix" },
            { 85, "Slight snow showers" },
            { 86, "Heavy snow showers" },
            { 87, "Snow pellets" },
            { 88, "Snow pellets" },
            { 89, "Hail" },
            { 90, "Hail" },
            { 91, "Slight rain" },
            { 92, "Moderate or heavy rain" },
            { 93, "Slight snow" },
            { 94, "Moderate or heavy snow" },
            { 95, "Thunderstorm" },
            { 96, "Thunderstorm with slight hail" },
            { 97, "Thunderstorm, heavy, no hail" },
            { 98, "Thunderstorm, dust or sandstorm" },
            { 99, "Thunderstorm with heavy hail" },
        };

        /// <summary>
        /// Gets the WMO weather code description.
        /// </summary>
        /// <param name="weatherCode">The WMO weather code.</param>
        /// <returns>A human-readable description of the weather condition.</returns>
        public static string GetWeatherCodeDescription(this int? weatherCode)
        {
            if (weatherCode is null) return "Unknown";

            // Get the description for the weather code, or return "Unknown" if the code is not recognized.
            var code = weatherCode.Value;
            return WeatherCodeDescriptions.GetValueOrDefault(code, "Unknown");
        }
    }
}
