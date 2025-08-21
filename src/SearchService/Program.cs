using MongoDB.Driver;
using MongoDB.Entities;
using SearchService.Data;
using SearchService.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();


// Add services to the container.
var app = builder.Build();

app.UseAuthentication();
app.MapControllers();


try
{

    await DbInitializer.InitDb(app);
}
catch (Exception ex)
{

    Console.WriteLine(ex);
}


app.Run();

