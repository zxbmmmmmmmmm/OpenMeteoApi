using OpenMeteoApi.Variables;

namespace OpenMeteoApi.Tests;

[TestClass]
public class WeatherForecastTests
{
    [TestMethod]
    public async Task CurrentWeatherTest()
    {
        var client = new OpenMeteoClient();
        var current = await client.GetCurrentWeather(52.5, 13.4);
        Console.WriteLine(current.WeatherCode);
        Assert.IsNotNull(current.WeatherCode);
    }

    [TestMethod]
    public async Task DailyForecastsTest()
    {
        var client = new OpenMeteoClient();
        var daily = await client.GetDailyForecasts(52.5, 13.4);
        Console.WriteLine(daily[0].WeatherCode);
        Assert.IsNotNull(daily[0]);
    }

    [TestMethod]
    public async Task HourlyForecastsTest()
    {
        var client = new OpenMeteoClient();
        var hourly = await client.GetHourlyForecasts(52.5, 13.4);
        Console.WriteLine(hourly[0].WeatherCode);
        Assert.IsNotNull(hourly[0]);
    }
    [TestMethod]
    public async Task MinutelyForecastsTest()
    {
        var client = new OpenMeteoClient();
        var minutely = await client.GetMinutelyForecasts(52.5, 13.4);
        Console.WriteLine(minutely[0].WeatherCode);
        Assert.IsNotNull(minutely[0]);
    }
    [TestMethod]
    public async Task CustomWeatherDataTest()
    {
        var client = new OpenMeteoClient();
        var data = await client.GetWeatherForecastData(52.5, 13.4,
            currentVariables: CurrentVariables.All, dailyVariables: DailyVariables.All, hourlyVariables: HourlyVariables.All);
        Console.WriteLine(data.CurrentWeather?.WeatherCode);
        Console.WriteLine(data.DailyForecast?.WeatherCode?[0]);//Array
        Console.WriteLine(data.HourlyForecast?.WeatherCode?[0]);//Array

        Assert.IsNotNull(data.CurrentWeather?.WeatherCode);
        Assert.IsNotNull(data.DailyForecast?.WeatherCode);
        Assert.IsNotNull(data.HourlyForecast?.WeatherCode);
    }
    [TestMethod]
    public async Task HistoricalWeatherDataTest()
    {
        var client = new OpenMeteoClient();
        var data = await client.GetHistoricalWeatherData(52.5, 13.4,
           startDate:DateTime.Parse("2024-5-25"),endDate:DateTime.Parse("2024-6-1"), dailyVariables: DailyVariables.All, hourlyVariables: HourlyVariables.All);
        Console.WriteLine(data.CurrentWeather?.WeatherCode);
        Console.WriteLine(data.DailyForecast?.WeatherCode?[0]);//Array
        Console.WriteLine(data.HourlyForecast?.WeatherCode?[0]);//Array

        Assert.IsNotNull(data.DailyForecast?.WeatherCode);
        Assert.IsNotNull(data.HourlyForecast?.WeatherCode);
    }
}