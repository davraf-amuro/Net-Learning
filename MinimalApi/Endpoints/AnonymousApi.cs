namespace MinimalApi.Endpoints
{
    public static partial class AnonymousApi
    {
        public static IEndpointRouteBuilder MapAnonymousApi(this IEndpointRouteBuilder endpoints)
        {
            var group = endpoints.MapGroup("api/anonymous")
                .WithTags("Anonymous");

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


            return group;
        }
    }
}
