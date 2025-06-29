using BratOtkat.Domain;
using BratOtkat.Domain.Models;
using BratOtkat.Domain.Repositories;

namespace BratOtkat.Core;

public class PositionService
{
    private readonly IPositionRepository _repository;

    public PositionService(IPositionRepository repository)
    {
        _repository = repository;
    }

    public Task<IEnumerable<Position>> GetAllPositionsAsync() =>
        _repository.GetAllAsync();

    public Task<Position?> GetPositionByIdAsync(Guid id) =>
        _repository.GetByIdAsync(id);

    public Task AddPositionAsync(Position position) =>
        _repository.AddAsync(position);

    public Task UpdatePositionAsync(Position position) =>
        _repository.UpdateAsync(position);

    public Task DeletePositionAsync(Guid id) =>
        _repository.DeleteAsync(id);
}