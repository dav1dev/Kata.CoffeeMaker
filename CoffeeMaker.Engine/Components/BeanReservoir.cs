namespace CoffeeMaker.Engine.Components;

public class BeanReservoir
{
    private const int CapacityInGrams = 500;
    
    private int _currentLevelInGrams = CapacityInGrams;
    
    
    public IEnumerable<Bean> Take(int grams)
    {
        return [];
    }
}