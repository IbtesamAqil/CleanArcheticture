using CleanArcheticture.Domain.Entites;
using CleanArcheticture.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

public static class DatabaseSeeder
    {
    public static void SeedMovies(IServiceProvider serviceProvider)
        {
        using var context = serviceProvider.GetRequiredService<AppDbContext>();

        // Seed MovieTypes
        if (!context.Set<MovieTypes>().Any())
            {
            var movieTypes = new[]
            {
                new MovieTypes(1, "Action"),
                new MovieTypes(2, "Comedy"),
                new MovieTypes(3, "Drama")
            };
            context.Set<MovieTypes>().AddRange(movieTypes);
            context.SaveChanges();
            }

        // Seed Movies
        if (!context.Set<Movie>().Any())
            {
            var movies = new[]
            {
                new Movie(1, "Die Hard", 10),
                new Movie(2, "The Mask", 8),
                new Movie(3, "Forrest Gump", 12)
            };
            context.Set<Movie>().AddRange(movies);
            context.SaveChanges();
            }
        }
    }
