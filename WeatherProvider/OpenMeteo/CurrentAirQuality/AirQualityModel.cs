using System.Text.Json.Serialization;

namespace Xcalibur.Weather.Models.WeatherProvider.OpenMeteo.CurrentAirQuality
{
    /// <summary>
    /// Air Quality Model.
    /// </summary>
    public class AirQualityModel
    {
        /// <summary>
        /// Gets or sets the time.
        /// </summary>
        /// <value>
        /// The time.
        /// </value>
        [JsonPropertyName("time")]
        public string? Time { get; set; }

        /// <summary>
        /// Gets or sets the interval.
        /// </summary>
        /// <value>
        /// The interval.
        /// </value>
        [JsonPropertyName("interval")]
        public int Interval { get; set; }

        /// <summary>
        /// Gets or sets the us aqi.
        /// </summary>
        /// <value>
        /// The us aqi.
        /// </value>
        [JsonPropertyName("us_aqi")]
        public int? UsAqi { get; set; }

        /// <summary>
        /// Gets or sets the PM10.
        /// </summary>
        /// <value>
        /// The PM10.
        /// </value>
        [JsonPropertyName("pm10")]
        public double? Pm10 { get; set; }

        /// <summary>
        /// Gets or sets the carbon monoxide.
        /// </summary>
        /// <value>
        /// The carbon monoxide.
        /// </value>
        [JsonPropertyName("carbon_monoxide")]
        public double? CarbonMonoxide { get; set; }

        /// <summary>
        /// Gets or sets the PM2 5.
        /// </summary>
        /// <value>
        /// The PM2 5.
        /// </value>
        [JsonPropertyName("pm2_5")]
        public double? Pm2_5 { get; set; }

        /// <summary>
        /// Gets or sets the nitrogen dioxide.
        /// </summary>
        /// <value>
        /// The nitrogen dioxide.
        /// </value>
        [JsonPropertyName("nitrogen_dioxide")]
        public double? NitrogenDioxide { get; set; }

        /// <summary>
        /// Gets or sets the sulphur dioxide.
        /// </summary>
        /// <value>
        /// The sulphur dioxide.
        /// </value>
        [JsonPropertyName("sulphur_dioxide")]
        public double? SulphurDioxide { get; set; }

        /// <summary>
        /// Gets or sets the ozone.
        /// </summary>
        /// <value>
        /// The ozone.
        /// </value>
        [JsonPropertyName("ozone")]
        public double? Ozone { get; set; }

        /// <summary>
        /// Gets or sets the aerosol optical depth.
        /// </summary>
        /// <value>
        /// The aerosol optical depth.
        /// </value>
        [JsonPropertyName("aerosol_optical_depth")]
        public double? AerosolOpticalDepth { get; set; }

        /// <summary>
        /// Gets or sets the dust.
        /// </summary>
        /// <value>
        /// The dust.
        /// </value>
        [JsonPropertyName("dust")]
        public double? Dust { get; set; }

        /// <summary>
        /// Gets or sets the index of the uv.
        /// </summary>
        /// <value>
        /// The index of the uv.
        /// </value>
        [JsonPropertyName("uv_index")]
        public double? UvIndex { get; set; }

        /// <summary>
        /// Gets or sets the uv index clear sky.
        /// </summary>
        /// <value>
        /// The uv index clear sky.
        /// </value>
        [JsonPropertyName("uv_index_clear_sky")]
        public double? UvIndexClearSky { get; set; }

        /// <summary>
        /// Gets or sets the ammonia.
        /// </summary>
        /// <value>
        /// The ammonia.
        /// </value>
        [JsonPropertyName("ammonia")]
        public double? Ammonia { get; set; }

        /// <summary>
        /// Gets or sets the alder pollen.
        /// </summary>
        /// <value>
        /// The alder pollen.
        /// </value>
        [JsonPropertyName("alder_pollen")]
        public double? AlderPollen { get; set; }

        /// <summary>
        /// Gets or sets the birch pollen.
        /// </summary>
        /// <value>
        /// The birch pollen.
        /// </value>
        [JsonPropertyName("birch_pollen")]
        public double? BirchPollen { get; set; }

        /// <summary>
        /// Gets or sets the grass pollen.
        /// </summary>
        /// <value>
        /// The grass pollen.
        /// </value>
        [JsonPropertyName("grass_pollen")]
        public double? GrassPollen { get; set; }

        /// <summary>
        /// Gets or sets the mugwort pollen.
        /// </summary>
        /// <value>
        /// The mugwort pollen.
        /// </value>
        [JsonPropertyName("mugwort_pollen")]
        public double? MugwortPollen { get; set; }

        /// <summary>
        /// Gets or sets the olive pollen.
        /// </summary>
        /// <value>
        /// The olive pollen.
        /// </value>
        [JsonPropertyName("olive_pollen")]
        public double? OlivePollen { get; set; }

        /// <summary>
        /// Gets or sets the ragweed pollen.
        /// </summary>
        /// <value>
        /// The ragweed pollen.
        /// </value>
        [JsonPropertyName("ragweed_pollen")]
        public double? RagweedPollen { get; set; }
    }
}
