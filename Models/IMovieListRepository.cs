using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project3.Models
{
    //This is to use to make sure we aren't duplicating data, essentially we will inherit from this when we work with the data
    public interface IMovieListRepository
    {
        IQueryable<ApplicationResponse> ApplicationResponses {get;}
    }
}
