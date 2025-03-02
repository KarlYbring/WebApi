using Business.Models;
using Business.Services;
using Data.Contexts;
using Data.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddOpenApi();

builder.Services.AddDbContext<DataContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("LocalDB")));
builder.Services.AddScoped<ClientRepository>();
builder.Services.AddScoped<EmployeeRepository>();
builder.Services.AddScoped<StatusRepository>();
builder.Services.AddScoped<ProductRepository>();
builder.Services.AddScoped<ProjectRepository>();

builder.Services.AddScoped<ClientService>();
builder.Services.AddScoped<EmployeeService>();
builder.Services.AddScoped<StatusService>();
builder.Services.AddScoped<ProductService>();
builder.Services.AddScoped<ProjectService>();


var app = builder.Build();
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.UseCors(x => x.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
app.Run();