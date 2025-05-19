using Desing_MediFlow.Interfaces;

namespace CleanArchComMediFlow.Application.Products.UseCases.Create
{
    public record CreateProductRequest(string Title) : IRequest<CreateProductResponse>;
}
