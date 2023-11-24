using MyMeat.Application.App.Meats.Entities;

namespace MyMeat.Application.App.Meats.Data;

public interface IMeatRepository
{
    Task<Meat> Save(Meat meat);
    Task<Meat?> GetById(Guid id);

    Task<List<Meat>> GetMeats();

    Task<Meat> Update(Meat meat);
    Task Delete(Guid id);
}
