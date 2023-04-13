using Autofac.Core;
using BLL.AutoMapper.Profiles;
using BLL.Services.Implements;
using BLL.Services.Interfaces;
using Database;
using Database.Repositories.Implements;
using Database.Repositories.Interfaces;
using GPU.Extensions;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<DBContext>(op =>
{
	op.UseSqlServer(builder.Configuration.GetConnectionString("devDB"));
});

builder.Services.AddTransient(typeof(IBaseRepository<>), typeof(BaseRepository<>));
builder.Services.ServicesRegister();
builder.Services.RepositoriesRegister();

// AutoMapper registration
builder.Services.AddAutoMapperProfiles();

builder.Services.AddControllers().AddNewtonsoftJson(x => x.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore);



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
