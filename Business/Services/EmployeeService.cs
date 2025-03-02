using Business.Factories;
using Business.Models;
using Data.Repositories;

namespace Business.Services;

public class EmployeeService(EmployeeRepository repo)
{
    private readonly EmployeeRepository _repo = repo;

    public async Task<IEnumerable<Employee>> GetProjectManagersAsync()
    {
        var entities = await _repo.GetAllAsync();
        return entities.Select(EmployeeFactory.Map!);
    }
}
