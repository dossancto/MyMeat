using FluentValidation;
using MyMeat.Application.App.Meats.Data;
using MyMeat.Application.App.Meats.Entities;
using MyMeat.Application.Utils.Validation;

namespace MyMeat.Application.App.Meats.UseCases;

public class CreateMeatUseCase
{
    private readonly IMeatRepository _meatRepository;
    private readonly IValidator<Meat> _validator;

    public CreateMeatUseCase(IMeatRepository meatRepository, IValidator<Meat> validator)
    {
        _meatRepository = meatRepository;
        _validator = validator;
    }

    /// Validates and save a new Meat in database; 
    public async Task<Meat> Execute(CreateMeatDto meatDto)
    {
        var meat = meatDto.ToModel();

        Validator.Validate(_validator, meat, "Falha ao validar a carne.");

        return await _meatRepository.Save(meat);
    }

}
