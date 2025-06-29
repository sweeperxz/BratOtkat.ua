using BratOtkat.Domain.Models;
using BratOtkat.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace BratOtkat.Infostructure;

public class PositionRepository : IPositionRepository
{
    private readonly AppDbContext _context;

    public PositionRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<Position?> GetByIdAsync(Guid id) =>
        await _context.Positions.FindAsync(id);

    public async Task<IEnumerable<Position>> GetAllAsync() =>
        await _context.Positions.ToListAsync();

    public async Task AddAsync(Position position)
    {
        await _context.Positions.AddAsync(position);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Position position)
    {
        _context.Positions.Update(position);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var entity = await GetByIdAsync(id);
        if (entity != null)
        {
            _context.Positions.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}