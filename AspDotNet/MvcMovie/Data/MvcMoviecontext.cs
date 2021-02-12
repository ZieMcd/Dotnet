using Microsoft.EntityFrameworkCore;
using Models;
using MvcMovie.Models;

namespace Data
{
    public class MvcMoviecontext : DbContext
    {
        public MvcMoviecontext( DbContextOptions<MvcMoviecontext> options) 
            : base(options)
        {
        }

        public DbSet<Movie> Movie {get; set;}
    }
}