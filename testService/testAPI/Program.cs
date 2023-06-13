using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerUI;
using testAPI.Domain.Interfaces;
using testAPI.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen( c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "UserApi", Version = "v1" });
});
builder.Services.AddTransient<IUserRepository, UserRepository>(
    serviceProvider => new UserRepository(builder.Configuration.GetSection("ExternalServicesUrls")["UserGen"])
    );

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment()) { }
app.UseSwagger();
app.UseSwaggerUI(c => {
    c.SwaggerEndpoint("./v1/swagger.json", "Test.API v1");
    c.DocExpansion(DocExpansion.None);
    c.InjectStylesheet("../css/main.css");
    c.InjectJavascript("../js/swagger.js");
});
app.UseStaticFiles();
app.UseHttpsRedirection();
app.MapControllers();
app.Run();
