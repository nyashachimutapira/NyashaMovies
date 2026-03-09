using Microsoft.EntityFrameworkCore;
using NyashaMovies.Models;

namespace NyashaMovies.Data;

public class MvcMovieContext : DbContext
{
    public MvcMovieContext(DbContextOptions<MvcMovieContext> options)
        : base(options)
    {
    }

    public DbSet<Movie> Movie { get; set; } = default!;
}
