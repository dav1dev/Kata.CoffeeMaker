using Microsoft.Extensions.DependencyInjection;

namespace CoffeeMaker.Engine;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddCoffeeMaker(this IServiceCollection services)
    {
        services.AddSingleton<ICoffeeMaker, DemoBarista>();
        
        return services;
    }
}