using Desing_MediFlow.Extensions;
using Desing_MediFlow.Interfaces;
using CreateProduct = CleanArchComMediFlow.Application.Products.UseCases.Create.CreateProductRequest;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddMediFlow();

var app = builder.Build();

app.MapPost("/v1/products", async (IMediFlow handler, CreateProduct request)
    =>
{
    var result = await handler.Send(request);
    return Results.Created("/v1/products", result);
});
app.Run();
