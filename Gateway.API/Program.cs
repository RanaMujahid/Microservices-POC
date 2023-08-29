using Microsoft.AspNetCore.Authentication;
using Ocelot.DependencyInjection;
using Ocelot.Middleware;
using Ocelot.Tracing.Butterfly;
using SecureAuth;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddLogging(logging =>
{
    logging.AddConsole(); // Add console logging provider
    logging.AddDebug(); // Add debug logging provider
    // Add any other logging providers as needed
});
// Add configuration for Ocelot
builder.Configuration
    .AddJsonFile("ocelot.json",false, true)
    .AddEnvironmentVariables();

// Register Ocelot services
builder.Services.AddOcelot(builder.Configuration)
     .AddButterfly(option =>
     {
         //this is the url that the butterfly collector server is running on...
         option.CollectorUrl = "http://localhost:9618";
         option.Service = "Ocelot";
     });
builder.Services.AddAuthentication("BasicAuthentication")
        .AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>
        ("BasicAuthentication", null);

builder.Services.AddJwtAuthentication(builder.Configuration["JwtOptions:Issuer"], builder.Configuration["JwtOptions:Audience"], builder.Configuration["JwtOptions:Secret"]);

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.UseHttpLogging();

app.UseAuthentication();
app.UseAuthorization();

// Use Ocelot middleware
app.UseOcelot();

app.Run();
