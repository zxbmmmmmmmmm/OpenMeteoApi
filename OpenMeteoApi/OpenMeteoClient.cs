using OpenMeteoApi.Helpers;
using OpenMeteoApi.Models;
using OpenMeteoApi.Models.Geocoding;
using OpenMeteoApi.Variables;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Web;
using System.Xml.Linq;

namespace OpenMeteoApi;

public class OpenMeteoClient
{
    public string ForecastApiBase { get; set; } = "https://api.open-meteo.com";
    public string AirQualityApiBase { get; set; } = "https://air-quality-api.open-meteo.com";
    public string GeocodingApiBase { get; set; } = "https://geocoding-api.open-meteo.com";
    public string HistoricalWeatherApiBase { get; set; } = "https://archive-api.open-meteo.com";

    private const string ForecastEndpoint = "/v1/forecast";
    private const string AirQualityEndpoint = "/v1/air-quality";
    private const string GeocodingEndpoint = "/v1/search";
    private const string HistoricalWeatherEndPoint = "/v1/archive";

    public Dictionary<string, string> ForecastParameters { get; set; } = new();
    public Dictionary<string, string> AirQualityParameters { get; set; } = new();
    public Dictionary<string, string> GeocodingParameters { get; set; } = new();
    public Dictionary<string, string> HistoricalWeatherParameters { get; set; } = new();
    private readonly HttpClient _httpClient = new();

    #region WeatherForecast
    /// <summary>
    /// Get current weather data
    /// </summary>
    /// <param name="latitude"></param>
    /// <param name="longitude"></param>
    /// <param name="variables"></param>
    /// <returns></returns>
    public async Task<CurrentWeather> GetCurrentWeather(double latitude, double longitude, params string[] variables)
    {
        variables = (variables.Length is 0) ? CurrentVariables.All : variables;
        var data = await GetWeatherForecastData(latitude, longitude, currentVariables: variables);
        return data.CurrentWeather!;
    }

    /// <summary>
    /// Get daily weather forecast
    /// </summary>
    /// <param name="latitude"></param>
    /// <param name="longitude"></param>
    /// <param name="variables"></param>
    /// <returns></returns>
    public async Task<List<DailyForecastItem>> GetDailyForecasts(double latitude, double longitude, params string[] variables)
    {
        variables = (variables.Length is 0) ? DailyVariables.All : variables;
        var data = await GetWeatherForecastData(latitude, longitude, dailyVariables: variables);
        var daily = data?.DailyForecast;
        var result = new List<DailyForecastItem>();
        for (var i = 0; i < daily?.WeatherCode?.Length; i++)
        {
            var item = new DailyForecastItem
            {
                Units = data?.DailyForecastUnits,
                ApparentTemperatureMax = daily.ApparentTemperatureMax?[i],
                ApparentTemperatureMin = daily.ApparentTemperatureMin?[i],
                DaylightDuration = daily.DaylightDuration?[i],
                Et0FaoEvapotranspiration = daily.Et0FaoEvapotranspiration?[i],
                PrecipitationHours = daily.PrecipitationHours?[i],
                PrecipitationProbabilityMax = daily.PrecipitationProbabilityMax?[i],
                PrecipitationSum = daily.PrecipitationSum?[i],
                RainSum = daily.RainSum?[i],
                ShortwaveRadiationSum = daily.ShortwaveRadiationSum?[i],
                ShowersSum = daily.ShowersSum?[i],
                SnowfallSum = daily.SnowfallSum?[i],
                Sunrise = daily.Sunrise?[i],
                Sunset = daily.Sunset?[i],
                SunshineDuration = daily.SunshineDuration?[i],
                Temperature2mMax = daily.Temperature2mMax?[i],
                Temperature2mMin = daily.Temperature2mMin?[i],
                Time = daily.Time?[i],
                UvIndexClearSkyMax = daily.UvIndexClearSkyMax?[i],
                UvIndexMax = daily.UvIndexMax?[i],
                WeatherCode = daily.WeatherCode?[i],
                WindDirection10mDominant = daily.WindDirection10mDominant?[i],
                WindSpeed10mMax = daily.WindSpeed10mMax?[i],
                WindGusts10mMax = daily.WindGusts10mMax?[i]
            };
            result.Add(item);
        }
        return result;
    }

    /// <summary>
    /// Get hourly weather forecast
    /// </summary>
    /// <param name="latitude"></param>
    /// <param name="longitude"></param>
    /// <param name="variables"></param>
    /// <returns></returns>
    public async Task<List<HourlyForecastItem>> GetHourlyForecasts(double latitude, double longitude, params string[] variables)
    {
        variables = (variables.Length is 0) ? HourlyVariables.Standard : variables;
        var data = await GetWeatherForecastData(latitude, longitude, hourlyVariables: variables);
        var hourly = data?.HourlyForecast;
        var result = new List<HourlyForecastItem>();

        for (var i = 0; i < hourly?.WeatherCode?.Length; i++)
        {
            var item = new HourlyForecastItem
            {
                Units = data?.HourlyForecastUnits,
                ApparentTemperature = hourly.ApparentTemperature?[i],
                Cape = hourly.Cape?[i],
                Et0FaoEvapotranspiration = hourly.Et0FaoEvapotranspiration?[i],
                Evapotranspiration = hourly.Evapotranspiration?[i],
                CloudCover = hourly.CloudCover?[i],
                CloudCoverHigh = hourly.CloudCoverHigh?[i],
                CloudCoverLow = hourly.CloudCoverLow?[i],
                CloudCoverMid = hourly.CloudCoverMid?[i],
                ShortwaveRadiation = hourly.ShortwaveRadiation?[i],
                ShortwaveRadiationInstant = hourly.ShortwaveRadiationInstant?[i],
                Showers = hourly.Showers?[i],
                SnowDepth = hourly.SnowDepth?[i],
                DewPoint2m = hourly.DewPoint2m?[i],
                Snowfall = hourly.Snowfall?[i],
                DiffuseRadiation = hourly.DiffuseRadiation?[i],
                DiffuseRadiationInstant = hourly.DiffuseRadiationInstant?[i],
                DirectNormalIrradiance = hourly.DirectNormalIrradiance?[i],
                DirectNormalIrradianceInstant = hourly.DirectNormalIrradianceInstant?[i],
                DirectRadiation = hourly.DirectRadiation?[i],
                DirectRadiationInstant = hourly.DirectRadiationInstant?[i],
                FreezingLevelHeight = hourly.FreezingLevelHeight?[i],
                IsDay = hourly.IsDay?[i],
                Precipitation = hourly.Precipitation?[i],
                PrecipitationProbability = hourly.PrecipitationProbability?[i],
                PressureMsl = hourly.PressureMsl?[i],
                Rain = hourly.Rain?[i],
                RelativeHumidity2m = hourly.RelativeHumidity2m?[i],
                SoilMoisture0To1cm = hourly.SoilMoisture0To1cm?[i],
                SoilMoisture1To3cm = hourly.SoilMoisture1To3cm?[i],
                SoilMoisture3To9cm = hourly.SoilMoisture3To9cm?[i],
                SoilMoisture9To27cm = hourly.SoilMoisture9To27cm?[i],
                SoilMoisture27To81cm = hourly.SoilMoisture27To81cm?[i],
                SoilTemperature0cm = hourly.SoilTemperature0cm?[i],
                SoilTemperature18cm = hourly.SoilTemperature18cm?[i],
                SoilTemperature6cm = hourly.SoilTemperature6cm?[i],
                SoilTemperature54cm = hourly.SoilTemperature54cm?[i],
                SunshineDuration = hourly.SunshineDuration?[i],
                SurfacePressure = hourly.SurfacePressure?[i],
                UvIndexClearSky = hourly.UvIndexClearSky?[i],
                WindSpeed10m = hourly.WindSpeed10m?[i],
                Temperature120m = hourly.Temperature120m?[i],
                Temperature180m = hourly.Temperature180m?[i],
                Temperature2m = hourly.Temperature2m?[i],
                Temperature80m = hourly.Temperature80m?[i],
                TerrestrialRadiation = hourly.TerrestrialRadiation?[i],
                TerrestrialRadiationInstant = hourly.TerrestrialRadiationInstant?[i],
                Time = hourly.Time?[i],
                UvIndex = hourly.UvIndex?[i],
                VapourPressureDeficit = hourly.VapourPressureDeficit?[i],
                Visibility = hourly.Visibility?[i],
                WeatherCode = hourly.WeatherCode?[i],
                WindDirection10m = hourly.WindDirection10m?[i],
                WindDirection120m = hourly.WindDirection120m?[i],
                WindDirection180m = hourly.WindDirection180m?[i],
                WindDirection80m = hourly.WindDirection80m?[i],
                WindGusts10m = hourly.WindGusts10m?[i],
                WindSpeed120m = hourly.WindSpeed120m?[i],
                WindSpeed180m = hourly.WindSpeed180m?[i],
                WindSpeed80m = hourly.WindSpeed80m?[i]
            };
            result.Add(item);
        }
        return result;
    }

    /// <summary>
    /// Get hourly weather forecast
    /// </summary>
    /// <param name="latitude"></param>
    /// <param name="longitude"></param>
    /// <param name="variables"></param>
    /// <returns></returns>
    public async Task<List<MinutelyForecastItem>> GetMinutelyForecasts(double latitude, double longitude, params string[] variables)
    {
        variables = (variables.Length is 0) ? MinutelyVariables.Standard : variables;
        var data = await GetWeatherForecastData(latitude, longitude, minutelyVariables: variables);
        var minutely = data?.MinutelyForecast;
        var result = new List<MinutelyForecastItem>();

        for (var i = 0; i < minutely?.WeatherCode?.Length; i++)
        {
            var item = new MinutelyForecastItem
            {
                ApparentTemperature = minutely.ApparentTemperature?[i],
                Cape = minutely.Cape?[i],
                ShortwaveRadiation = minutely.ShortwaveRadiation?[i], 
                ShortwaveRadiationInstant = minutely.ShortwaveRadiationInstant?[i],
                DewPoint2m = minutely.DewPoint2m?[i],
                Snowfall = minutely.Snowfall?[i],
                DiffuseRadiation = minutely.DiffuseRadiation?[i],
                DiffuseRadiationInstant = minutely.DiffuseRadiationInstant?[i],
                DirectNormalIrradiance = minutely.DirectNormalIrradiance?[i],
                DirectNormalIrradianceInstant = minutely.DirectNormalIrradianceInstant?[i],
                DirectRadiation = minutely.DirectRadiation?[i],
                DirectRadiationInstant = minutely.DirectRadiationInstant?[i],
                FreezingLevelHeight = minutely.FreezingLevelHeight?[i],
                IsDay = minutely.IsDay?[i],
                Precipitation = minutely.Precipitation?[i],
                Rain = minutely.Rain?[i],
                RelativeHumidity2m = minutely.RelativeHumidity2m?[i],
                SunshineDuration = minutely.SunshineDuration?[i],
                WindSpeed10m = minutely.WindSpeed10m?[i],
                Temperature2m = minutely.Temperature2m?[i],
                TerrestrialRadiation = minutely.TerrestrialRadiation?[i],
                TerrestrialRadiationInstant = minutely.TerrestrialRadiationInstant?[i],
                Time = minutely.Time?[i],
                Visibility = minutely.Visibility?[i],
                WeatherCode = minutely.WeatherCode?[i],
                WindDirection10m = minutely.WindDirection10m?[i],
                WindDirection80m = minutely.WindDirection80m?[i],
                WindGusts10m = minutely.WindGusts10m?[i],
                WindSpeed80m = minutely.WindSpeed80m?[i],
                GlobalTiltedIrradiance = minutely.GlobalTiltedIrradiance?[i],
                GlobalTiltedIrradianceInstant = minutely.GlobalTiltedIrradianceInstant?[i],
                SnowfallHeight = minutely.SnowfallHeight?[i],
                LightningPotential = minutely.LightningPotential?[i]
            };
            result.Add(item);
        }
        return result;
    }

    /// <summary>
    /// Get weather data with custom variables
    /// </summary>
    /// <param name="latitude"></param>
    /// <param name="longitude"></param>
    /// <param name="currentVariables"></param>
    /// <param name="dailyVariables"></param>
    /// <param name="hourlyVariables"></param>
    /// <param name="minutelyVariables"></param>
    /// <param name="parameters"></param>
    /// <returns></returns>
    public async Task<WeatherData> GetWeatherForecastData(
        double latitude,
        double longitude,
        string[]? currentVariables = null,
        string[]? dailyVariables = null,
        string[]? hourlyVariables = null,
        string[]? minutelyVariables = null,
        params KeyValuePair<string, string>[] parameters)
    {
        var collection = new Dictionary<string, string>
        {
            { "latitude", latitude.ToString(CultureInfo.InvariantCulture) },
            { "longitude", longitude.ToString(CultureInfo.InvariantCulture) }
        };

        if (currentVariables is not null)
            collection.Add("current", string.Join(",", currentVariables));
        if (dailyVariables is not null)
            collection.Add("daily", string.Join(",", dailyVariables));
        if (hourlyVariables is not null)
            collection.Add("hourly", string.Join(",", hourlyVariables));
        if (minutelyVariables is not null)
            collection.Add("minutely_15", string.Join(",", minutelyVariables));

        foreach (var param in ForecastParameters)
        {
            collection.Add(param.Key, param.Value);
        }
        foreach (var param in parameters)
        {
            collection.Add(param.Key, param.Value);
        }
        var urlString = QueryHelpers.AddQueryString(ForecastApiBase + ForecastEndpoint, collection);
        var result = await _httpClient.SendAsync(new HttpRequestMessage(HttpMethod.Get, new Uri(urlString)));
        var str = await result.Content.ReadAsStringAsync();
        return (JsonSerializer.Deserialize(str, typeof(WeatherData), SourceGenerationContext.Default) as WeatherData)!;
    }
    #endregion
    #region AirQuality
    /// <summary>
    /// Get current air quality
    /// </summary>
    /// <param name="latitude"></param>
    /// <param name="longitude"></param>
    /// <param name="variables"></param>
    /// <returns></returns>
    public async Task<CurrentAirQuality> GetCurrentAirQuality(double latitude, double longitude, params string[] variables)
    {
        variables = (variables.Length is 0) ? CurrentAirQualityVariables.Standard : variables;
        var data = await GetAirQualityData(latitude, longitude, currentVariables: variables);
        return data.Current!;
    }
    /// <summary>
    /// Get hourly air quality forecasts
    /// </summary>
    /// <param name="latitude"></param>
    /// <param name="longitude"></param>
    /// <param name="variables"></param>
    /// <returns></returns>
    public async Task<List<HourlyAirQualityItem>> GetHourlyAirQuality(double latitude, double longitude, params string[] variables)
    {
        variables = (variables.Length is 0) ? HourlyAirQualityVariables.Standard : variables;
        var data = await GetAirQualityData(latitude, longitude, hourlyVariables: variables);
        var hourly = data.Hourly;
        var result = new List<HourlyAirQualityItem>();
        for (var i = 0; i < hourly!.Time!.Length; i++)
        {
            var item = new HourlyAirQualityItem
            {
                AerosolOpticalDepth = hourly.AerosolOpticalDepth?[i],
                AlderPollen = hourly.AlderPollen?[i],
                Ammonia = hourly.Ammonia?[i],
                BirchPollen = hourly.BirchPollen?[i],
                CarbonMonoxide = hourly.CarbonMonoxide?[i],
                Dust = hourly.Dust?[i],
                EuropeanAqi = hourly.EuropeanAqi?[i],
                EuropeanAqiNitrogenDioxide = hourly.EuropeanAqiNitrogenDioxide?[i],
                EuropeanAqiOzone = hourly.EuropeanAqiOzone?[i],
                EuropeanAqiPm10 = hourly.EuropeanAqiPm10?[i],
                EuropeanAqiPm25 = hourly.EuropeanAqiPm25?[i],
                EuropeanAqiSulphurDioxide = hourly.EuropeanAqiSulphurDioxide?[i],
                GrassPollen = hourly.GrassPollen?[i],
                Interval = hourly.Interval?[i],
                MugwortPollen = hourly.MugwortPollen?[i],
                NitrogenDioxide = hourly.NitrogenDioxide?[i],
                OlivePollen = hourly.OlivePollen?[i],
                Ozone = hourly.Ozone?[i],
                Pm10 = hourly.Pm10?[i],
                Pm25 = hourly.Pm25?[i],
                RagweedPollen = hourly.RagweedPollen?[i],
                SulphurDioxide = hourly.SulphurDioxide?[i],
                Time = hourly.Time?[i],
                UsAqi = hourly.UsAqi?[i],
                UsAqiCarbonMonoxide = hourly.UsAqiCarbonMonoxide?[i],
                UsAqiNitrogenDioxide = hourly.UsAqiNitrogenDioxide?[i],
                UsAqiOzone = hourly.UsAqiOzone?[i],
                UsAqiPm10 = hourly.UsAqiPm10?[i],
                UsAqiPm25 = hourly.UsAqiPm25?[i],
                UsAqiSulphurDioxide = hourly.UsAqiSulphurDioxide?[i],
                UvIndex = hourly.UvIndex?[i],
                UvIndexClearSky = hourly.UvIndexClearSky?[i],
            };
            result.Add(item);
        }
        return result;
    }

    /// <summary>
    /// Get air quality data with custom variables
    /// </summary>
    /// <param name="latitude"></param>
    /// <param name="longitude"></param>
    /// <param name="currentVariables"></param>
    /// <param name="hourlyVariables"></param>
    /// <param name="parameters"></param>
    /// <returns></returns>
    public async Task<AirQualityData> GetAirQualityData(
        double latitude,
        double longitude,
        string[]? currentVariables = null,
        string[]? hourlyVariables = null,
        params KeyValuePair<string, string>[] parameters)
    {
        var collection = new Dictionary<string,string>
        {
            { "latitude", latitude.ToString(CultureInfo.InvariantCulture) },
            { "longitude", longitude.ToString(CultureInfo.InvariantCulture) }
        };
        if (currentVariables is not null)
            collection.Add("current", string.Join(",", currentVariables));
        if (hourlyVariables is not null)
            collection.Add("hourly", string.Join(",", hourlyVariables));
        foreach (var param in AirQualityParameters)
        {
            collection.Add(param.Key, param.Value);
        }
        foreach (var param in parameters)
        {
            collection.Add(param.Key, param.Value);
        }

        var urlString = QueryHelpers.AddQueryString(AirQualityApiBase + AirQualityEndpoint, collection);


        var result = await _httpClient.SendAsync(new HttpRequestMessage(HttpMethod.Get, new Uri(urlString)));
        var str = await result.Content.ReadAsStringAsync();
        return (JsonSerializer.Deserialize(str,typeof(AirQualityData),SourceGenerationContext.Default)! as AirQualityData)!;
    }
    #endregion
    #region Geocoding
    public async Task<List<Geolocation>> GetLocationsByName(string name,int? count=null, params KeyValuePair<string, string>[] parameters)
    {

        var collection = new Dictionary<string, string>
        {
            { "name",name },
        };
        if(count is not null)
        {
            collection.Add("count", count.Value.ToString());
        }
        foreach (var param in GeocodingParameters)
        {
            collection.Add(param.Key, param.Value);
        }
        foreach (var param in parameters)
        {
            collection.Add(param.Key, param.Value);
        }
        var urlString = QueryHelpers.AddQueryString(GeocodingApiBase + GeocodingEndpoint, collection);

        var result = await _httpClient.SendAsync(new HttpRequestMessage(HttpMethod.Get, new Uri(urlString)));
        var str = await result.Content.ReadAsStringAsync();
        return (JsonSerializer.Deserialize(str,typeof(GeolocationResponse),SourceGenerationContext.Default) as GeolocationResponse)!.Results!;
    }
    #endregion
    #region HistoricalWeather
    /// <summary>
    /// Get historical weather data with custom variables
    /// </summary>
    /// <param name="latitude"></param>
    /// <param name="longitude"></param>
    /// <param name="startDate"></param>
    /// <param name="endDate"></param>
    /// <param name="dailyVariables"></param>
    /// <param name="hourlyVariables"></param>
    /// <param name="parameters"></param>
    /// <returns></returns>
    public async Task<WeatherData> GetHistoricalWeatherData(
        double latitude,
        double longitude,
        DateTime startDate,
        DateTime endDate,
        string[]? dailyVariables = null,
        string[]? hourlyVariables = null,
        params KeyValuePair<string, string>[] parameters)
    {
        var collection = new Dictionary<string, string>
        {
            { "latitude", latitude.ToString(CultureInfo.InvariantCulture) },
            { "longitude", longitude.ToString(CultureInfo.InvariantCulture) },
            { "start_date", startDate.ToString("yyyy-MM-dd",CultureInfo.InvariantCulture) },
            { "end_date", endDate.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture) }
        };
        if (dailyVariables is not null)
            collection.Add("daily", string.Join(",", dailyVariables));
        if (hourlyVariables is not null)
            collection.Add("hourly", string.Join(",", hourlyVariables));
        foreach (var param in HistoricalWeatherParameters)
        {
            collection.Add(param.Key, param.Value);
        }
        foreach (var param in parameters)
        {
            collection.Add(param.Key, param.Value);
        }
        var urlString = QueryHelpers.AddQueryString(HistoricalWeatherApiBase + HistoricalWeatherEndPoint, collection);
        var result = await _httpClient.SendAsync(new HttpRequestMessage(HttpMethod.Get, new Uri(urlString)));
        var str = await result.Content.ReadAsStringAsync();
        return (JsonSerializer.Deserialize(str, typeof(WeatherData), SourceGenerationContext.Default) as WeatherData)!;
    }
    #endregion
}
