using Application.Interfaces;
using Domain.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddScoped<IFormaGeometrica, AreaCalculatorServiceImpl>(); 

var app = builder.Build();

app.UseHttpsRedirection();
app.MapControllers();
app.Run();
