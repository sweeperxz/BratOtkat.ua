using BratOtkat.Domain.Models;

namespace BratOtkat.Domain.Repositories;

public interface IPositionRepository
{
    Task<Position?> GetByIdAsync(Guid id);
    Task<IEnumerable<Position>> GetAllAsync();
    Task AddAsync(Position position);
    Task UpdateAsync(Position position);
    Task DeleteAsync(Guid id);
}
