using Autofac;
using Autofac.Core;
using BLL.RegistrationModule;
using BLL.Services.Implements;
using BLL.Services.Interfaces;
using Database;
using Database.RegostrationModule;
using Database.Repositories.Implements;
using Database.Repositories.Interfaces;
using GPU.Extensions;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var containerBuilder = new ContainerBuilder();
containerBuilder.RegisterModule<RegistrationModule>();
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();

builder.Services.AddDbContext<DBContext>(op =>
{
	op.UseSqlServer(builder.Configuration.GetConnectionString("devDB"));
});

builder.Services.AddTransient(typeof(IBaseRepository<>), typeof(BaseRepository<>));
builder.Services.AddTransient<IProductRepository, ProductRepository>();

// Services
builder.Services.ServicesRegister();

// AutoMapper
builder.Services.AutoMapperProfilesRegister();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();


app.MapControllers();

app.Run();