using Microsoft.EntityFrameworkCore;
using NyashaMovies.Data;
using NyashaMovies.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<MvcMovieContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("MvcMovieContext") ?? throw new InvalidOperationException("Connection string 'MvcMovieContext' not found.")));

var app = builder.Build();

// Seed the database with initial movies
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var context = services.GetRequiredService<MvcMovieContext>();
    SeedDatabase(context);
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();

static void SeedDatabase(MvcMovieContext context)
{
    // Only add movies if the database is empty
    if (context.Movie.Any())
    {
        return;
    }

    var movies = new[]
    {
        new NyashaMovies.Models.Movie
        {
            Title = "The Shawshank Redemption",
            ReleaseDate = new DateTime(1994, 9, 23),
            Genre = "Drama",
            Price = 12.99m,
            Rating = "R",
            Year = 1994
        },
        new NyashaMovies.Models.Movie
        {
            Title = "The Godfather",
            ReleaseDate = new DateTime(1972, 3, 24),
            Genre = "Crime",
            Price = 14.99m,
            Rating = "R",
            Year = 1972
        },
        new NyashaMovies.Models.Movie
        {
            Title = "Inception",
            ReleaseDate = new DateTime(2010, 7, 16),
            Genre = "Sci-Fi",
            Price = 15.99m,
            Rating = "PG-13",
            Year = 2010
        },
        new NyashaMovies.Models.Movie
        {
            Title = "The Dark Knight",
            ReleaseDate = new DateTime(2008, 7, 18),
            Genre = "Action",
            Price = 14.99m,
            Rating = "PG-13",
            Year = 2008
        },
        new NyashaMovies.Models.Movie
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
