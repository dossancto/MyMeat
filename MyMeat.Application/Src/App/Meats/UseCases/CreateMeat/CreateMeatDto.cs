using MyMeat.Application.App.Meats.Entities;

namespace MyMeat.Application.App.Meats.UseCases;

public record CreateMeatDto(string name, string description, decimal price, DateTime validade)
{
    public Meat ToModel() => new()
    {
        Name = name,
        Description = description,
        Price = price,
        Validade = validade
    };
}
