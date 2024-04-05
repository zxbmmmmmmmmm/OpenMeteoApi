using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OpenMeteoApi.Models;

public class MinutelyForecast
{
    [JsonPropertyName("time")]
    public string?[]? Time { get; set; }

    [JsonPropertyName("temperature_2m")]
    public float?[]? Temperature2m { get; set; }

    [JsonPropertyName("relative_humidity_2m")]
    public float?[]? RelativeHumidity2m { get; set; }

    [JsonPropertyName("dew_point_2m")]
    public float?[]? DewPoint2m { get; set; }

    [JsonPropertyName("apparent_temperature")]
    public float?[]? ApparentTemperature { get; set; }

    [JsonPropertyName("precipitation")]
    public float?[]? Precipitation { get; set; }

    [JsonPropertyName("rain")]
    public float?[]? Rain { get; set; }

    [JsonPropertyName("snowfall")]
    public float?[]? Snowfall { get; set; }

    [JsonPropertyName("snowfall_height")]
    public float?[]? SnowfallHeight { get; set; }

    [JsonPropertyName("freezing_level_height")]
    public float?[]? FreezingLevelHeight { get; set; }

    [JsonPropertyName("sunshine_duration")]
    public float?[]? SunshineDuration { get; set; }

    [JsonPropertyName("weather_code")]
    public int?[]? WeatherCode { get; set; }

    [JsonPropertyName("wind_speed_10m")]
    public float?[]? WindSpeed10m { get; set; }

    [JsonPropertyName("wind_speed_80m")]
    public float?[]? WindSpeed80m { get; set; }

    [JsonPropertyName("wind_direction_10m")]
    public int?[]? WindDirection10m { get; set; }

    [JsonPropertyName("wind_direction_80m")]
    public int?[]? WindDirection80m { get; set; }

    [JsonPropertyName("wind_gusts_10m")]
    public float?[]? WindGusts10m { get; set; }

    [JsonPropertyName("visibility")]
    public float?[]? Visibility { get; set; }

    [JsonPropertyName("cape")]
    public float?[]? Cape { get; set; }

    [JsonPropertyName("lightning_potential")]
    public float?[]? LightningPotential { get; set; }

    [JsonPropertyName("is_day")]
    public float?[]? IsDay { get; set; }

    [JsonPropertyName("shortwave_radiation")]
    public float?[]? ShortwaveRadiation { get; set; }

    [JsonPropertyName("direct_radiation")]
    public float?[]? DirectRadiation { get; set; }

    [JsonPropertyName("diffuse_radiation")]
    public float?[]? DiffuseRadiation { get; set; }

    [JsonPropertyName("direct_normal_irradiance")]
    public float?[]? DirectNormalIrradiance { get; set; }

    [JsonPropertyName("global_tilted_irradiance")]
    public float?[]? GlobalTiltedIrradiance { get; set; }

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

    [JsonPropertyName("global_tilted_irradiance_instant")]
    public float?[]? GlobalTiltedIrradianceInstant { get; set; }

    [JsonPropertyName("terrestrial_radiation_instant")]
    public float?[]? TerrestrialRadiationInstant { get; set; }
}
public class MinutelyForecastItem
{
    public string? Time { get; set; }

    public float? Temperature2m { get; set; }

    public float? RelativeHumidity2m { get; set; }

    public float? DewPoint2m { get; set; }

    public float? ApparentTemperature { get; set; }

    public float? Precipitation { get; set; }

    public float? Rain { get; set; }

    public float? Snowfall { get; set; }

    public float? SnowfallHeight { get; set; }

    public float? FreezingLevelHeight { get; set; }

    public float? SunshineDuration { get; set; }

    public float? WeatherCode { get; set; }

    public float? WindSpeed10m { get; set; }

    public float? WindSpeed80m { get; set; }

    public float? WindDirection10m { get; set; }

    public float? WindDirection80m { get; set; }

    public float? WindGusts10m { get; set; }

    public float? Visibility { get; set; }

    public float? Cape { get; set; }

    public float? LightningPotential { get; set; }

    public float? IsDay { get; set; }

    public float? ShortwaveRadiation { get; set; }

    public float? DirectRadiation { get; set; }

    public float? DiffuseRadiation { get; set; }

    public float? DirectNormalIrradiance { get; set; }

    public float? GlobalTiltedIrradiance { get; set; }

    public float? TerrestrialRadiation { get; set; }

    public float? ShortwaveRadiationInstant { get; set; }

    public float? DirectRadiationInstant { get; set; }

    public float? DiffuseRadiationInstant { get; set; }

    public float? DirectNormalIrradianceInstant { get; set; }

    public float? GlobalTiltedIrradianceInstant { get; set; }

    public float? TerrestrialRadiationInstant { get; set; }
}

public class MinutelyForecastUnits
{
    public string? Time { get; set; }

    public string? Temperature2m { get; set; }

    public string? RelativeHumidity2m { get; set; }

    public string? DewPoint2m { get; set; }

    public string? ApparentTemperature { get; set; }

    public string? Precipitation { get; set; }

    public string? Rain { get; set; }

    public string? Snowfall { get; set; }

    public string? SnowfallHeight { get; set; }

    public string? FreezingLevelHeight { get; set; }

    public string? SunshineDuration { get; set; }

    public string? WeatherCode { get; set; }

    public string? WindSpeed10m { get; set; }

    public string? WindSpeed80m { get; set; }

    public string? WindDirection10m { get; set; }

    public string? WindDirection80m { get; set; }

    public string? WindGusts10m { get; set; }

    public string? Visibility { get; set; }

    public string? Cape { get; set; }

    public string? LightningPotential { get; set; }

    public string? IsDay { get; set; }

    public string? ShortwaveRadiation { get; set; }

    public string? DirectRadiation { get; set; }

    public string? DiffuseRadiation { get; set; }

    public string? DirectNormalIrradiance { get; set; }

    public string? GlobalTiltedIrradiance { get; set; }

    public string? TerrestrialRadiation { get; set; }

    public string? ShortwaveRadiationInstant { get; set; }

    public string? DirectRadiationInstant { get; set; }

    public string? DiffuseRadiationInstant { get; set; }

    public string? DirectNormalIrradianceInstant { get; set; }

    public string? GlobalTiltedIrradianceInstant { get; set; }

    public string? TerrestrialRadiationInstant { get; set; }
}