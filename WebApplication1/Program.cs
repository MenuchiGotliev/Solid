using Solid.Core.Repositories;
using Solid.Core.Services;
using Solid.Data.Repository;
using Solid.Data;
using Solid.Core;
using Solid.Service.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddScoped<IChemistRepository, ChemistRepository>();
builder.Services.AddScoped<IMedicinRepository, MedicinRepository>();
builder.Services.AddScoped<IPatientRepository, PatientRepository>();
builder.Services.AddScoped<IChemistService, ChemistService>();
builder.Services.AddScoped<IMedicinService, MedicinService>();
builder.Services.AddScoped<IPatientService, PatientService>();

builder.Services.AddDbContext<DataContext>();
builder.Services.AddSingleton<DataContext>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
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
