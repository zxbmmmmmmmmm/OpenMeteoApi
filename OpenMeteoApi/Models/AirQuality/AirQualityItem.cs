using System;
using System.Text.Json.Serialization;

namespace OpenMeteoApi.Models;

public class AirQualityItem
{
    [JsonPropertyName("time")]
    public DateTime? Time { get; set; }

    [JsonPropertyName("interval")]
    public float? Interval { get; set; }

    [JsonPropertyName("european_aqi")]
    public float? EuropeanAqi { get; set; }

    [JsonPropertyName("us_aqi")]
    public float? UsAqi { get; set; }

    [JsonPropertyName("pm10")]
    public float? Pm10 { get; set; }

    [JsonPropertyName("pm2_5")]
    public float? Pm25 { get; set; }

    [JsonPropertyName("carbon_monoxide")]
    public float? CarbonMonoxide { get; set; }

    [JsonPropertyName("nitrogen_dioxide")]
    public float? NitrogenDioxide { get; set; }

    [JsonPropertyName("sulphur_dioxide")]
    public float? SulphurDioxide { get; set; }

    [JsonPropertyName("ozone")]
    public float? Ozone { get; set; }

    [JsonPropertyName("aerosol_optical_depth")]
    public float? AerosolOpticalDepth { get; set; }

    [JsonPropertyName("dust")]
    public float? Dust { get; set; }

    [JsonPropertyName("uv_index")]
    public float? UvIndex { get; set; }

    [JsonPropertyName("uv_index_clear_sky")]
    public float? UvIndexClearSky { get; set; }

    [JsonPropertyName("ammonia")]
    public float? Ammonia { get; set; }

    [JsonPropertyName("alder_pollen")]
    public float? AlderPollen { get; set; }

    [JsonPropertyName("birch_pollen")]
    public float? BirchPollen { get; set; }

    [JsonPropertyName("grass_pollen")]
    public float? GrassPollen { get; set; }

    [JsonPropertyName("mugwort_pollen")]
    public float? MugwortPollen { get; set; }

    [JsonPropertyName("olive_pollen")]
    public float? OlivePollen { get; set; }

    [JsonPropertyName("ragweed_pollen")]
    public float? RagweedPollen { get; set; }
}