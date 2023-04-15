using Heindall_API.Context;
using Heindall_API.Interfaces;
using Heindall_API.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using Rextur.Domain.AutoMapper;
using System;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers().AddJsonOptions(x => x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<MySQLContext>(options =>
{
string connectionString = builder.Configuration.GetConnectionString("MySQLConnectionString");
options.UseMySql(connectionString,
	ServerVersion.AutoDetect(connectionString),
	mySqlOptions =>
		mySqlOptions.EnableRetryOnFailure(
			maxRetryCount: 10,
			maxRetryDelay: TimeSpan.FromSeconds(30),
			errorNumbersToAdd: null)
		);
});

builder.Services.AddAutoMapper(typeof(DtoToDomainModelProfile));

builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

builder.Services.AddScoped<IIntegradoresDoUsuarioRepository, IntegradoresDoUsuarioRepository>();
builder.Services.AddScoped<IIntegradoresRepository, IntegradoresRepository>();

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
