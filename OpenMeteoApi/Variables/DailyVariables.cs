using OpenMeteoApi.Helpers;
using System.Text.Json.Serialization;

namespace OpenMeteoApi.Variables;

public static class DailyVariables
{
    public static string[] All = VariablesHelper.GetAllVariables(typeof(DailyVariables));

    public const string WeatherCode = "weather_code";

    public const string Temperature2mMax = "temperature_2m_max";

    public const string Temperature2mMin = "temperature_2m_min";

    public const string ApparentTemperatureMax = "apparent_temperature_max";

    public const string ApparentTemperatureMin = "apparent_temperature_min";

    public const string Sunrise = "sunrise";

    public const string Sunset = "sunset";

    public const string DaylightDuration = "daylight_duration";

    public const string SunshineDuration = "sunshine_duration";

    public const string UvIndexMax = "uv_index_max";

    public const string UvIndexClearSkyMax = "uv_index_clear_sky_max";

    public const string PrecipitationSum = "precipitation_sum";

    public const string RainSum = "rain_sum";

    public const string ShowersSum = "showers_sum";

    public const string SnowfallSum = "snowfall_sum";

    public const string PrecipitationHours = "precipitation_hours";

    public const string PrecipitationProbabilityMax = "precipitation_probability_max";

    public const string WindSpeed10mMax = "wind_speed_10m_max";

    public const string WindGusts10mMax = "wind_gusts_10m_max";

    public const string WindDirection10mDominant = "wind_direction_10m_dominant";

    public const string ShortwaveRadiationSum = "shortwave_radiation_sum";

    public const string Et0FaoEvapotranspiration = "et0_fao_evapotranspiration";
}