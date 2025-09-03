using System.Text;
using CoffeeMaker.Engine.Components;

namespace CoffeeMaker.Engine;

public class DemoBarista : ICoffeeMaker
{
    private readonly Heater _heater = new();
    private readonly BeanReservoir _beanReservoir = new();
    private readonly Grinder _grinder = new();
    private readonly WaterSupply _waterSupply = new();

    public string Brew(Recipe recipe)
    {
        var beans = _beanReservoir.Take(recipe.BeansInGrams);

        return new StringBuilder()
            .AppendLine($"Brewing {recipe.Name}")
            .AppendLine(_heater.HeatTo(recipe.TemperatureInCelsius))
            .AppendLine(_grinder.Grind(beans, recipe.GrindSizeInMicrons))
            .AppendLine(_waterSupply.Pump(recipe.WaterInMl))
            .ToString();
    }
}