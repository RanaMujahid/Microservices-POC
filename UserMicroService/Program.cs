using SecureAuth;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddSingleton(new TokenIssuer(
        builder.Configuration["JwtOptions:ExpirationMinutes"],
        builder.Configuration["JwtOptions:Issuer"],
        builder.Configuration["JwtOptions:Audience"],
        builder.Configuration["JwtOptions:Secret"]
    ));

var app = builder.Build();

// Configure the HTTP request pipeline.

//app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
