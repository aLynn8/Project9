using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//Aubrey Farnbach (Wright) section 2 Group 1
//This is where CRUD happens
namespace Project3.Models
{
    public class MovieListDbContext : DbContext
    {
        public MovieListDbContext(DbContextOptions<MovieListDbContext> options) : base (options)
        {
        }

        public DbSet<ApplicationResponse> ApplicationResponses { get; set; }

    }
}
