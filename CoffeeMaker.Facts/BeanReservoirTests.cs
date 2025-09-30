using CoffeeMaker.Engine.Components;

namespace CoffeeMaker.Facts;

public class BeanReservoirTests
{
    private readonly BeanReservoir _testee = new();

    [Theory]
    [InlineData(20)]
    [InlineData(50)]
    [InlineData(100)]
    public void TakeBeans_ShouldReturnTheCorrectNumberOfBeans(int grams)
    {
        var result = _testee.Take(grams);

        result.Count().Should().Be(grams);
    }

    [Theory]
    [InlineData(0)]
    [InlineData(-1)]
    [InlineData(501)]
    public void TakeUnreachableGramsOfBeans_ShouldThrow(int grams)
    {
        _testee
            .Invoking(x => x
                .Take(grams))
            .Should()
            .Throw<ArgumentOutOfRangeException>();
    }

    [Fact]
    public void TakeWhenEmpty_ShouldThrow()
    {
        _testee.Take(499);
        
        _testee
            .Invoking(x => x
                .Take(2))
            .Should()
            .Throw<InvalidOperationException>();
    }
}