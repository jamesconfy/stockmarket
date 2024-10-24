using Microsoft.EntityFrameworkCore;
using StockMarket.Internal.Data;
using StockMarket.Internal.Interface;
using StockMarket.Internal.Service;
using System;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
builder.Services.AddScoped<StockService, StockService>();
builder.Services.AddScoped<CommentService, CommentService>();

var Configuration = builder.Configuration;
builder.Services.AddDbContext<ApplicationDBContext>(options =>
        options.UseNpgsql(Configuration.GetConnectionString("DefaultConnection")));

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
