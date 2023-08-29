using Butterfly.Client.AspNetCore;
using Butterfly.DataContract.Tracing;
using Discount.Grpc;
using Discount.Microservice;
using GenericRepositories.Contracts;
using GenericRepositories.Repositories;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Serialization;
using Product.business;
using Product.DAL.Db_Context;
using Product.Mircroservice.Grpc_Services;
using IProductBusiness = Product.business.IProductBusiness;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Grpc Configuration
builder.Services.AddGrpcClient<Discounter.DiscounterClient>
            (o => o.Address = new Uri(builder.Configuration["GrpcOptions:DiscountServiceUrl"]));

builder.Services.AddGrpcClient<Greeter.GreeterClient>
            (o => o.Address = new Uri(builder.Configuration["GrpcOptions:DiscountServiceUrl"]));
builder.Services.AddScoped<DiscountGrpcService>();
builder.Services.AddScoped<GreetingGrpcService>();

builder.Services.AddControllers()
                .AddNewtonsoftJson(options =>
                {
                    // Use the default property (Pascal) casing
                    options.SerializerSettings.ContractResolver = new DefaultContractResolver();
                });

builder.Services.AddButterfly(option =>
{
    //this is the url that the butterfly collector server is running on...
    option.CollectorUrl = "http://localhost:9618";
    option.Service = "Product";
});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddScoped<IProductBusiness, ProductBusiness>();
// Add your DbContext configuration
builder.Services.AddDbContext<ProductDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

// Add a delay of 2 seconds before running the application
await Task.Delay(2000);

app.Run();
