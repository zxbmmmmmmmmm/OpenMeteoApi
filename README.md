# OpenMeteoApi

[![NuGet](https://img.shields.io/nuget/v/OpenMeteoApi)](https://www.nuget.org/packages/OpenMeteoApi) [![NuGet](https://img.shields.io/nuget/dt/OpenMeteoApi)](https://www.nuget.org/packages/OpenMeteoApi)

An easy-to-use library for getting weather data from [Open-Meteo](https://open-meteo.com/)

***

### Get current weather

    var client = new OpenMeteoClient();
    var current = await client.GetCurrentWeather(52.5,13.4);
    Console.WriteLine(current?.WeatherCode);

### Get daily forecasts

    var daily = await client.GetDailyForecasts(52.5, 13.4);
    Console.WriteLine(daily?[0].WeatherCode);

### Get hourly forecasts

    var hourly = await client.GetHourlyForecasts(52.5, 13.4);
    Console.WriteLine(hourly?[0].WeatherCode);

### Get weather data with custom variables

    var client = new OpenMeteoClient();
    var data = await client.GetWeatherForecastData(52.5, 13.4,
        currentVariables: CurrentVariables.All, dailyVariables: DailyVariables.All, hourlyVariables: HourlyVariables.All);
        
    Console.WriteLine(data?.CurrentWeather?.WeatherCode);
    Console.WriteLine(data?.DailyForecast?.WeatherCode?[0]);//Array
    Console.WriteLine(data?.HourlyForecast?.WeatherCode?[0]);//Array

### Get air quality

    var client = new OpenMeteoClient();
    var current = await client.GetHourlyAirQuality(52.5, 13.4);
    Console.WriteLine(current[0].Pm25);

### Customize API address and key

    var client = new OpenMeteoClient
    {
        ForecastApiBase = "https://customer-api.open-meteo.com",
        ForecastParameters =
        {
            { "apikey","YOUR_KEY" }
        }
    };
