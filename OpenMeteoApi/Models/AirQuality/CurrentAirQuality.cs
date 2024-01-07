using System.Text.Json.Serialization;

namespace OpenMeteoApi.Models;

public class CurrentAirQuality : AirQualityItem
{
}
public class CurrentAirQualityUnits
{

    [JsonPropertyName("time")]
    public string? Time { get; set; }

    [JsonPropertyName("int?erval")]
    public string? Interval { get; set; }

    [JsonPropertyName("european_aqi")]
    public string? EuropeanAqi { get; set; }

    [JsonPropertyName("us_aqi")]
    public string? UsAqi { get; set; }

    [JsonPropertyName("pm10")]
    public string? Pm10 { get; set; }

    [JsonPropertyName("pm2_5")]
    public string? Pm25 { get; set; }

    [JsonPropertyName("carbon_monoxide")]
    public string? CarbonMonoxide { get; set; }

    [JsonPropertyName("nitrogen_dioxide")]
    public string? NitrogenDioxide { get; set; }

    [JsonPropertyName("sulphur_dioxide")]
    public string? SulphurDioxide { get; set; }

    [JsonPropertyName("ozone")]
    public string? Ozone { get; set; }

    [JsonPropertyName("aerosol_optical_depth")]
    public string? AerosolOpticalDepth { get; set; }

    [JsonPropertyName("dust")]
    public string? Dust { get; set; }

    [JsonPropertyName("uv_index")]
    public string? UvIndex { get; set; }

    [JsonPropertyName("uv_index_clear_sky")]
    public string? UvIndexClearSky { get; set; }

    [JsonPropertyName("ammonia")]
    public string? Ammonia { get; set; }

    [JsonPropertyName("alder_pollen")]
    public string? AlderPollen { get; set; }

    [JsonPropertyName("birch_pollen")]
    public string? BirchPollen { get; set; }

    [JsonPropertyName("grass_pollen")]
    public string? GrassPollen { get; set; }

    [JsonPropertyName("mugwort_pollen")]
    public string? MugwortPollen { get; set; }

    [JsonPropertyName("olive_pollen")]
    public string? OlivePollen { get; set; }

    [JsonPropertyName("ragweed_pollen")]
    public string? RagweedPollen { get; set; }
}

