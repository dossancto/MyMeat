using MyMeat.Application.App.Meats.Data;
using MyMeat.Application.App.Meats.Entities;
using MyMeat.Application.Exceptions;

namespace MyMeat.Application.App.Meats.UseCases;

public class SelectMeatsUseCase
{
    private readonly IMeatRepository _meatRepository;

    public SelectMeatsUseCase(IMeatRepository meatRepository)
      => _meatRepository = meatRepository;

    public async Task<Meat> ById(Guid id)
    => await _meatRepository.GetById(id) ?? throw new NotFoundException($"Carne com Id {id} não encontrada.");

    public async Task<List<Meat>> All()
    => await _meatRepository.GetMeats();
}
