using Microsoft.AspNetCore.Mvc;

namespace MinimalApi.DTO
{
    public class ProductsSearchParameters : BaseSearchParameters
    {
        [FromQuery(Name = "na")]
        public string? Name { get; set; }
        
        [FromQuery(Name = "de")]
        public string? Description { get; set; }
    }
}
