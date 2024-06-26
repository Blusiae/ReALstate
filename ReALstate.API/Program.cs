using ReALstate.API.Middlewares;
using ReALstate.Infrastructure.Extensions;
using ReALstate.UseCases.Extenstions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add segments of the projects from extensions classes
builder.Services.AddUseCases();
builder.Services.AddInfrastructure(builder.Configuration);

// Add error-handling middleware
builder.Services.AddScoped<ErrorHandlingMiddleware>();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseMiddleware<ErrorHandlingMiddleware>();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
