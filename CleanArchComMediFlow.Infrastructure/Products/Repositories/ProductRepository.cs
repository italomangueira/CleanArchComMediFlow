using CleanArchComMediFlow.Application.Products.Repositories.Abstractions;
using CleanArchComMediFlow.Domain.Products;

namespace CleanArchComMediFlow.Infrastructure.Products.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public Task SaveAsync(Product product, CancellationToken cancellationToken = default)
        {
            Console.WriteLine($"Product {product.Id} has been saved.");
            return Task.CompletedTask;
        }
    }
}
