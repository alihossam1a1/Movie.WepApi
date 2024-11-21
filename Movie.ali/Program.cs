using Microsoft.EntityFrameworkCore;
using Moviee.ali.Repo.Director;
using Moviee.ali.Repo.Category;
using Moviee.ali.Repo.Nationality;
using System;
using Moviee.ali.Repo.Movie;
using Moviee.ali.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<AppDbContext>
(x => x.UseSqlServer(builder.Configuration.GetConnectionString("mydata")));

builder.Services.AddScoped<IMovieRepo, MovieRepo>();
builder.Services.AddScoped<IDirectorRepo, DirectorRepo>();
builder.Services.AddScoped<ICategoryRepo, CategotyRepo>();
builder.Services.AddScoped<INationalityRepo, NationalityRepo>();

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
