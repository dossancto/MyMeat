using Microsoft.Extensions.DependencyInjection;

namespace MyMeat.DependencyInjection.UseCases;

public static class UseCasesExtension
{
    public static IServiceCollection AddUseCases(this IServiceCollection services)
    {
        services.AddMeatUseCases();
        return services;
    }
}
