using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project3.Models
{
    public class EFMovieListRepository : IMovieListRepository
    {
        private MovieListDbContext _context;

        //constructor
        public EFMovieListRepository (MovieListDbContext context)
        {
            _context = context;
        }
        public IQueryable<ApplicationResponse> ApplicationResponses => _context.ApplicationResponses;


    }
}
