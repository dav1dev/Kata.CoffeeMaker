using CoffeeMaker.Engine.Components;

namespace CoffeeMaker.Facts;

public class WaterSupplyTests
{
    private readonly WaterSupply _testee = new WaterSupply();

    [Fact]
    public void PumpWater_ShouldReturnCorrectString()
    {
        var result = _testee.Pump(200);
        result.Should().Be("Pumping 200ml of water");
    }
    
    [Theory]
    [InlineData(0)]
    [InlineData(-1)]
    public void PumpUnreachableAmountOfWater_ShouldThrow(int ml)
    {
        _testee
            .Invoking(x => x
                .Pump(ml))
            .Should()
            .Throw<ArgumentOutOfRangeException>();
    }
}