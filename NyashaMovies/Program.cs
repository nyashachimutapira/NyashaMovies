using Microsoft.EntityFrameworkCore;
using NyashaMovies.Data;

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
    SeedData.Initialize(context);
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
