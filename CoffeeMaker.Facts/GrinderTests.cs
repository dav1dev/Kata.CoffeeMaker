using CoffeeMaker.Engine;
using CoffeeMaker.Engine.Components;

namespace CoffeeMaker.Facts;

public class GrinderTests
{
    [Theory]
    [InlineData(0)]
    [InlineData(-1)]
    [InlineData(801)]
    public void GrindWithSizeOutOfBounds_ShouldThrow(int grindSizeInMicrons)
    {
        var testee = new Grinder();
        var beans = new[] { new Bean() };

        testee.Invoking(x => x
                .Grind(beans, grindSizeInMicrons))
            .Should()
            .Throw<ArgumentOutOfRangeException>();
    }
    
    [Fact]
    public void GrindSingleBean_ShouldReturnCorrectString()
    {
        var testee = new Grinder();
        var beans = new[] { new Bean() };
        var result = testee.Grind(beans, 500);

        result.Should().Be("Grinding 1 bean to 500 microns", result);
    }

    [Fact]
    public void Grind_ShouldReturnCorrectString()
    {
        var testee = new Grinder();
        var beans = Enumerable.Repeat(new Bean(), 10);
        var result = testee.Grind(beans, 250);

        Assert.Equal("Grinding 10 beans to 250 microns", result);
    }
}