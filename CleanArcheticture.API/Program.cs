using CleanArcheticture.Application;
using CleanArcheticture.Domain.Interfaces;
using CleanArcheticture.Infrastructure;
using CleanArchitecture.Application;
using CleanArchitecture.Infrastructure;
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
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped<IMovieService, MovieService>();
builder.Services.AddScoped<IMovieTypesService, MovieTypesService>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
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

await using (var scope = app.Services.CreateAsyncScope())
{
    var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();

    // If you’re using migrations, do this (recommended):
    await db.Database.MigrateAsync();

    // If you’re not using migrations yet, use EnsureCreated() instead:
    // await db.Database.EnsureCreatedAsync();

    DatabaseSeeder.SeedMovies(db);  // your method below (or the async version further down)
}
app.Run();
