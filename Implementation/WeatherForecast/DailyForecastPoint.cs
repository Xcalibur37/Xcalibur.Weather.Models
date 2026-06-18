using System.Text.Json.Serialization;
using Xcalibur.Weather.Models.Implementation.Base;
using Xcalibur.Weather.Models.Services.OpenMeteo.DailyWeather;

namespace Xcalibur.Weather.Models.Implementation.WeatherForecast;

/// <summary>
/// Daily Forecast Point.
/// </summary>
/// <seealso cref="BaseForecastPoint" />
public class DailyForecastPoint : BaseForecastPoint
{
    #region Properties

    /// <summary>
    /// Gets or sets the date object.
    /// </summary>
    /// <value>
    /// The date object.
    /// </value>
    public DateOnly? DateObject { get; set; }

    /// <summary>
    /// Gets or sets the high temporary.
    /// </summary>
    /// <value>
    /// The high temporary.
    /// </value>
    public double? HighTemp { get; set; }

    /// <summary>
    /// Gets or sets the low temporary.
    /// </summary>
    /// <value>
    /// The low temporary.
    /// </value>
    public double? LowTemp { get; set; }

    /// <summary>
    /// Gets or sets the precipitation probability.
    /// </summary>
    /// <value>
    /// The precipitation probability.
    /// </value>
    public double? PrecipitationProbability { get; set; }

    /// <summary>
    /// Gets or sets the sunrise.
    /// </summary>
    /// <value>
    /// The sunrise.
    /// </value>
    public string? Sunrise { get; set; }

    /// <summary>
    /// Gets or sets the sunset.
    /// </summary>
    /// <value>
    /// The sunset.
    /// </value>
    public string? Sunset { get; set; }

    /// <summary>
    /// Gets or sets the duration of the daylight.
    /// </summary>
    /// <value>
    /// The duration of the daylight.
    /// </value>
    public double? DaylightDuration { get; set; }

    /// <summary>
    /// Gets or sets the duration of the sunshine.
    /// </summary>
    /// <value>
    /// The duration of the sunshine.
    /// </value>
    public double? SunshineDuration { get; set; }

    /// <summary>
    /// Gets or sets the rain sum.
    /// </summary>
    /// <value>
    /// The rain sum.
    /// </value>
    public double? RainSum { get; set; }

    /// <summary>
    /// Gets or sets the showers sum.
    /// </summary>
    /// <value>
    /// The showers sum.
    /// </value>
    public double? ShowersSum { get; set; }

    /// <summary>
    /// Gets or sets the snowfall sum.
    /// </summary>
    /// <value>
    /// The snowfall sum.
    /// </value>
    public double? SnowfallSum { get; set; }

    /// <summary>
    /// Gets or sets the precipitation sum.
    /// </summary>
    /// <value>
    /// The precipitation sum.
    /// </value>
    public double? PrecipitationSum { get; set; }

    /// <summary>
    /// Gets or sets the precipitation hours.
    /// </summary>
    /// <value>
    /// The precipitation hours.
    /// </value>
    public double? PrecipitationHours { get; set; }
    
    /// <summary>
    /// Gets or sets the wind speed10m maximum.
    /// </summary>
    /// <value>
    /// The wind speed10m maximum.
    /// </value>
    public double? WindSpeedMax { get; set; }

    /// <summary>
    /// Gets or sets the wind gusts10m maximum.
    /// </summary>
    /// <value>
    /// The wind gusts10m maximum.
    /// </value>
    public double? WindGustMax { get; set; }

    /// <summary>
    /// Gets or sets the uv index maximum.
    /// </summary>
    /// <value>
    /// The uv index maximum.
    /// </value>
    // ReSharper disable once InconsistentNaming
    public double? UVIndexMax { get; set; }

    #endregion

    #region Constructors

    /// <summary>
    /// Initializes a new instance of the <see cref="DailyForecastPoint"/> class.
    /// </summary>
    [JsonConstructor]
    public DailyForecastPoint()
    {
        
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="DailyForecastPoint" /> class.
    /// </summary>
    /// <param name="data">The data.</param>
    /// <param name="index">The index.</param>
    /// <param name="nowValue">The now value.</param>
    public DailyForecastPoint(DailyWeatherModel? data = null, int index = 0, string? nowValue = null)
    {
        if (data is null) return;
        Map(data, index, nowValue);
    }

    #endregion

    #region Methods

    /// <summary>
    /// Maps the specified data.
    /// </summary>
    /// <param name="data">The data.</param>
    /// <param name="index">The i.</param>
    /// <param name="nowValue">The now value.</param>
    private void Map(DailyWeatherModel? data, int index, string? nowValue = null)
    {
        if (data is null) return;
        
        // Date
        var dateValue = data.Time[index];
        DateValue = dateValue;
        DateObject = DateOnly.Parse(dateValue!);

        // Weather codes
        WeatherCode = data.WeatherCodes?[index];
        WeatherCodeValue = data.WeatherCodeValues?[index];

        // Temp starts in Celsius by default.
        HighTemp = data.TemperatureMax?[index];
        LowTemp = data.TemperatureMin?[index];

        // Sunrise and Sunset
        Sunrise = data.Sunrise?[index];
        Sunset = data.Sunset?[index];

        // Durations
        DaylightDuration = data.DaylightDuration?[index];
        SunshineDuration = data.SunshineDuration?[index];

        // Precipitation 
        RainSum = data.RainSum?[index];
        ShowersSum = data.ShowersSum?[index];
        SnowfallSum = data.SnowfallSum?[index];
        PrecipitationSum = data.PrecipitationSum?[index];
        PrecipitationHours = data.PrecipitationHours?[index];
        PrecipitationProbability = data.PrecipitationProbabilityMax?[index];

        // Wind
        WindSpeedMax = data.WindSpeedMax?[index];
        WindGustMax = data.WindGustsMax?[index];

        // UV Index
        UVIndexMax = data.UVIndexMax?[index];

        // Determine if this is the current day.
        IsCurrent = dateValue == nowValue;
    }

    #endregion
}

