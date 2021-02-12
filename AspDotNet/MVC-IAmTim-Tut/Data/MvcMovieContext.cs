using Microsoft.EntityFrameworkCore;
using MVC_IAmTim_Tut.Models;

namespace MVC_IAmTim_Tut.Data
{
    public class MvcMovieContext : DbContext
    {
        public MvcMovieContext(DbContextOptions<MvcMovieContext>  options)
            :base(options)
        {   
        }

        public DbSet<Movie> Movie {get; set;}
    }
}