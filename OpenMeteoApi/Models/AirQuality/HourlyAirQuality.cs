using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OpenMeteoApi.Models;
public class HourlyAirQuality
{
    [JsonPropertyName("time")]
    public DateTime?[]? Time { get; set; }

    [JsonPropertyName("interval")]
    public float?[]? Interval { get; set; }

    [JsonPropertyName("european_aqi")]
    public float?[]? EuropeanAqi { get; set; }

    [JsonPropertyName("us_aqi")]
    public float?[]? UsAqi { get; set; }

    [JsonPropertyName("pm10")]
    public float?[]? Pm10 { get; set; }

    [JsonPropertyName("pm2_5")]
    public float?[]? Pm25 { get; set; }

    [JsonPropertyName("carbon_monoxide")]
    public float?[]? CarbonMonoxide { get; set; }

    [JsonPropertyName("nitrogen_dioxide")]
    public float?[]? NitrogenDioxide { get; set; }

    [JsonPropertyName("sulphur_dioxide")]
    public float?[]? SulphurDioxide { get; set; }

    [JsonPropertyName("ozone")]
    public float?[]? Ozone { get; set; }

    [JsonPropertyName("aerosol_optical_depth")]
    public float?[]? AerosolOpticalDepth { get; set; }

    [JsonPropertyName("dust")]
    public float?[]? Dust { get; set; }

    [JsonPropertyName("uv_index")]
    public float?[]? UvIndex { get; set; }

    [JsonPropertyName("uv_index_clear_sky")]
    public float?[]? UvIndexClearSky { get; set; }

    [JsonPropertyName("ammonia")]
    public float?[]? Ammonia { get; set; }

    [JsonPropertyName("alder_pollen")]
    public float?[]? AlderPollen { get; set; }

    [JsonPropertyName("birch_pollen")]
    public float?[]? BirchPollen { get; set; }

    [JsonPropertyName("grass_pollen")]
    public float?[]? GrassPollen { get; set; }

    [JsonPropertyName("mugwort_pollen")]
    public float?[]? MugwortPollen { get; set; }

    [JsonPropertyName("olive_pollen")]
    public float?[]? OlivePollen { get; set; }

    [JsonPropertyName("ragweed_pollen")]
    public float?[]? RagweedPollen { get; set; }

    [JsonPropertyName("european_aqi_pm2_5")]
    public float?[]? EuropeanAqiPm25 { get; set; }

    [JsonPropertyName("european_aqi_pm10")]
    public float?[]? EuropeanAqiPm10 { get; set; }

    [JsonPropertyName("european_aqi_nitrogen_dioxide")]
    public float?[]? EuropeanAqiNitrogenDioxide { get; set; }

    [JsonPropertyName("european_aqi_ozone")]
    public float?[]? EuropeanAqiOzone { get; set; }

    [JsonPropertyName("european_aqi_sulphur_dioxide")]
    public float?[]? EuropeanAqiSulphurDioxide { get; set; }

    [JsonPropertyName("us_aqi_pm2_5")]
    public float?[]? UsAqiPm25 { get; set; }

    [JsonPropertyName("us_aqi_pm10")]
    public float?[]? UsAqiPm10 { get; set; }

    [JsonPropertyName("us_aqi_nitrogen_dioxide")]
    public float?[]? UsAqiNitrogenDioxide { get; set; }

    [JsonPropertyName("us_aqi_carbon_monoxide")]
    public float?[]? UsAqiCarbonMonoxide { get; set; }

    [JsonPropertyName("us_aqi_ozone")]
    public float?[]? UsAqiOzone { get; set; }

    [JsonPropertyName("us_aqi_sulphur_dioxide")]
    public float?[]? UsAqiSulphurDioxide { get; set; }
}

public class HourlyAirQualityItem : AirQualityItem
{
    [JsonPropertyName("european_aqi_pm2_5")]
    public float? EuropeanAqiPm25 { get; set; }

    [JsonPropertyName("european_aqi_pm10")]
    public float? EuropeanAqiPm10 { get; set; }

    [JsonPropertyName("european_aqi_nitrogen_dioxide")]
    public float? EuropeanAqiNitrogenDioxide { get; set; }

    [JsonPropertyName("european_aqi_ozone")]
    public float? EuropeanAqiOzone { get; set; }

    [JsonPropertyName("european_aqi_sulphur_dioxide")]
    public float? EuropeanAqiSulphurDioxide { get; set; }

    [JsonPropertyName("us_aqi_pm2_5")]
    public float? UsAqiPm25 { get; set; }

    [JsonPropertyName("us_aqi_pm10")]
    public float? UsAqiPm10 { get; set; }

    [JsonPropertyName("us_aqi_nitrogen_dioxide")]
    public float? UsAqiNitrogenDioxide { get; set; }

    [JsonPropertyName("us_aqi_carbon_monoxide")]
    public float? UsAqiCarbonMonoxide { get; set; }

    [JsonPropertyName("us_aqi_ozone")]
    public float? UsAqiOzone { get; set; }

    [JsonPropertyName("us_aqi_sulphur_dioxide")]
    public float? UsAqiSulphurDioxide { get; set; }
}
public class HourlyAirQualityUnits
{

    [JsonPropertyName("time")]
    public string? Time { get; set; }

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

    #region Additional
    [JsonPropertyName("european_aqi")]
    public string? EuropeanAqi { get; set; }

    [JsonPropertyName("european_aqi_pm2_5")]
    public string? EuropeanAqiPm25 { get; set; }

    [JsonPropertyName("european_aqi_pm10")]
    public string? EuropeanAqiPm10 { get; set; }

    [JsonPropertyName("european_aqi_nitrogen_dioxide")]
    public string? EuropeanAqiNitrogenDioxide { get; set; }

    [JsonPropertyName("european_aqi_ozone")]
    public string? EuropeanAqiOzone { get; set; }

    [JsonPropertyName("european_aqi_sulphur_dioxide")]
    public string? EuropeanAqiSulphurDioxide { get; set; }

    [JsonPropertyName("us_aqi")]
    public string? UsAqi { get; set; }

    [JsonPropertyName("us_aqi_pm2_5")]
    public string? UsAqiPm25 { get; set; }

    [JsonPropertyName("us_aqi_pm10")]
    public string? UsAqiPm10 { get; set; }

    [JsonPropertyName("us_aqi_nitrogen_dioxide")]
    public string? UsAqiNitrogenDioxide { get; set; }

    [JsonPropertyName("us_aqi_carbon_monoxide")]
    public string? UsAqiCarbonMonoxide { get; set; }

    [JsonPropertyName("us_aqi_ozone")]
    public string? UsAqiOzone { get; set; }

    [JsonPropertyName("us_aqi_sulphur_dioxide")]
    public string? UsAqiSulphurDioxide { get; set; }
    #endregion
}

