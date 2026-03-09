# Nyasha Movies - ASP.NET Core MVC Application

A simple movie management application built with ASP.NET Core 10.0 and MVC pattern.

## Features

- **CRUD Operations**: Create, read, update, and delete movies
- **Search Functionality**: Search movies by title
- **Year Filter**: Filter movies by year or newer
- **Database**: SQLite database with Entity Framework Core ORM
- **Validation**: Data validation on movie model
- **Responsive Design**: Bootstrap styling with improved form input padding

## Favorite Movies

The application comes pre-populated with 5 favorite movies:

1. **The Shawshank Redemption** (1994) - Drama, Rating: R
2. **The Godfather** (1972) - Crime, Rating: R
3. **Inception** (2010) - Sci-Fi, Rating: PG-13
4. **The Dark Knight** (2008) - Action, Rating: PG-13
5. **Pulp Fiction** (1994) - Crime, Rating: R

## Getting Started

### Prerequisites
- .NET SDK 10.0 or later
- Visual Studio Code (recommended)

### Installation

1. Clone the repository
2. Navigate to the NyashaMovies directory
3. Run `dotnet restore` to restore NuGet packages
4. Run `dotnet run` to start the application
5. Open http://localhost:5000 in your browser

## Project Structure

```
NyashaMovies/
├── Controllers/
│   ├── HomeController.cs
│   └── MoviesController.cs
├── Data/
│   └── MvcMovieContext.cs
├── Models/
│   ├── Movie.cs
│   └── ErrorViewModel.cs
├── Views/
│   ├── Home/
│   ├── Movies/
│   │   ├── Index.cshtml
│   │   ├── Create.cshtml
│   │   ├── Edit.cshtml
│   │   ├── Details.cshtml
│   │   └── Delete.cshtml
│   └── Shared/
├── wwwroot/
│   └── css/
│       └── site.css
└── Program.cs
```

## Movie Model

The Movie model includes:
- **Id**: Unique identifier
- **Title**: Movie title (3-60 characters)
- **ReleaseDate**: Date of release
- **Genre**: Movie genre (alphanumeric)
- **Price**: Price in decimal format
- **Rating**: Movie rating (MPAA: G, PG, PG-13, R, etc.)
- **Year**: Release year

## CSS Styling

Custom CSS added for improved form input appearance:
- Input fields, select boxes, and textareas have 10px padding
- Form controls have additional 10px bottom margin for spacing

## Database

- **Type**: SQLite
- **File**: MvcMovie.db
- **ORM**: Entity Framework Core 10.0.3

## How to Use

### View All Movies
Navigate to `/movies` or click the Movies link in the navigation

### Search Movies
Enter a movie title in the search field and click Filter

### Filter by Year
Select a year from the dropdown and click Filter to see movies from that year onwards

### Create New Movie
Click "Create New" button and fill in the form

### Edit Movie
Click "Edit" on any movie to modify its details

### Delete Movie
Click "Delete" and confirm the deletion

## Technologies Used

- **Framework**: ASP.NET Core 10.0
- **Language**: C# 13
- **Database**: SQLite
- **ORM**: Entity Framework Core
- **Frontend**: Razor Views with Bootstrap 5
- **Styling**: CSS with Bootstrap

## Assignment Completion

✅ Completed Microsoft's "Get started with ASP.NET Core MVC" tutorial  
✅ Changed app title to "Nyasha Movies"  
✅ Added 5 favorite movies to the database  
✅ Changed Index page title to "My Movies"  
✅ Implemented year filter functionality  
✅ Improved CSS styling with form input padding  
✅ Uploaded to GitHub repository  

## License

This project is created as part of CSE 325 Week 02 Assignment.
