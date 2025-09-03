using CoffeeMaker.Engine;
using Microsoft.Extensions.DependencyInjection;

Console.WriteLine("Welcome to CoffeeMaker!");

var services =
    new ServiceCollection()
        .AddCoffeeMaker()
        .BuildServiceProvider();

var coffeeMaker =
    services.GetRequiredService<ICoffeeMaker>();

var coffee =
    coffeeMaker.Brew(Recipe.Espresso);

Console.WriteLine(coffee);
