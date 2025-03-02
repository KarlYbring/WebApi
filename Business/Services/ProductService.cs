using Business.Factories;
using Business.Models;
using Data.Repositories;

namespace Business.Services;

public class ProductService(ProductRepository repo)
{
    private readonly ProductRepository _repo = repo;

    public async Task<IEnumerable<Product>> GetProductsAsync()
    {
        var entities = await _repo.GetAllAsync();
        return entities.Select(ProductFactory.Map!);
    }
}
