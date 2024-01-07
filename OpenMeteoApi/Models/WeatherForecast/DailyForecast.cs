using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OpenMeteoApi.Models;

public class DailyForecast
{
    [JsonPropertyName("time")]
    public DateTime?[]? Time { get; set; }

    [JsonPropertyName("weather_code")]
    public int?[]? WeatherCode { get; set; }

    [JsonPropertyName("temperature_2m_max")]
    public float?[]? Temperature2mMax { get; set; }

    [JsonPropertyName("temperature_2m_min")]
    public float?[]? Temperature2mMin { get; set; }

    [JsonPropertyName("apparent_temperature_max")]
    public float?[]? ApparentTemperatureMax { get; set; }

    [JsonPropertyName("apparent_temperature_min")]
    public float?[]? ApparentTemperatureMin { get; set; }

    [JsonPropertyName("sunrise")]
    public string[]? Sunrise { get; set; }

    [JsonPropertyName("sunset")]
    public string[]? Sunset { get; set; }

    [JsonPropertyName("daylight_duration")]
    public float?[]? DaylightDuration { get; set; }

    [JsonPropertyName("sunshine_duration")]
    public float?[]? SunshineDuration { get; set; }

    [JsonPropertyName("uv_index_max")]
    public float?[]? UvIndexMax { get; set; }

    [JsonPropertyName("uv_index_clear_sky_max")]
    public float?[]? UvIndexClearSkyMax { get; set; }

    [JsonPropertyName("precipitation_sum")]
    public float?[]? PrecipitationSum { get; set; }

    [JsonPropertyName("rain_sum")]
    public float?[]? RainSum { get; set; }

    [JsonPropertyName("showers_sum")]
    public float?[]? ShowersSum { get; set; }

    [JsonPropertyName("snowfall_sum")]
    public float?[]? SnowfallSum { get; set; }

    [JsonPropertyName("precipitation_hours")]
    public float?[]? PrecipitationHours { get; set; }

    [JsonPropertyName("precipitation_probability_max")]
    public float?[]? PrecipitationProbabilityMax { get; set; }

    [JsonPropertyName("wind_speed_10m_max")]
    public float?[]? WindSpeed10mMax { get; set; }

    [JsonPropertyName("wind_gusts_10m_max")]
    public float?[]? WindGusts10mMax { get; set; }

    [JsonPropertyName("wind_direction_10m_dominant")]
    public int?[]? WindDirection10mDominant { get; set; }

    [JsonPropertyName("shortwave_radiation_sum")]
    public float?[]? ShortwaveRadiationSum { get; set; }

    [JsonPropertyName("et0_fao_evapotranspiration")]
    public float?[]? Et0FaoEvapotranspiration { get; set; }
}

public class DailyForecastItem
{
    public DailyForecastUnits? Units { get; set; }
    public DateTime? Time { get; set; }
    public int? WeatherCode { get; set; }

    public float? Temperature2mMax { get; set; }

    public float? Temperature2mMin { get; set; }

    public float? ApparentTemperatureMax { get; set; }

    public float? ApparentTemperatureMin { get; set; }

    public string? Sunrise { get; set; }

    public string? Sunset { get; set; }

    public float? DaylightDuration { get; set; }

    public float? SunshineDuration { get; set; }

    public float? UvIndexMax { get; set; }

    public float? UvIndexClearSkyMax { get; set; }

    public float? PrecipitationSum { get; set; }

    public float? RainSum { get; set; }

    public float? ShowersSum { get; set; }

    public float? SnowfallSum { get; set; }

    public float? PrecipitationHours { get; set; }

    public float? PrecipitationProbabilityMax { get; set; }

    public float? WindSpeed10mMax { get; set; }

    public float? WindGusts10mMax { get; set; }

    public int? WindDirection10mDominant { get; set; }

    public float? ShortwaveRadiationSum { get; set; }

    public float? Et0FaoEvapotranspiration { get; set; }
}
public class DailyForecastUnits
{

    [JsonPropertyName("time")]
    public string? Time { get; set; }

    [JsonPropertyName("weather_code")]
    public string? WeatherCode { get; set; }

    [JsonPropertyName("temperature_2m_max")]
    public string? Temperature2mMax { get; set; }

    [JsonPropertyName("temperature_2m_min")]
    public string? Temperature2mMin { get; set; }

    [JsonPropertyName("apparent_temperature_max")]
    public string? ApparentTemperatureMax { get; set; }

    [JsonPropertyName("apparent_temperature_min")]
    public string? ApparentTemperatureMin { get; set; }

    [JsonPropertyName("sunrise")]
    public string? Sunrise { get; set; }

    [JsonPropertyName("sunset")]
    public string? Sunset { get; set; }

    [JsonPropertyName("daylight_duration")]
    public string? DaylightDuration { get; set; }

    [JsonPropertyName("sunshine_duration")]
    public string? SunshineDuration { get; set; }

    [JsonPropertyName("uv_index_max")]
    public string? UvIndexMax { get; set; }

    [JsonPropertyName("uv_index_clear_sky_max")]
    public string? UvIndexClearSkyMax { get; set; }

    [JsonPropertyName("precipitation_sum")]
    public string? PrecipitationSum { get; set; }

    [JsonPropertyName("rain_sum")]
    public string? RainSum { get; set; }

    [JsonPropertyName("showers_sum")]
    public string? ShowersSum { get; set; }

    [JsonPropertyName("snowfall_sum")]
    public string? SnowfallSum { get; set; }

    [JsonPropertyName("precipitation_hours")]
    public string? PrecipitationHours { get; set; }

    [JsonPropertyName("precipitation_probability_max")]
    public string? PrecipitationProbabilityMax { get; set; }

    [JsonPropertyName("wind_speed_10m_max")]
    public string? WindSpeed10mMax { get; set; }

    [JsonPropertyName("wind_gusts_10m_max")]
    public string? WindGusts10mMax { get; set; }

    [JsonPropertyName("wind_direction_10m_dominant")]
    public string? WindDirection10mDominant { get; set; }

    [JsonPropertyName("shortwave_radiation_sum")]
    public string? ShortwaveRadiationSum { get; set; }

    [JsonPropertyName("et0_fao_evapotranspiration")]
    public string? Et0FaoEvapotranspiration { get; set; }
}