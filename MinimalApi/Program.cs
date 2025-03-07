using MinimalApi.Endpoints;
using MinimalApi.Services;
using MinimalApi.Transformers;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<ProductsService>();

//using microsoft OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi(options =>
{
    options.AddDocumentTransformer<DocumentInfo>(); // la classe che imposta informazioni come titolo, autore, ecc
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    //openapi file /openapi/v1.json
    app.MapOpenApi();  
    //load swagger, only the UI at /swagger/index.html
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/openapi/v1.json", app.Environment.ApplicationName);
    });
    //load Scalar UI at /scalar/v1
    app.MapScalarApiReference();
}

app.UseHttpsRedirection();

//load my endpoints
app.MapAnonymousApi();
app.MapProducts();

app.Run();
