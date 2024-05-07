using Microsoft.EntityFrameworkCore;
using TechChallenge1.API.AutoMapper;
using TechChallenge1.API.Configurations;
using TechChallenge1.Core.DTO;
using TechChallenge1.Data.Context;
using TechChallenge1.Domain.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var connectionString = builder.Configuration.GetConnectionString("SqlConnection");

builder.Services.AddDbContext<techchallengeDbContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddAutoMapper(typeof(MapperProfile), typeof(MapperProfile));

builder.Services.ResolveDependencies();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
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
