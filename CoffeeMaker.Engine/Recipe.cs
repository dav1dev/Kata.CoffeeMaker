namespace CoffeeMaker.Engine;

public record Recipe(
    string Name,
    int TemperatureInCelsius,
    int WaterInMl,
    int BeansInGrams,
    int GrindSizeInMicrons)
{
    public static Recipe Ristretto => new(nameof(Ristretto), 93, 20, 18, 220);
    public static Recipe Espresso => new(nameof(Espresso), 93, 35, 18, 250);
    public static Recipe Americano => new(nameof(Americano), 85, 150, 18, 500);
}