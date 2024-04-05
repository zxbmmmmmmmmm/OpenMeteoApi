using System.Text.Json.Serialization;

namespace OpenMeteoApi.Models;

public class WeatherData
{
    [JsonPropertyName("latitude")]
    public float? Latitude { get; set; }

    [JsonPropertyName("longitude")]
    public float? Longitude { get; set; }

    [JsonPropertyName("generationtime_ms")]
    public float? GenerationtimeMs { get; set; }

    [JsonPropertyName("utc_offset_seconds")]
    public int? UtcOffsetSeconds { get; set; }

    [JsonPropertyName("timezone")]
    public string? Timezone { get; set; }

    [JsonPropertyName("timezone_abbreviation")]
    public string? TimezoneAbbreviation { get; set; }

    [JsonPropertyName("elevation")]
    public float? Elevation { get; set; }

    [JsonPropertyName("current_units")]
    public CurrentWeatherUnits? CurrentWeatherUnits { get; set; }

    [JsonPropertyName("current")]
    public CurrentWeather? CurrentWeather { get; set; }

    [JsonPropertyName("hourly_units")]
    public HourlyForecastUnits? HourlyForecastUnits { get; set; }

    [JsonPropertyName("hourly")]
    public HourlyForecast? HourlyForecast { get; set; }

    [JsonPropertyName("minutely_15")]
    public MinutelyForecast? MinutelyForecast { get; set; }

    [JsonPropertyName("minutely_15_units")]
    public MinutelyForecastUnits? MinutelyForecastUnits { get; set; }

    [JsonPropertyName("daily_units")]
    public DailyForecastUnits? DailyForecastUnits { get; set; }

    [JsonPropertyName("daily")]
    public DailyForecast? DailyForecast { get; set; }
}