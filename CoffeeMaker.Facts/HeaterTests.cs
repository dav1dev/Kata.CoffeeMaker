using CoffeeMaker.Engine.Components;

namespace CoffeeMaker.Facts;

public class HeaterTests
{
    [Theory]
    [InlineData(39)]
    [InlineData(101)]
    public void HeatToUnreachableTemperature_ShouldThrow(int temperatureInCelsius)
    {
        var testee = new Heater();
        
        testee.Invoking(x => x.HeatTo(temperatureInCelsius))
            .Should()
            .Throw<ArgumentOutOfRangeException>();
    }
    
    [Fact]
    public void HeatTo_ShouldReturnCorrectString()
    {
        var testee = new Heater();
        var result = testee.HeatTo(95);
        Assert.Equal("Heating to 95°C", result);
    }
}