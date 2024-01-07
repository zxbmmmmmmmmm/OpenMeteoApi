using OpenMeteoApi.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text.Json.Serialization;

namespace OpenMeteoApi.Variables;

public static class HourlyVariables
{
    public static string[] All = VariablesHelper.GetAllVariables(typeof(HourlyVariables));
    public static string[] Standard = new[] {
        Temperature2m,
        RelativeHumidity2m,
        PrecipitationProbability,
        Precipitation,
        Rain,
        Showers,
        Snowfall,
        SnowDepth,
        WeatherCode,
        PressureMsl,
        SurfacePressure,
        CloudCover,
        Visibility,
        WindSpeed10m,
        WindGusts10m,
        WindDirection10m,
        UvIndex
    };

    public const string Temperature2m = "temperature_2m";

    public const string RelativeHumidity2m = "relative_humidity_2m";

    public const string ApparentTemperature = "apparent_temperature";

    public const string PrecipitationProbability = "precipitation_probability";

    public const string Precipitation = "precipitation";

    public const string Rain = "rain";

    public const string Showers = "showers";

    public const string Snowfall = "snowfall";

    public const string SnowDepth = "snow_depth";

    public const string WeatherCode = "weather_code";

    public const string PressureMsl = "pressure_msl";

    public const string SurfacePressure = "surface_pressure";

    public const string CloudCover = "cloud_cover";

    public const string CloudCoverLow = "cloud_cover_low";

    public const string CloudCoverMid = "cloud_cover_mid";

    public const string CloudCoverHigh = "cloud_cover_high";

    public const string Visibility = "visibility";

    public const string Evapotranspiration = "evapotranspiration";

    public const string Et0FaoEvapotranspiration = "et0_fao_evapotranspiration";

    public const string VapourPressureDeficit = "vapour_pressure_deficit";

    public const string WindSpeed10m = "wind_speed_10m";

    public const string WindSpeed80m = "wind_speed_80m";

    public const string WindSpeed120m = "wind_speed_120m";

    public const string WindSpeed180m = "wind_speed_180m";

    public const string WindDirection10m = "wind_direction_10m";

    public const string WindDirection80m = "wind_direction_80m";

    public const string WindDirection120m = "wind_direction_120m";

    public const string WindDirection180m = "wind_direction_180m";

    public const string WindGusts10m = "wind_gusts_10m";

    public const string Temperature80m = "temperature_80m";

    public const string Temperature120m = "temperature_120m";

    public const string Temperature180m = "temperature_180m";

    public const string SoilTemperature0cm = "soil_temperature_0cm";

    public const string SoilTemperature6cm = "soil_temperature_6cm";

    public const string SoilTemperature18cm = "soil_temperature_18cm";

    public const string SoilTemperature54cm = "soil_temperature_54cm";

    public const string SoilMoisture0To1cm = "soil_moisture_0_to_1cm";

    public const string SoilMoisture1To3cm = "soil_moisture_1_to_3cm";

    public const string SoilMoisture3To9cm = "soil_moisture_3_to_9cm";

    public const string SoilMoisture9To27cm = "soil_moisture_9_to_27cm";

    public const string SoilMoisture27To81cm = "soil_moisture_27_to_81cm";

    #region Additional Variables
    public const string UvIndex = "uv_index";

    public const string UvIndexClearSky = "uv_index_clear_sky";

    public const string IsDay = "is_day";

    public const string Cape = "cape";

    public const string FreezingLevelHeight = "freezing_level_height";

    public const string SunshineDuration = "sunshine_duration";

    public const string ShortwaveRadiation = "shortwave_radiation";

    public const string DirectRadiation = "direct_radiation";

    public const string DiffuseRadiation = "diffuse_radiation";

    public const string DirectNormalIrradiance = "direct_normal_irradiance";

    public const string TerrestrialRadiation = "terrestrial_radiation";

    public const string ShortwaveRadiationInstant = "shortwave_radiation_instant";

    public const string DirectRadiationInstant = "direct_radiation_instant";

    public const string DiffuseRadiationInstant = "diffuse_radiation_instant";

    public const string DirectNormalIrradianceInstant = "direct_normal_irradiance_instant";

    public const string TerrestrialRadiationInstant = "terrestrial_radiation_instant";
    #endregion
}
