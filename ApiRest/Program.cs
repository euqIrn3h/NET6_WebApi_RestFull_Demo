global using Microsoft.EntityFrameworkCore;
global using ApiRest.Data;

using ApiRest.Env;

var builder = WebApplication.CreateBuilder(args);

//Chamando variáveis de ambiente
Env.Variaveis();
var connect = Environment.GetEnvironmentVariable("CONNECTION");

//Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddDbContext<DataContext>(
    opt => {
    opt.UseMySql(connect, ServerVersion.AutoDetect(connect));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
