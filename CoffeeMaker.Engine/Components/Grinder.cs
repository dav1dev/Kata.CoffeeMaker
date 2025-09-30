namespace CoffeeMaker.Engine.Components;

public class Grinder
{
    public string Grind(IEnumerable<Bean> beans, int grindSizeInMicrons)
    {
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(grindSizeInMicrons);
        ArgumentOutOfRangeException.ThrowIfGreaterThan(grindSizeInMicrons, 800);

        var enumerated = beans as Bean[] ?? beans.ToArray();
        
        return enumerated.Length == 1 
            ? $"Grinding 1 bean to {grindSizeInMicrons} microns" 
            : $"Grinding {enumerated.Length} beans to {grindSizeInMicrons} microns";
    }
}
