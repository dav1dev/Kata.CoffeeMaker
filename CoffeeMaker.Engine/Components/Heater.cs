namespace CoffeeMaker.Engine.Components;

public class Heater
{
    public string HeatTo(int temperatureInCelsius)
    {
        ArgumentOutOfRangeException.ThrowIfLessThan(temperatureInCelsius, 40);
        ArgumentOutOfRangeException.ThrowIfGreaterThan(temperatureInCelsius, 100);
        
        
        return $"Heating to {temperatureInCelsius}°C";
    }
}