using Desing_MediFlow.Interfaces;

namespace CleanArchComMediFlow.Application.Products.UseCases.Create
{
    public record CreateProductRequest() : IRequest<CreateProductResponse>
    {
        public string Title { get; set; } = string.Empty;
    };

}
