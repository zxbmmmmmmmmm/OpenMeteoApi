namespace OpenMeteoApi.Tests;

[TestClass]
public class GeocodingTests
{
    [TestMethod]
    public async Task GeocodingTest()
    {
        var client = new OpenMeteoClient();
        var cities = await client.GetLocationsByName("beijing");
        Console.WriteLine(cities[0].Name);
        Assert.IsNotNull(cities[0].Name);
    }
}