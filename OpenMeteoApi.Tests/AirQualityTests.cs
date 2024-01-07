namespace OpenMeteoApi.Tests;

[TestClass]
public class AirQualityTests
{
    [TestMethod]
    public async Task CurrentAirQualityTest()
    {
        var client = new OpenMeteoClient();
        var current = await client.GetCurrentAirQuality(52.5, 13.4);
        Console.WriteLine(current.Pm25);
        Assert.IsNotNull(current.Pm25);
    }
    [TestMethod]
    public async Task HourlyAirQualityTest()
    {
        var client = new OpenMeteoClient();
        var current = await client.GetHourlyAirQuality(52.5, 13.4);
        Console.WriteLine(current[0].Pm25);
        Assert.IsNotNull(current[0].Pm25);
    }
}