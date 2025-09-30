using CoffeeMaker.Engine;
using CoffeeMaker.Engine.Components;

namespace CoffeeMaker.Specs;

public class JuraCoffeeMakerTests
{
    [Scenario]
    public void BrewEspresso(Recipe recipe)
    {
        var testee = new JuraCoffeeMaker(new Heater(), new Grinder(), new WaterSupply(), new BeanReservoir());
        var result = string.Empty;

        "given the recipe of an espresso".x(() =>
            recipe = Recipe.Espresso);

        "when brewing the espresso".x(() =>
            result = testee.Brew(recipe));

        "then the brew should announce the recipe".x(() => 
            result.Should().StartWith("Brewing Espresso"));
        
        "then the brew should contain all brewing steps".x(() => 
            result.Should().ContainAll(
                "Heating to 93°C",
                "Grinding 18 beans to 250 microns",
                "Pumping 35ml of water"));
    }
    
    [Scenario]
    public void BrewAmericano(Recipe recipe)
    {
        var testee = new JuraCoffeeMaker(new Heater(), new Grinder(), new WaterSupply(), new BeanReservoir());
        var result = string.Empty;

        "given the recipe of an americano".x(() =>
            recipe = Recipe.Americano);

        "when brewing the americano".x(() =>
            result = testee.Brew(recipe));

        "then the brew should announce the recipe".x(() => 
            result.Should().StartWith("Brewing Americano"));
        
        "then the brew should contain all brewing steps".x(() => 
            result.Should().ContainAll(
                "Heating to 85°C",
                "Grinding 18 beans to 500 microns",
                "Pumping 150ml of water"));
    }
}