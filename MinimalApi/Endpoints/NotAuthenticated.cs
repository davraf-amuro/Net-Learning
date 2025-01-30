namespace MinimalApi.Endpoints
{
    public static partial class NotAuthenticated
    {
        public static IEndpointRouteBuilder MapNotAuthenticated(this IEndpointRouteBuilder endpoints)
        {
            var group = endpoints.MapGroup("api/anonymous")
                .WithOpenApi()
                .WithName("Anonymous")
                .WithDescription("free to use api");

            group.MapGet("hello", (string name, IConfiguration configuration) =>{
                
                return TypedResults.Ok($"Hello, {name}!");

                })
                .WithName("hello")
                .WithDescription("say hello to you")
                .AllowAnonymous();

            group.MapGet("exeption", () =>
            {
                throw new Exception("This is an exception");
            });


            return endpoints;
        }
    }
}
