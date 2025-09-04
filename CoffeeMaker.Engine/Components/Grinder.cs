namespace CoffeeMaker.Engine.Components;

public class Grinder
{
    public string Grind(IEnumerable<Bean> beans, int grindSizeInMicrons)
    {
        return $"Grinding {beans.Count()} beans to {grindSizeInMicrons} microns";
    }
}