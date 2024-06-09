using Microsoft.EntityFrameworkCore;
using Techtore_API.Extensions;
using TechTore_DAL.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.CSTMAddAutoMappperConfig();
builder.Services.CSTMAddControllerServices();
builder.Services.CSTMAddRepositories();
builder.Services.CSTMAddServices();
builder.Services.CSTMAddDb(builder.Configuration);
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
