using Business.Models;
using Data.Entities;

namespace Business.Factories;

public class ProductFactory
{
    public static Product? Map(ProductEntity entity) => entity == null ? null : new Product
    {
        Id = entity.Id,
        ProductName = entity.ProductName,
    };
}