namespace CoffeeMaker.Engine.Components;

public class Heater
{
    public string HeatTo(int temperatureInCelsius)
    {
        return $"Heating to {temperatureInCelsius}°C";
    }
}