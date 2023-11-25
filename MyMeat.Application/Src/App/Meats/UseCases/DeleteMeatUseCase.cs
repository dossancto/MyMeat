using MyMeat.Application.App.Meats.Data;

namespace MyMeat.Application.App.Meats.UseCases;

public class DeleteMeatUseCase
{
    private readonly IMeatRepository _meatRepository;

    public DeleteMeatUseCase(IMeatRepository meatRepository)
      => _meatRepository = meatRepository;

    public async Task Execute(Guid id)
      => await _meatRepository.Delete(id);
}
