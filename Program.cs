using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;
using TestAPI.ApplicationDbContext;
using TestAPI.Services;
using TestAPI.Services.IServices;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IUploadService, UploadService>();
//import Services Upload.
builder.Services.AddDbContext<SqlServerDbContext>(option =>
{
    option.UseSqlServer(builder.Configuration.GetConnectionString("DF"));
});
//Import sqlserver framework

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(x =>
{
    x.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin();
});
app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
