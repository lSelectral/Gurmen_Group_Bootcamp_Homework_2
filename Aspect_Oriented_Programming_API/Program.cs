using Autofac;
using Autofac.Extensions.DependencyInjection;
using Aspect_Oriented_Programming_API.Modules;
using Aspect_Oriented_Programming_API.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add customer service to the DI Container
builder.Services.AddTransient<ICustomerService, CustomerService>();

// Add Autofac Service to the DI Container
builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
// Register service module to the Autofac container
builder.Host.ConfigureContainer<ContainerBuilder>(containerBuilder => containerBuilder.RegisterModule(new ServiceModule()));


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
