namespace CoffeeMaker.Engine;

public interface ICoffeeMaker
{
    string Brew(Recipe recipe);
}