using Heindall_API.Context;
using Heindall_API.Interfaces.Repository;
using Heindall_API.Interfaces.Services;
using Heindall_API.Repository;
using Heindall_API.Services;
using Heindall_API.Settings;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using NuGet.Configuration;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using Rextur.Domain.AutoMapper;
using System;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers().AddJsonOptions(x => x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddHttpClient();

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

var rexturServerlessSettings = new RexturServerlessSettings()
{
	Url = builder.Configuration.GetSection("Apis:RexturServerless").Value,
	Code = builder.Configuration.GetSection("Apis:AccessCode").Value
};

builder.Services.AddSingleton(rexturServerlessSettings);

builder.Services.AddAutoMapper(typeof(DtoToDomainModelProfile));

builder.Services.AddScoped<IRexturService, RexturService>();

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
