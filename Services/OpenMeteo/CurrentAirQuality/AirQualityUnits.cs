using System.Text.Json.Serialization;

namespace Xcalibur.Weather.Models.Services.OpenMeteo.CurrentAirQuality
{
    /// <summary>
    /// Air Quality Units.
    /// </summary>
    public class AirQualityUnits
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
        public string? Interval { get; set; }
        /// <summary>
        /// Gets or sets the us aqi.
        /// </summary>
        /// <value>
        /// The us aqi.
        /// </value>
        [JsonPropertyName("us_aqi")] 
        public string? UsAqi { get; set; }
        /// <summary>
        /// Gets or sets the PM10.
        /// </summary>
        /// <value>
        /// The PM10.
        /// </value>
        [JsonPropertyName("pm10")] 
        public string? Pm10 { get; set; }
        /// <summary>
        /// Gets or sets the carbon monoxide.
        /// </summary>
        /// <value>
        /// The carbon monoxide.
        /// </value>
        [JsonPropertyName("carbon_monoxide")] 
        public string? CarbonMonoxide { get; set; }
        /// <summary>
        /// Gets or sets the PM25.
        /// </summary>
        /// <value>
        /// The PM25.
        /// </value>
        [JsonPropertyName("pm2_5")] 
        public string? Pm25 { get; set; }
        /// <summary>
        /// Gets or sets the nitrogen dioxide.
        /// </summary>
        /// <value>
        /// The nitrogen dioxide.
        /// </value>
        [JsonPropertyName("nitrogen_dioxide")] 
        public string? NitrogenDioxide { get; set; }
        /// <summary>
        /// Gets or sets the sulphur dioxide.
        /// </summary>
        /// <value>
        /// The sulphur dioxide.
        /// </value>
        [JsonPropertyName("sulphur_dioxide")] 
        public string? SulphurDioxide { get; set; }
        /// <summary>
        /// Gets or sets the ozone.
        /// </summary>
        /// <value>
        /// The ozone.
        /// </value>
        [JsonPropertyName("ozone")] 
        public string? Ozone { get; set; }
        /// <summary>
        /// Gets or sets the aerosol optical depth.
        /// </summary>
        /// <value>
        /// The aerosol optical depth.
        /// </value>
        [JsonPropertyName("aerosol_optical_depth")] 
        public string? AerosolOpticalDepth { get; set; }
        /// <summary>
        /// Gets or sets the dust.
        /// </summary>
        /// <value>
        /// The dust.
        /// </value>
        [JsonPropertyName("dust")] 
        public string? Dust { get; set; }
        /// <summary>
        /// Gets or sets the index of the uv.
        /// </summary>
        /// <value>
        /// The index of the uv.
        /// </value>
        [JsonPropertyName("uv_index")] 
        public string? UvIndex { get; set; }
        /// <summary>
        /// Gets or sets the uv index clear sky.
        /// </summary>
        /// <value>
        /// The uv index clear sky.
        /// </value>
        [JsonPropertyName("uv_index_clear_sky")] 
        public string? UvIndexClearSky { get; set; }
        /// <summary>
        /// Gets or sets the ammonia.
        /// </summary>
        /// <value>
        /// The ammonia.
        /// </value>
        [JsonPropertyName("ammonia")] 
        public string? Ammonia { get; set; }
        /// <summary>
        /// Gets or sets the alder pollen.
        /// </summary>
        /// <value>
        /// The alder pollen.
        /// </value>
        [JsonPropertyName("alder_pollen")] 
        public string? AlderPollen { get; set; }
        /// <summary>
        /// Gets or sets the birch pollen.
        /// </summary>
        /// <value>
        /// The birch pollen.
        /// </value>
        [JsonPropertyName("birch_pollen")] 
        public string? BirchPollen { get; set; }
        /// <summary>
        /// Gets or sets the grass pollen.
        /// </summary>
        /// <value>
        /// The grass pollen.
        /// </value>
        [JsonPropertyName("grass_pollen")] 
        public string? GrassPollen { get; set; }
        /// <summary>
        /// Gets or sets the mugwort pollen.
        /// </summary>
        /// <value>
        /// The mugwort pollen.
        /// </value>
        [JsonPropertyName("mugwort_pollen")] 
        public string? MugwortPollen { get; set; }
        /// <summary>
        /// Gets or sets the olive pollen.
        /// </summary>
        /// <value>
        /// The olive pollen.
        /// </value>
        [JsonPropertyName("olive_pollen")] 
        public string? OlivePollen { get; set; }
        /// <summary>
        /// Gets or sets the ragweed pollen.
        /// </summary>
        /// <value>
        /// The ragweed pollen.
        /// </value>
        [JsonPropertyName("ragweed_pollen")] 
        public string? RagweedPollen { get; set; }
    }
}
