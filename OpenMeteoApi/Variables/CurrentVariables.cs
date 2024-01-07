using OpenMeteoApi.Helpers;
using System.Text.Json.Serialization;

namespace OpenMeteoApi.Variables;

public static class CurrentVariables
{
    public static string[] All = VariablesHelper.GetAllVariables(typeof(CurrentVariables));

    public const string Temperature2m = "temperature_2m";

    public const string RelativeHumidity2m = "relative_humidity_2m";

    public const string ApparentTemperature = "apparent_temperature";

    public const string IsDay = "is_day";

    public const string Precipitation = "precipitation";

    public const string Rain = "rain";

    public const string Showers = "showers";

    public const string Snowfall = "snowfall";

    public const string WeatherCode = "weather_code";

    public const string CloudCover = "cloud_cover";

    public const string PressureMsl = "pressure_msl";

    public const string SurfacePressure = "surface_pressure";

    public const string WindSpeed10m = "wind_speed_10m";

    public const string WindDirection10m = "wind_direction_10m";

    public const string WindGusts10m = "wind_gusts_10m";
}