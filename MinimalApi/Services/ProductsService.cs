using Microsoft.AspNetCore.Http.HttpResults;
using MinimalApi.Models;

namespace MinimalApi.Services
{
    public class ProductsService
    {
        public async Task<Product> GetProduct(Guid productID)
        {
            var notValid = false;
            var found = false;

            return new Product() { Id = productID, Name = "Nome", Description = "descrizione del prodotto" };
        }
    }
}
