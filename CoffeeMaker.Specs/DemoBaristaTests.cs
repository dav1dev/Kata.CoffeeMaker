using CoffeeMaker.Engine;
using Microsoft.Extensions.DependencyInjection;

namespace CoffeeMaker.Specs;

public class DemoBaristaTests
{
    private readonly JuraCoffeeMaker _testee;
    private readonly JuraCoffeeMaker _testee2;
    
    public DemoBaristaTests()
    {
        var services =
            new ServiceCollection()
                .AddCoffeeMaker()
                .BuildServiceProvider();

        _testee = (JuraCoffeeMaker)services.GetRequiredService<ICoffeeMaker>();
        _testee2 = (JuraCoffeeMaker)services.GetRequiredService<ICoffeeMaker>();
    }

    [Scenario]
    public void BrewEspresso(Recipe recipe)
    {
        var result = string.Empty;

        "given the recipe of an espresso".x(() =>
            recipe = Recipe.Espresso);

        "when brewing the espresso".x(() =>
            result = _testee.Brew(recipe));

        "then the brew should announce the recipe".x(() => 
            result.Should().StartWith("Brewing Espresso"));
        
        "then the brew should contain all brewing steps".x(() => 
            result.Should().ContainAll(
                "Heating to 93°C",
                "Grinding 18 beans to 250 microns",
                "Pumping 35ml of water"));
    }
    
    [Scenario]
    public void BrewUntilBeanReservoirIsEmpty(Recipe recipe)
    {
        var result = string.Empty;

        "given the recipe of an espresso".x(() =>
            recipe = Recipe.Espresso);

        "when brewing espressos until the bean reservoir is empty".x(() =>
        {
            for (var i = 0; i < 27; i++)
            {
                result = _testee.Brew(recipe);
            }
        });
        
        "then the last brew should announce that the bean reservoir is empty".x(() =>
        {
            Action act = () => _testee.Brew(recipe);
            act.Should().Throw<InvalidOperationException>();
        });
    }

    [Scenario]
    public void BrewWithTwoCoffeeMakers(Recipe recipe)
    {
        "given the recipe of an espresso".x(() =>
            recipe = Recipe.Espresso);
        
        "when brewing an espresso with first coffee maker".x(() =>
        {
            var result = _testee.Brew(recipe);
            result.Should().StartWith("Brewing Espresso");
        });
        
        "when brewing two espressos with second coffee maker".x(() =>
        {
            var result = _testee2.Brew(recipe);
            result.Should().StartWith("Brewing Espresso");
        });
        
        "then both coffee makers should a differet level of beans".x(() =>
        {
           _testee.BeanReservoir.LevelInGrams.Should().Be(9);
        });
    }
}