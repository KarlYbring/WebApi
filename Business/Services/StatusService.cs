using Business.Factories;
using Business.Models;
using Data.Repositories;

namespace Business.Services;

public class StatusService(StatusRepository repo)
{
    private readonly StatusRepository _repo = repo;

    public async Task<IEnumerable<Status>> GetStatusesAsync()
    {
        var entities = await _repo.GetAllAsync();
        return entities.Select(StatusFactory.Map!);
    }
}


