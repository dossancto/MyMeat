using Microsoft.EntityFrameworkCore;

using MyMeat.Application.App.Meats.Data;
using MyMeat.Application.App.Meats.Entities;
using MyMeat.Infra.Data.Contexts;

namespace MyMeat.Infra.Repositories.Meats;

public class EFMeatRepository : IMeatRepository
{
    private readonly ApplicationDbContext _context;

    public EFMeatRepository(ApplicationDbContext context)
      => _context = context;

    public async Task Delete(Guid id)
    {
        var meat = await GetById(id);

        if (meat is null)
        {
            return;
        }

        _context.Meats.Remove(meat);
        await _context.SaveChangesAsync();
    }

    public async Task<Meat?> GetById(Guid id)
    => await _context.Meats.FindAsync(id);

    public async Task<List<Meat>> GetMeats()
    => await _context.Meats.ToListAsync();

    public async Task<Meat> Save(Meat meat)
    {
        var m = await _context.Meats.AddAsync(meat);

        await _context.SaveChangesAsync();

        return m.Entity;
    }

    public async Task<Meat> Update(Meat meat)
    {
        var m = _context.Meats.Update(meat);

        await _context.SaveChangesAsync();

        return m.Entity;
    }
}
