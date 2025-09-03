namespace CoffeeMaker.Engine;

public record Recipe(
    int TemperatureInCelsius,
    int WaterInMl,
    int BeansInGrams,
    int GrindSizeInMicrons)
{
    public static Recipe Ristretto => new(93, 20, 18, 220);
    public static Recipe Espresso => new(93, 35, 18, 250);
    public static Recipe Americano => new(85, 150, 18, 500);
}