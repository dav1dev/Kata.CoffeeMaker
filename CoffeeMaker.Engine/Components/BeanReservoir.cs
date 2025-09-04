namespace CoffeeMaker.Engine.Components;

public class BeanReservoir(Bean bean)
{
    private const int CapacityInGrams = 500;
    
    private int _currentLevelInGrams = CapacityInGrams;
    
    public int CurrentLevelInGrams => _currentLevelInGrams;
    
    public IEnumerable<Bean> Take(int grams)
    {
        if(_currentLevelInGrams - grams < 0)
            throw new InvalidOperationException("Not enough beans in the reservoir");
        
        _currentLevelInGrams -= grams;

        return Enumerable.Repeat(bean, grams);
    }
}