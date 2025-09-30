using System.Text;
using CoffeeMaker.Engine.Components;

namespace CoffeeMaker.Engine;

public class JuraCoffeeMaker(Heater heater, Grinder grinder, WaterSupply waterSupply, BeanReservoir beanReservoir) : ICoffeeMaker
{
    public string Brew(Recipe recipe)
    {
        var beansToBrew = beanReservoir.Take(18);
        
        return new StringBuilder()
            .AppendLine($"Brewing {recipe.Name}")
            .AppendLine(heater.HeatTo(recipe.TemperatureInCelsius))
            .AppendLine(grinder.Grind(beansToBrew, recipe.GrindSizeInMicrons))
            .AppendLine(waterSupply.Pump(recipe.WaterInMl))
            .ToString();
    }
}