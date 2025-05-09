using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Muebleria;
using Muebleria.Server.Data_context;
using Muebleria.Server.Services.Implementation;
using Muebleria.Server.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<MuebleriaDbContext>(
    opt =>
    {
        opt.UseSqlServer(builder.Configuration.GetConnectionString("DataDbContext_Connection"))
        .EnableSensitiveDataLogging(true).UseLazyLoadingProxies();
    });


builder.Services.AddSingleton(provider =>
{
    return new MapperConfiguration(config =>
    {
        config.AddProfile<AutoMapperProfile>();
        config.ConstructServicesUsing(type =>
        ActivatorUtilities.GetServiceOrCreateInstance(provider, type));
    }).CreateMapper();
});

builder.Services.AddScoped<ICatalogoService, CatalogoService>();


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//// Se agregan los servicios de la app
//builder.Services.AddJwtAuthentication(builder.Configuration);
//builder.Services.AddIdentity();
//builder.Services.AddAppServices();

var app = builder.Build();

app.UseDefaultFiles();
app.UseStaticFiles();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapFallbackToFile("/index.html");

app.Run();
