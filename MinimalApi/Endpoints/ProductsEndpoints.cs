using Microsoft.AspNetCore.Http.HttpResults;
using MinimalApi.DTO;
using MinimalApi.Models;
using MinimalApi.Services;
using System;

namespace MinimalApi.Endpoints
{
    public static partial class ProductsEndpoints
    {
        public static IEndpointRouteBuilder MapProducts(this IEndpointRouteBuilder builder)
        {
            var group = builder.MapGroup("api/products")
                .WithName("Products")
                .WithOpenApi();

            group.MapGet("{id:guid}", async Task<IResult> (Guid id, ProductsService service) =>
            {
                if (id == Guid.Empty)
                {
                    return TypedResults.BadRequest("Invalid ID");
                }

                var product = await service.GetProduct(id);
                if (product == null)
                {
                    return TypedResults.NotFound();
                }

                return TypedResults.Ok(product);
            })
            .WithName("GetProductById")
            .WithDescription("Get a product by its ID")
            .Produces<Ok<Product>>(StatusCodes.Status200OK)
            .Produces<BadRequest<string>>(StatusCodes.Status400BadRequest)
            .Produces(StatusCodes.Status404NotFound);

            group.MapGet("advancesearch", async Task<IResult>(string? name, string? description) =>
            {

                return  TypedResults.Ok();
            });

            group.MapGet("parameters", async Task<IResult> ([AsParameters] ProductsSearchParameters parameters) =>
            {

                return TypedResults.Ok();
            })
                .WithName("parameters");

            return group;
        
        }

    }
}
