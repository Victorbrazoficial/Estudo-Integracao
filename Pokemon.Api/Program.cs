using Pokemon.Application.UseCase;
using Pokemon.Application.UseCase.IUseCase;
using Pokemon.Infrastructure.HTTPClients.Services;
using Pokemon.Infrastructure.Mappers;
using Pokemon.Infrastructure.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IBerriesUseCase, BerriesUseCase>();
builder.Services.AddScoped<IBerriesServiceExternal, BerriesServiceExternal>();
builder.Services.AddAutoMapper(typeof(BerriesMapper));

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
