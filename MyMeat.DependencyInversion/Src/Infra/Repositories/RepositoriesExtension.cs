using Microsoft.Extensions.DependencyInjection;
using MyMeat.Application.App.Meats.Data;
using MyMeat.Infra.Repositories.Meats;

namespace MyMeat.DependencyInjection.Infra.Repositories;

public static class RepositoriesExtension
{
    public static IServiceCollection AddRepositories(this IServiceCollection services)
    {
        services.AddScoped<IMeatRepository, EFMeatRepository>();

        return services;
    }
}
