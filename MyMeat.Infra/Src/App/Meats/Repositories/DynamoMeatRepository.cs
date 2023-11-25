using MyMeat.Application.App.Meats.Data;
using MyMeat.Application.App.Meats.Entities;
using MyMeat.Infra.App.Meats.Entities;

namespace MyMeat.Infra.App.Meats.Repositories;

public class DynamoMeatRepository : IMeatRepository
{
    // TODO: Add Dynamo DB connection
    public DynamoMeatRepository() { }

    public async Task Delete(Guid id)
    {
        throw new NotImplementedException();
    }

    public async Task<Meat?> GetById(Guid id)
    {
        throw new NotImplementedException();
    }

    public async Task<List<Meat>> GetMeats()
    {
        throw new NotImplementedException();
    }

    public async Task<Meat> Save(Meat meat)
    {
        var m = new DynamoMeat(meat);

        return m;
    }

    public async Task<Meat> Update(Meat meat)
    {
        throw new NotImplementedException();
    }
}
