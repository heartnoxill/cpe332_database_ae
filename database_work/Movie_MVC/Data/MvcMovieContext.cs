using Microsoft.EntityFrameworkCore;
using Movie_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movie_MVC.Data
{
    public class MvcMovieContext:DbContext
    {
        public MvcMovieContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<Movie> Movie { get; set; }
    }
}
