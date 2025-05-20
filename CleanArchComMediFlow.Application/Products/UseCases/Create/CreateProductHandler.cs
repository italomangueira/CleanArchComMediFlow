using CleanArchComMediFlow.Application.Products.Repositories.Abstractions;
using CleanArchComMediFlow.Domain.Products;
using Desing_MediFlow.Interfaces;

namespace CleanArchComMediFlow.Application.Products.UseCases.Create
{
    public class CreateProductHandler(IProductRepository repository) : IRequestHandler<CreateProductRequest, CreateProductResponse>
    {
        public async Task<CreateProductResponse> Handle(CreateProductRequest request, CancellationToken cancellationToken)
        {
            var product = new Product 
            { 
                Title = request.Title,
            };
            await repository.SaveAsync(product, cancellationToken);
            return new CreateProductResponse
            {
                Message = $"Product {product.Id} - {product.Title} Created"
            };
        }
    }
}
