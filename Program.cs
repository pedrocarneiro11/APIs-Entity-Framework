using _10_Introducao_a_APIs_com_Csharp.Context;
using _10_Introducao_a_APIs_com_Csharp.Entities;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Adicionando services

// Pega a string da conexao padrao no appsetings.json
var ConexaoPadrao = builder.Configuration.GetConnectionString("ConexaoPadrao");

// Adicionando o servico
builder.Services.AddDbContext<AgendaContext>(options =>
    options.UseSqlServer(ConexaoPadrao));

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle