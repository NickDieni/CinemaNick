using CinemaDataModels.Data;
using CinemaDataModels.AutoMapping;
using Microsoft.EntityFrameworkCore;
using CinemaDataModels.Repositories.IRepository;
using CinemaDataModels.Repositories.SQLRepository;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
    });
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<CinemaContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("ConnectionString")));

builder.Services.AddScoped<IUserRepository, SQLUserRepository>();
builder.Services.AddScoped<IPostalCodeRepository, SQLPostalCodeRepository>();
builder.Services.AddScoped<IGenreRepository, SQLGenreRepository>();
builder.Services.AddScoped<IMovieRepository, SQLMovieRepository>();
builder.Services.AddScoped<IAddressRepository, SQLAddressRepository>();
builder.Services.AddScoped<ISeatRepository, SQLSeatRepository>();
builder.Services.AddScoped<IShowtimeRepository, SQLShowtimeRepository>();
builder.Services.AddScoped<ITheaterRepository, SQLTheaterRepository>();
builder.Services.AddScoped<ITicketRepository, SQLTicketRepository>();
builder.Services.AddAutoMapper(typeof(AutoMapperProfiles));
builder.Services.AddCors(options =>
{
    options.AddPolicy("MyAllowSpecificOrigins",
        policy =>
        {
            policy.AllowAnyOrigin()
                .AllowAnyHeader()
                .AllowAnyMethod();
        });
});
var app = builder.Build();

// Configure the HTTP request pipeline.

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors("MyAllowSpecificOrigins");
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
