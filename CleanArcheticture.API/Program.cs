using CleanArcheticture.Infrastructure.Data;
using CleanArcheticture.Infrastructure.Repository;
using CleanArchitecture.Application.IRepository;
using CleanArchitecture.Application.IService;
using CleanArchitecture.Application.Service;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Swagger/OpenAPI
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add DbContext
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection")
    )
);

// Add repositories and services
builder.Services.AddScoped<IMovieRepository, MovieRepository>();
builder.Services.AddScoped<IMovieService, MovieService>();

var app = builder.Build();

// Seed database
using (var scope = app.Services.CreateScope())
    {
    var services = scope.ServiceProvider;

    try
        {
        DatabaseSeeder.SeedMovies(services);
        Console.WriteLine("Database seeded successfully!");
        }
    catch (Exception ex)
        {
        Console.WriteLine($"An error occurred while seeding the database: {ex.Message}");
        }
    }

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
