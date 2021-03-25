//using Microsoft.AspNetCore.Builder;
//using Microsoft.Extensions.DependencyInjection;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace Project3.Models
//{
//    public class SeedData
//    {
//        public static void EnsurePopulated(IApplicationBuilder application)
//        {
//            MovieListDbContext context = application.ApplicationServices.
//                CreateScope().ServiceProvider.GetRequiredService<MovieListDbContext>();

//            if(context.Database.GetPendingMigrations().Any())
//            {
//                context.Database.Migrate();
//            }

//            if(!context.Projects.Any())
//            {

//            }
//        }
//    }
//}
