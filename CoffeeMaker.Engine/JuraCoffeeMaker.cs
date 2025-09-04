using System.Text;
using CoffeeMaker.Engine.Components;

namespace CoffeeMaker.Engine;

public class JuraCoffeeMaker(
    Heater heater, 
    BeanReservoir beanReservoir, 
    WaterSupply waterSupply, 
    Grinder grinder) : ICoffeeMaker
{
    public string Brew(Recipe recipe)
    {
        var beans = beanReservoir.Take(recipe.BeansInGrams);
        
        return new StringBuilder()
            .AppendLine($"Brewing {recipe.Name}")
            .AppendLine(heater.HeatTo(recipe.TemperatureInCelsius))
            .AppendLine(grinder.Grind(beans, recipe.GrindSizeInMicrons))
            .AppendLine(waterSupply.Pump(recipe.WaterInMl))
            .ToString();
    }
}