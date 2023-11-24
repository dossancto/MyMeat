using FluentValidation;

using Microsoft.Extensions.DependencyInjection;

using MyMeat.Application.App.Meats.Entities;
using MyMeat.Application.App.Meats.UseCases;

internal static class MeatUseCaseExtension
{
    public static IServiceCollection AddMeatUseCases(this IServiceCollection services)
    {
        services.AddValidatorsFromAssemblyContaining<MeatValidation>();

        services.AddScoped<CreateMeatUseCase>();
        services.AddScoped<SelectMeatsUseCase>();
        services.AddScoped<UpdateMeatUseCase>();
        services.AddScoped<DeleteMeatUseCase>();

        return services;
    }
}
