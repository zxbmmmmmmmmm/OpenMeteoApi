using System.Text.Json.Serialization;

namespace OpenMeteoApi.Models;

public class AirQualityData
{

    [JsonPropertyName("latitude")]
    public double? Latitude { get; set; }

    [JsonPropertyName("longitude")]
    public double? Longitude { get; set; }

    [JsonPropertyName("generationtime_ms")]
    public double? GenerationtimeMs { get; set; }

    [JsonPropertyName("utc_offset_seconds")]
    public int? UtcOffsetSeconds { get; set; }

    [JsonPropertyName("timezone")]
    public string? Timezone { get; set; }

    [JsonPropertyName("timezone_abbreviation")]
    public string? TimezoneAbbreviation { get; set; }

    [JsonPropertyName("elevation")]
    public float? Elevation { get; set; }

    [JsonPropertyName("current_units")]
    public CurrentAirQualityUnits? CurrentUnits { get; set; }

    [JsonPropertyName("current")]
    public CurrentAirQuality? Current { get; set; }

    [JsonPropertyName("hourly_units")]
    public HourlyAirQualityUnits? HourlyUnits { get; set; }

    [JsonPropertyName("hourly")]
    public HourlyAirQuality? Hourly { get; set; }
}
