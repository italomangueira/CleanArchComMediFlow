using CleanArchComMediFlow.Application.Products.Repositories.Abstractions;
using CleanArchComMediFlow.Infrastructure.Products.Repositories;
using Desing_MediFlow.Extensions;
using Desing_MediFlow.Interfaces;
using CreateProduct = CleanArchComMediFlow.Application.Products.UseCases.Create.CreateProductRequest;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddTransient<IProductRepository, ProductRepository>();
builder.Services.AddMediFlow();

var app = builder.Build();

app.MapPost("/v1/products", async (IMediFlow mediFlow, CreateProduct request)
    =>
{
    var result = await mediFlow.Send(request);
    return Results.Created("/v1/products", result);
});
app.Run();
