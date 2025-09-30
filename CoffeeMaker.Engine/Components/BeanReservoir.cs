namespace CoffeeMaker.Engine.Components;

public class BeanReservoir
{
    private const int CapacityInGrams = 500;
    
    private int _currentLevelInGrams = CapacityInGrams;
    
    public IEnumerable<Bean> Take(int grams)
    {
        ArgumentOutOfRangeException.ThrowIfZero(grams, nameof(grams));
        ArgumentOutOfRangeException.ThrowIfGreaterThan(grams, CapacityInGrams, nameof(grams));

        if (_currentLevelInGrams < grams)
            throw new InvalidOperationException();
        
        _currentLevelInGrams -= grams;
        
        return Enumerable.Repeat(new Bean(), grams);
    }
}