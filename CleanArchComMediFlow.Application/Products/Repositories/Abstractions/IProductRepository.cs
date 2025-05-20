using CleanArchComMediFlow.Domain.Products;

namespace CleanArchComMediFlow.Application.Products.Repositories.Abstractions
{
    public interface IProductRepository
    {
        Task SaveAsync(Product product, CancellationToken cancellationToken = default);
    }
}
