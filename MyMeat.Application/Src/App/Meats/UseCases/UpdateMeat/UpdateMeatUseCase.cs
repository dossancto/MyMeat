using FluentValidation;
using MyMeat.Application.App.Meats.Data;
using MyMeat.Application.App.Meats.Entities;
using MyMeat.Application.Exceptions;
using MyMeat.Application.Utils.Validation;

namespace MyMeat.Application.App.Meats.UseCases;

public class UpdateMeatUseCase
{
    private readonly IMeatRepository _meatRepository;
    private readonly IValidator<Meat> _validator;

    public UpdateMeatUseCase(IMeatRepository meatRepository, IValidator<Meat> validator)
    {
        _meatRepository = meatRepository;
        _validator = validator;
    }

    public async Task<Meat> Execute(Guid id, UpdateMeatDto meatDto)
    {
        var meat = await _meatRepository.GetById(id) ?? throw new NotFoundException("Essa carne não existe.");

        meat.Name = meatDto.name;
        meat.Description = meatDto.description;
        meat.Price = meatDto.price;
        meat.Validade = meatDto.validade;

        Validator.Validate(_validator, meat, "Falha ao validar a carne.");

        return await _meatRepository.Update(meat);
    }
}
