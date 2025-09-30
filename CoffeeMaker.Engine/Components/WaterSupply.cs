namespace CoffeeMaker.Engine.Components;

public class WaterSupply
{
    public string Pump(int waterInMl)
    {
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(waterInMl);
        
        return $"Pumping {waterInMl}ml of water";
    }
}