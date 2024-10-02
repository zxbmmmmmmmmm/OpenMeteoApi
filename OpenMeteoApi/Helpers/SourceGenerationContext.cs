using OpenMeteoApi.Models;
using OpenMeteoApi.Models.Geocoding;
using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;

namespace OpenMeteoApi.Helpers;

[JsonSourceGenerationOptions(GenerationMode = JsonSourceGenerationMode.Metadata)]
[JsonSerializable(typeof(AirQualityData))]
[JsonSerializable(typeof(AirQualityItem))]
[JsonSerializable(typeof(HourlyAirQuality))]
[JsonSerializable(typeof(HourlyAirQualityItem))]
[JsonSerializable(typeof(CurrentAirQualityUnits))]
[JsonSerializable(typeof(HourlyAirQualityUnits))]
[JsonSerializable(typeof(GeolocationResponse))]
[JsonSerializable(typeof(CurrentAirQuality))]
[JsonSerializable(typeof(Geolocation))]
[JsonSerializable(typeof(CurrentWeather))]
[JsonSerializable(typeof(CurrentWeatherUnits))]
[JsonSerializable(typeof(DailyForecast))]
[JsonSerializable(typeof(DailyForecastItem))]
[JsonSerializable(typeof(DailyForecastUnits))]
[JsonSerializable(typeof(HourlyForecast))]
[JsonSerializable(typeof(HourlyForecastItem))]
[JsonSerializable(typeof(HourlyForecastUnits))]
[JsonSerializable(typeof(MinutelyForecast))]
[JsonSerializable(typeof(MinutelyForecastItem))]
[JsonSerializable(typeof(MinutelyForecastUnits))]
[JsonSerializable(typeof(WeatherData))]
internal partial class SourceGenerationContext : JsonSerializerContext
{
}