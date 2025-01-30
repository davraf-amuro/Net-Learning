# Net9-Learning
Ho voluto creare questa soluzione per imparare, approfondire, migliorare le mie conoscenze su alcune tematiche in ambito net.core partendo dall'uso delle minimal api in piena sostituzione dei controller MVC.
> perchè passare alle minimal api, [Marco Minerva Minimal API: The road so far](https://youtu.be/VKhqdZ-j7W0?si=Q4BDyVWsCDhv7Ekd)
  
Essendo un'api per giocare non segue architetture specifiche come DDD e Microservice o la Clean Architecture ma ho cercado comunque di dare un ordine funzionale al codice
## Minimal Api
- folder Endpoints: raccoglie in una idea di dominio tutti gli endpoint che vado a creare. ogni file .cs racchiude un contesto di lavoro (dominio) ed ogni verbo REST è organizzato all'interno di un gruppo per maggiore coerenza (MapGroup)
## OpenAPi e UI di Testing
- builder.Services.AddOpenApi(); il file documentale delle api viene generato dalla libreria nativa di microsoft invece che da Swagger (https://localhost:7128/openapi/v1.json).
  > [Marco Minerva OpenAPI (Swagger) in ASP.NET Core 9.0](https://www.youtube.com/live/AJAk7oylArQ?si=vncvIFZOoLw9S7kG)
- app.UseSwaggerUI; uso solo il pacchetto SwaggerUI per continuare a usare Swagger come strumento di test delle api (https://localhost:7128/swagger/index.html)
- app.MapScalarApiReference(); aggiungo Scalar come seconda inferfaccia UI (https://localhost:7128/scalar/)

# Ringraziamenti e Fonti
+ [Marco Minerva](https://github.com/marcominerva)
+ [Nick Chapsas](https://www.youtube.com/@nickchapsas)
+ [Microsoft Learning])(https://learn.microsoft.com/it-it/aspnet/core/introduction-to-aspnet-core?view=aspnetcore-9.0#recommended-learning-path)
