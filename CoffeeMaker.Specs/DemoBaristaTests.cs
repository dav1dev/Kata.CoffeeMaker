using CoffeeMaker.Engine;

namespace CoffeeMaker.Specs;

public class DemoBaristaTests
{
    private readonly DemoBarista _testee = new();

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
}