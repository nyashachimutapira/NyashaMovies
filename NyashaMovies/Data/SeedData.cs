using NyashaMovies.Models;

namespace NyashaMovies.Data;

public static class SeedData
{
    public static void Initialize(MvcMovieContext context)
    {
        // Only add movies if the database is empty
        if (context.Movie.Any())
        {
            return;
        }

        var movies = new[]
        {
            new Movie
            {
                Title = "The Shawshank Redemption",
                ReleaseDate = new DateTime(1994, 9, 23),
                Genre = "Drama",
                Price = 12.99m,
                Rating = "R",
                Year = 1994
            },
            new Movie
            {
                Title = "The Godfather",
                ReleaseDate = new DateTime(1972, 3, 24),
                Genre = "Crime",
                Price = 14.99m,
                Rating = "R",
                Year = 1972
            },
            new Movie
            {
                Title = "Inception",
                ReleaseDate = new DateTime(2010, 7, 16),
                Genre = "Sci-Fi",
                Price = 15.99m,
                Rating = "PG-13",
                Year = 2010
            },
            new Movie
            {
                Title = "The Dark Knight",
                ReleaseDate = new DateTime(2008, 7, 18),
                Genre = "Action",
                Price = 14.99m,
                Rating = "PG-13",
                Year = 2008
            },
            new Movie
            {
                Title = "Pulp Fiction",
                ReleaseDate = new DateTime(1994, 10, 14),
                Genre = "Crime",
                Price = 12.99m,
                Rating = "R",
                Year = 1994
            }
        };

        context.Movie.AddRange(movies);
        context.SaveChanges();
    }
}
