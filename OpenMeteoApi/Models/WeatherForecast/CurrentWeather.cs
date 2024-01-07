using OpenMeteoApi.Helpers;
using System.Text.Json.Serialization;

namespace OpenMeteoApi.Models;

public class CurrentWeather
{
    [JsonPropertyName("time")]
    public string? Time { get; set; }

    [JsonPropertyName("interval")]
    public int? Interval { get; set; }

    [JsonPropertyName("temperature_2m")]
    public float? Temperature2m { get; set; }

    [JsonPropertyName("relative_humidity_2m")]
    public int? RelativeHumidity2m { get; set; }

    [JsonPropertyName("apparent_temperature")]
    public float? ApparentTemperature { get; set; }

    [JsonPropertyName("is_day")]
    public int? IsDay { get; set; }

    [JsonPropertyName("precipitation")]
    public float? Precipitation { get; set; }

    [JsonPropertyName("rain")]
    public float? Rain { get; set; }

    [JsonPropertyName("showers")]
    public float? Showers { get; set; }

    [JsonPropertyName("snowfall")]
    public float? Snowfall { get; set; }

    [JsonPropertyName("weather_code")]
    public int? WeatherCode { get; set; }

    [JsonPropertyName("cloud_cover")]
    public int? CloudCover { get; set; }

    [JsonPropertyName("pressure_msl")]
    public float? PressureMsl { get; set; }

    [JsonPropertyName("surface_pressure")]
    public float? SurfacePressure { get; set; }

    [JsonPropertyName("wind_speed_10m")]
    public float? WindSpeed10m { get; set; }

    [JsonPropertyName("wind_direction_10m")]
    public int? WindDirection10m { get; set; }

    [JsonPropertyName("wind_gusts_10m")]
    public float? WindGusts10m { get; set; }
}

public class CurrentWeatherUnits
{

    [JsonPropertyName("time")]
    public string? Time { get; set; }

    [JsonPropertyName("interval")]
    public string? Interval { get; set; }

    [JsonPropertyName("temperature_2m")]
    public string? Temperature2m { get; set; }

    [JsonPropertyName("relative_humidity_2m")]
    public string? RelativeHumidity2m { get; set; }

    [JsonPropertyName("apparent_temperature")]
    public string? ApparentTemperature { get; set; }

    [JsonPropertyName("is_day")]
    public string? IsDay { get; set; }

    [JsonPropertyName("precipitation")]
    public string? Precipitation { get; set; }

    [JsonPropertyName("rain")]
    public string? Rain { get; set; }

    [JsonPropertyName("showers")]
    public string? Showers { get; set; }

    [JsonPropertyName("snowfall")]
    public string? Snowfall { get; set; }

    [JsonPropertyName("weather_code")]
    public string? WeatherCode { get; set; }

    [JsonPropertyName("cloud_cover")]
    public string? CloudCover { get; set; }

    [JsonPropertyName("pressure_msl")]
    public string? PressureMsl { get; set; }

    [JsonPropertyName("surface_pressure")]
    public string? SurfacePressure { get; set; }

    [JsonPropertyName("wind_speed_10m")]
    public string? WindSpeed10m { get; set; }

    [JsonPropertyName("wind_direction_10m")]
    public string? WindDirection10m { get; set; }

    [JsonPropertyName("wind_gusts_10m")]
    public string? WindGusts10m { get; set; }
}