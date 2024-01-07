using OpenMeteoApi.Helpers;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OpenMeteoApi.Models;

public class HourlyForecast
{
    [JsonPropertyName("time")]
    public DateTime?[]? Time { get; set; }

    [JsonPropertyName("temperature_2m")]
    public float?[]? Temperature2m { get; set; }

    [JsonPropertyName("relative_humidity_2m")]
    public int?[]? RelativeHumidity2m { get; set; }

    [JsonPropertyName("dew_point_2m")]
    public float?[]? DewPoint2m { get; set; }

    [JsonPropertyName("apparent_temperature")]
    public float?[]? ApparentTemperature { get; set; }

    [JsonPropertyName("precipitation_probability")]
    public int?[]? PrecipitationProbability { get; set; }

    [JsonPropertyName("precipitation")]
    public float?[]? Precipitation { get; set; }

    [JsonPropertyName("rain")]
    public float?[]? Rain { get; set; }

    [JsonPropertyName("showers")]
    public float?[]? Showers { get; set; }

    [JsonPropertyName("snowfall")]
    public float?[]? Snowfall { get; set; }

    [JsonPropertyName("snow_depth")]
    public float?[]? SnowDepth { get; set; }

    [JsonPropertyName("weather_code")]
    public int?[]? WeatherCode { get; set; }

    [JsonPropertyName("pressure_msl")]
    public float?[]? PressureMsl { get; set; }

    [JsonPropertyName("surface_pressure")]
    public float?[]? SurfacePressure { get; set; }

    [JsonPropertyName("cloud_cover")]
    public int?[]? CloudCover { get; set; }

    [JsonPropertyName("cloud_cover_low")]
    public int?[]? CloudCoverLow { get; set; }

    [JsonPropertyName("cloud_cover_mid")]
    public int?[]? CloudCoverMid { get; set; }

    [JsonPropertyName("cloud_cover_high")]
    public int?[]? CloudCoverHigh { get; set; }

    [JsonPropertyName("visibility")]
    public float?[]? Visibility { get; set; }

    [JsonPropertyName("evapotranspiration")]
    public float?[]? Evapotranspiration { get; set; }

    [JsonPropertyName("et0_fao_evapotranspiration")]
    public float?[]? Et0FaoEvapotranspiration { get; set; }

    [JsonPropertyName("vapour_pressure_deficit")]
    public float?[]? VapourPressureDeficit { get; set; }

    [JsonPropertyName("wind_speed_10m")]
    public float?[]? WindSpeed10m { get; set; }

    [JsonPropertyName("wind_speed_80m")]
    public float?[]? WindSpeed80m { get; set; }

    [JsonPropertyName("wind_speed_120m")]
    public float?[]? WindSpeed120m { get; set; }

    [JsonPropertyName("wind_speed_180m")]
    public float?[]? WindSpeed180m { get; set; }

    [JsonPropertyName("wind_direction_10m")]
    public int?[]? WindDirection10m { get; set; }

    [JsonPropertyName("wind_direction_80m")]
    public int?[]? WindDirection80m { get; set; }

    [JsonPropertyName("wind_direction_120m")]
    public int?[]? WindDirection120m { get; set; }

    [JsonPropertyName("wind_direction_180m")]
    public int?[]? WindDirection180m { get; set; }

    [JsonPropertyName("wind_gusts_10m")]
    public float?[]? WindGusts10m { get; set; }

    [JsonPropertyName("temperature_80m")]
    public float?[]? Temperature80m { get; set; }

    [JsonPropertyName("temperature_120m")]
    public float?[]? Temperature120m { get; set; }

    [JsonPropertyName("temperature_180m")]
    public float?[]? Temperature180m { get; set; }

    [JsonPropertyName("soil_temperature_0cm")]
    public float?[]? SoilTemperature0cm { get; set; }

    [JsonPropertyName("soil_temperature_6cm")]
    public float?[]? SoilTemperature6cm { get; set; }

    [JsonPropertyName("soil_temperature_18cm")]
    public float?[]? SoilTemperature18cm { get; set; }

    [JsonPropertyName("soil_temperature_54cm")]
    public float?[]? SoilTemperature54cm { get; set; }

    [JsonPropertyName("soil_moisture_0_to_1cm")]
    public float?[]? SoilMoisture0To1cm { get; set; }

    [JsonPropertyName("soil_moisture_1_to_3cm")]
    public float?[]? SoilMoisture1To3cm { get; set; }

    [JsonPropertyName("soil_moisture_3_to_9cm")]
    public float?[]? SoilMoisture3To9cm { get; set; }

    [JsonPropertyName("soil_moisture_9_to_27cm")]
    public float?[]? SoilMoisture9To27cm { get; set; }

    [JsonPropertyName("soil_moisture_27_to_81cm")]
    public float?[]? SoilMoisture27To81cm { get; set; }

    #region Additional Variables
    [JsonPropertyName("uv_index")]
    public float?[]? UvIndex { get; set; }

    [JsonPropertyName("uv_index_clear_sky")]
    public float?[]? UvIndexClearSky { get; set; }

    [JsonPropertyName("is_day")]
    public int?[]? IsDay { get; set; }

    [JsonPropertyName("cape")]
    public float?[]? Cape { get; set; }

    [JsonPropertyName("freezing_level_height")]
    public float?[]? FreezingLevelHeight { get; set; }

    [JsonPropertyName("sunshine_duration")]
    public float?[]? SunshineDuration { get; set; }

    [JsonPropertyName("shortwave_radiation")]
    public float?[]? ShortwaveRadiation { get; set; }

    [JsonPropertyName("direct_radiation")]
    public float?[]? DirectRadiation { get; set; }

    [JsonPropertyName("diffuse_radiation")]
    public float?[]? DiffuseRadiation { get; set; }

    [JsonPropertyName("direct_normal_irradiance")]
    public float?[]? DirectNormalIrradiance { get; set; }

    [JsonPropertyName("terrestrial_radiation")]
    public float?[]? TerrestrialRadiation { get; set; }

    [JsonPropertyName("shortwave_radiation_instant")]
    public float?[]? ShortwaveRadiationInstant { get; set; }

    [JsonPropertyName("direct_radiation_instant")]
    public float?[]? DirectRadiationInstant { get; set; }

    [JsonPropertyName("diffuse_radiation_instant")]
    public float?[]? DiffuseRadiationInstant { get; set; }

    [JsonPropertyName("direct_normal_irradiance_instant")]
    public float?[]? DirectNormalIrradianceInstant { get; set; }

    [JsonPropertyName("terrestrial_radiation_instant")]
    public float?[]? TerrestrialRadiationInstant { get; set; }
    #endregion
}
public class HourlyForecastItem
{
    public HourlyForecastUnits? Units { get; set; }
    public DateTime? Time { get; set; }

    public float? Temperature2m { get; set; }

    public int? RelativeHumidity2m { get; set; }

    public float? DewPoint2m { get; set; }

    public float? ApparentTemperature { get; set; }

    public int? PrecipitationProbability { get; set; }

    public float? Precipitation { get; set; }

    public float? Rain { get; set; }

    public float? Showers { get; set; }

    public float? Snowfall { get; set; }

    public float? SnowDepth { get; set; }

    public int? WeatherCode { get; set; }

    public float? PressureMsl { get; set; }

    public float? SurfacePressure { get; set; }

    public int? CloudCover { get; set; }

    public int? CloudCoverLow { get; set; }

    public int? CloudCoverMid { get; set; }

    public int? CloudCoverHigh { get; set; }

    public float? Visibility { get; set; }

    public float? Evapotranspiration { get; set; }

    public float? Et0FaoEvapotranspiration { get; set; }

    public float? VapourPressureDeficit { get; set; }

    public float? WindSpeed10m { get; set; }

    public float? WindSpeed80m { get; set; }

    public float? WindSpeed120m { get; set; }

    public float? WindSpeed180m { get; set; }

    public int? WindDirection10m { get; set; }

    public int? WindDirection80m { get; set; }

    public int? WindDirection120m { get; set; }

    public int? WindDirection180m { get; set; }

    public float? WindGusts10m { get; set; }

    public float? Temperature80m { get; set; }

    public float? Temperature120m { get; set; }

    public float? Temperature180m { get; set; }

    public float? SoilTemperature0cm { get; set; }

    public float? SoilTemperature6cm { get; set; }

    public float? SoilTemperature18cm { get; set; }

    public float? SoilTemperature54cm { get; set; }

    public float? SoilMoisture0To1cm { get; set; }

    public float? SoilMoisture1To3cm { get; set; }

    public float? SoilMoisture3To9cm { get; set; }

    public float? SoilMoisture9To27cm { get; set; }

    public float? SoilMoisture27To81cm { get; set; }

    #region Additional Variables
    public float? UvIndex { get; set; }

    public float? UvIndexClearSky { get; set; }

    public int? IsDay { get; set; }

    public float? Cape { get; set; }

    public float? FreezingLevelHeight { get; set; }

    public float? SunshineDuration { get; set; }

    public float? ShortwaveRadiation { get; set; }

    public float? DirectRadiation { get; set; }

    public float? DiffuseRadiation { get; set; }

    public float? DirectNormalIrradiance { get; set; }

    public float? TerrestrialRadiation { get; set; }

    public float? ShortwaveRadiationInstant { get; set; }

    public float? DirectRadiationInstant { get; set; }

    public float? DiffuseRadiationInstant { get; set; }

    public float? DirectNormalIrradianceInstant { get; set; }

    public float? TerrestrialRadiationInstant { get; set; }
    #endregion
}

public class HourlyForecastUnits
{

    [JsonPropertyName("time")]
    public string? Time { get; set; }

    [JsonPropertyName("temperature_2m")]
    public string? Temperature2m { get; set; }

    [JsonPropertyName("relative_humidity_2m")]
    public string? RelativeHumidity2m { get; set; }

    [JsonPropertyName("dew_point_2m")]
    public string? DewPoint2m { get; set; }

    [JsonPropertyName("apparent_temperature")]
    public string? ApparentTemperature { get; set; }

    [JsonPropertyName("precipitation_probability")]
    public string? PrecipitationProbability { get; set; }

    [JsonPropertyName("precipitation")]
    public string? Precipitation { get; set; }

    [JsonPropertyName("rain")]
    public string? Rain { get; set; }

    [JsonPropertyName("showers")]
    public string? Showers { get; set; }

    [JsonPropertyName("snowfall")]
    public string? Snowfall { get; set; }

    [JsonPropertyName("snow_depth")]
    public string? SnowDepth { get; set; }

    [JsonPropertyName("weather_code")]
    public string? WeatherCode { get; set; }

    [JsonPropertyName("pressure_msl")]
    public string? PressureMsl { get; set; }

    [JsonPropertyName("surface_pressure")]
    public string? SurfacePressure { get; set; }

    [JsonPropertyName("cloud_cover")]
    public string? CloudCover { get; set; }

    [JsonPropertyName("cloud_cover_low")]
    public string? CloudCoverLow { get; set; }

    [JsonPropertyName("cloud_cover_mid")]
    public string? CloudCoverMid { get; set; }

    [JsonPropertyName("cloud_cover_high")]
    public string? CloudCoverHigh { get; set; }

    [JsonPropertyName("visibility")]
    public string? Visibility { get; set; }

    [JsonPropertyName("evapotranspiration")]
    public string? Evapotranspiration { get; set; }

    [JsonPropertyName("et0_fao_evapotranspiration")]
    public string? Et0FaoEvapotranspiration { get; set; }

    [JsonPropertyName("vapour_pressure_deficit")]
    public string? VapourPressureDeficit { get; set; }

    [JsonPropertyName("wind_speed_10m")]
    public string? WindSpeed10m { get; set; }

    [JsonPropertyName("wind_speed_80m")]
    public string? WindSpeed80m { get; set; }

    [JsonPropertyName("wind_speed_120m")]
    public string? WindSpeed120m { get; set; }

    [JsonPropertyName("wind_speed_180m")]
    public string? WindSpeed180m { get; set; }

    [JsonPropertyName("wind_direction_10m")]
    public string? WindDirection10m { get; set; }

    [JsonPropertyName("wind_direction_80m")]
    public string? WindDirection80m { get; set; }

    [JsonPropertyName("wind_direction_120m")]
    public string? WindDirection120m { get; set; }

    [JsonPropertyName("wind_direction_180m")]
    public string? WindDirection180m { get; set; }

    [JsonPropertyName("wind_gusts_10m")]
    public string? WindGusts10m { get; set; }

    [JsonPropertyName("temperature_80m")]
    public string? Temperature80m { get; set; }

    [JsonPropertyName("temperature_120m")]
    public string? Temperature120m { get; set; }

    [JsonPropertyName("temperature_180m")]
    public string? Temperature180m { get; set; }

    [JsonPropertyName("soil_temperature_0cm")]
    public string? SoilTemperature0cm { get; set; }

    [JsonPropertyName("soil_temperature_6cm")]
    public string? SoilTemperature6cm { get; set; }

    [JsonPropertyName("soil_temperature_18cm")]
    public string? SoilTemperature18cm { get; set; }

    [JsonPropertyName("soil_temperature_54cm")]
    public string? SoilTemperature54cm { get; set; }

    [JsonPropertyName("soil_moisture_0_to_1cm")]
    public string? SoilMoisture0To1cm { get; set; }

    [JsonPropertyName("soil_moisture_1_to_3cm")]
    public string? SoilMoisture1To3cm { get; set; }

    [JsonPropertyName("soil_moisture_3_to_9cm")]
    public string? SoilMoisture3To9cm { get; set; }

    [JsonPropertyName("soil_moisture_9_to_27cm")]
    public string? SoilMoisture9To27cm { get; set; }

    [JsonPropertyName("soil_moisture_27_to_81cm")]
    public string? SoilMoisture27To81cm { get; set; }
}
