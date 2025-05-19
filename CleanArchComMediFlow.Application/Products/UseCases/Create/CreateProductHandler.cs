using Desing_MediFlow.Interfaces;

namespace CleanArchComMediFlow.Application.Products.UseCases.Create
{
    public class CreateProductHandler : IRequestHandler<CreateProductRequest, CreateProductResponse>
    {
        public async Task<CreateProductResponse> Handle(CreateProductRequest request, CancellationToken cancellationToken)
        {
            await Task.Delay(10);
            return new CreateProductResponse("Product Created");
        }
    }
}
