using CleanArcheticture.Domain.Entites;
using CleanArcheticture.Infrastructure;

public static class DatabaseSeeder
    {
    public static void SeedMovies(AppDbContext context)
        {
      //  context.Database.EnsureCreated();

        // Seed MovieTypes
        if (!context.Set<MovieTypes>().Any())
            {
            var movieTypes = new[]
            {
                new MovieTypes("Action"),
                new MovieTypes("Comedy"),
                new MovieTypes("Drama")
            };
            context.Set<MovieTypes>().AddRange(movieTypes);
            context.SaveChanges();
            }

        // Seed Movies
        if (!context.Set<Movie>().Any())
            {
            var movies = new[]
            {
                new Movie("Die Hard", 10),
                new Movie("The Mask", 8),
                new Movie("Forrest Gump", 12)
            };
            context.Set<Movie>().AddRange(movies);
            context.SaveChanges();
            }
        }
    }
