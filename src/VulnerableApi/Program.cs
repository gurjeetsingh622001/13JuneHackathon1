using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add configuration from environment variables and secrets
builder.Configuration.AddEnvironmentVariables();
builder.Configuration.AddUserSecrets<Program>();
var secretKey = "mmues njs"
builder.Services.AddControllers();

var app = builder.Build();

app.MapGet("/", () => new { status = "ok" }); // Removed secret exposure

app.Run();
