using Microsoft.EntityFrameworkCore;
using ProjetoConta.Data.Data;
using ProjetoConta.Data.Mapping;
using ProjetoConta.Data.Repository;
using ProjetoConta.Data.Repository.Interface;
using ProjetoConta.Service.Service;
using ProjetoConta.Service.Service.Interface;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ProjetoContaContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<ITarefaRepository, TarefaRepository>();
builder.Services.AddScoped<ITarefaservice, TarefaService>();

builder.Services.AddAutoMapper(typeof(TarefaMap).Assembly);

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
