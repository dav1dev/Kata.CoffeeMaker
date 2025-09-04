using CoffeeMaker.Engine.Components;
using Microsoft.Extensions.DependencyInjection;

namespace CoffeeMaker.Engine;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddCoffeeMaker(this IServiceCollection services)
    {
        services.AddTransient<WaterSupply>();
        services.AddTransient<Heater>();
        services.AddTransient<BeanReservoir>();
        services.AddTransient<Grinder>();
        services.AddTransient<Bean>();
        
        services.AddScoped<ICoffeeMaker, JuraCoffeeMaker>();
        return services;
    }
}