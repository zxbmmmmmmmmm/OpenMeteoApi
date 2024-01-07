using OpenMeteoApi.Helpers;
using System.Text.Json.Serialization;

namespace OpenMeteoApi.Variables;

public static class CurrentAirQualityVariables
{
    public static string[] All = VariablesHelper.GetAllVariables(typeof(CurrentAirQualityVariables));
    public static string[] Standard = new[] {
        EuropeanAqi,
        UsAqi,
        Pm10,
        Pm25,
        CarbonMonoxide,
        NitrogenDioxide,
        SulphurDioxide,
        Ozone,
        AerosolOpticalDepth,
        Dust,
        Ammonia,
        UvIndexClearSky,
        UvIndex
    };

    public const string EuropeanAqi = "european_aqi";

    public const string UsAqi = "us_aqi";

    public const string Pm10 = "pm10";

    public const string Pm25 = "pm2_5";

    public const string CarbonMonoxide = "carbon_monoxide";

    public const string NitrogenDioxide = "nitrogen_dioxide";

    public const string SulphurDioxide = "sulphur_dioxide";

    public const string Ozone = "ozone";

    public const string AerosolOpticalDepth = "aerosol_optical_depth";

    public const string Dust = "dust";

    public const string UvIndex = "uv_index";

    public const string UvIndexClearSky = "uv_index_clear_sky";

    public const string Ammonia = "ammonia";

    public const string AlderPollen = "alder_pollen";

    public const string BirchPollen = "birch_pollen";

    public const string GrassPollen = "grass_pollen";

    public const string MugwortPollen = "mugwort_pollen";

    public const string OlivePollen = "olive_pollen";

    public const string RagweedPollen = "ragweed_pollen";
}
public static class HourlyAirQualityVariables
{
    public static string[] All = VariablesHelper.GetAllVariables(typeof(HourlyAirQualityVariables));

    public static string[] Standard = new[] {
        EuropeanAqi,
        UsAqi,
        Pm10,
        Pm25,
        CarbonMonoxide,
        NitrogenDioxide,
        SulphurDioxide,
        Ozone,
        AerosolOpticalDepth,
        Dust,
        Ammonia,
        UvIndexClearSky,
        UvIndex
    };

    public const string EuropeanAqi = "european_aqi";

    public const string UsAqi = "us_aqi";

    public const string Pm10 = "pm10";

    public const string Pm25 = "pm2_5";

    public const string CarbonMonoxide = "carbon_monoxide";

    public const string NitrogenDioxide = "nitrogen_dioxide";

    public const string SulphurDioxide = "sulphur_dioxide";

    public const string Ozone = "ozone";

    public const string AerosolOpticalDepth = "aerosol_optical_depth";

    public const string Dust = "dust";

    public const string UvIndex = "uv_index";

    public const string UvIndexClearSky = "uv_index_clear_sky";

    public const string Ammonia = "ammonia";

    public const string AlderPollen = "alder_pollen";

    public const string BirchPollen = "birch_pollen";

    public const string GrassPollen = "grass_pollen";

    public const string MugwortPollen = "mugwort_pollen";

    public const string OlivePollen = "olive_pollen";

    public const string RagweedPollen = "ragweed_pollen";

    public const string EuropeanAqiPm25 = "european_aqi_pm2_5";

    public const string EuropeanAqiPm10 = "european_aqi_pm10";

    public const string EuropeanAqiNitrogenDioxide = "european_aqi_nitrogen_dioxide";

    public const string EuropeanAqiOzone = "european_aqi_ozone";

    public const string EuropeanAqiSulphurDioxide = "european_aqi_sulphur_dioxide";

    public const string UsAqiPm25 = "us_aqi_pm2_5";

    public const string UsAqiPm10 = "us_aqi_pm10";

    public const string UsAqiNitrogenDioxide = "us_aqi_nitrogen_dioxide";

    public const string UsAqiCarbonMonoxide = "us_aqi_carbon_monoxide";

    public const string UsAqiOzone = "us_aqi_ozone";

    public const string UsAqiSulphurDioxide = "";
}