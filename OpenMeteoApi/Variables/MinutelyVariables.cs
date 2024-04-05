using System.Text.Json.Serialization;

namespace OpenMeteoApi.Variables;

public static class MinutelyVariables
{
    public static string[] Standard = new[] {
        Temperature2m,
        RelativeHumidity2m,
        Precipitation,
        Rain,
        Snowfall,
        WeatherCode,
        Visibility,
        WindSpeed10m,
        WindGusts10m,
        WindDirection10m,
    };
    public const string Time = "time";

    public const string Temperature2m = "temperature_2m";

    public const string RelativeHumidity2m = "relative_humidity_2m";

    public const string DewPoint2m = "dew_point_2m";

    public const string ApparentTemperature = "apparent_temperature";

    public const string Precipitation = "precipitation";

    public const string Rain = "rain";

    public const string Snowfall = "snowfall";

    public const string SnowfallHeight = "snowfall_height";

    public const string FreezingLevelHeight = "freezing_level_height";

    public const string SunshineDuration = "sunshine_duration";

    public const string WeatherCode = "weather_code";

    public const string WindSpeed10m = "wind_speed_10m";

    public const string WindSpeed80m = "wind_speed_80m";

    public const string WindDirection10m = "wind_direction_10m";

    public const string WindDirection80m = "wind_direction_80m";

    public const string WindGusts10m = "wind_gusts_10m";

    public const string Visibility = "visibility";

    public const string Cape = "cape";

    public const string LightningPotential = "lightning_potential";

    public const string IsDay = "is_day";

    public const string ShortwaveRadiation = "shortwave_radiation";

    public const string DirectRadiation = "direct_radiation";

    public const string DiffuseRadiation = "diffuse_radiation";

    public const string DirectNormalIrradiance = "direct_normal_irradiance";

    public const string GlobalTiltedIrradiance = "global_tilted_irradiance";

    public const string TerrestrialRadiation = "terrestrial_radiation";

    public const string ShortwaveRadiationInstant = "shortwave_radiation_instant";

    public const string DirectRadiationInstant = "direct_radiation_instant";

    public const string DiffuseRadiationInstant = "diffuse_radiation_instant";

    public const string DirectNormalIrradianceInstant = "direct_normal_irradiance_instant";

    public const string GlobalTiltedIrradianceInstant = "global_tilted_irradiance_instant";

    public const string TerrestrialRadiationInstant = "terrestrial_radiation_instant";
}