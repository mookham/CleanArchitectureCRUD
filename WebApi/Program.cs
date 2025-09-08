using Domain.Entities;
using Infrostucture.Data;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddSingleton(new DBContext());
builder.Services.AddScoped<Todo>();

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
