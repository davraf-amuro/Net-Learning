using Microsoft.AspNetCore.OpenApi;
using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Interfaces;
using Microsoft.OpenApi.Models;

namespace MinimalApi.Transformers
{
    public class DocumentInfo : IOpenApiDocumentTransformer
    {
        public async Task TransformAsync(OpenApiDocument document, OpenApiDocumentTransformerContext context, CancellationToken cancellationToken)
        {
            document.Info.Title = "MinimalApi";
            document.Info.Contact = new OpenApiContact
            {
                Name = "Davide Raffagli",
                Email = "d.rafagli@gmail.com",
                Url = new Uri("https://github.com/davraf-amuro"),
                Extensions = new Dictionary<string, IOpenApiExtension>
                {
                    {"x-profile", new OpenApiString(".Net Backend Developer") }
                }
            };

        }
    }
}
