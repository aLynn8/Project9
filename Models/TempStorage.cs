using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//Aubrey Farnbach (Wright) Section 2 Group 1

namespace Project3.Models
{
    public static class TempStorage
    {
        //Creates empty list to store movie data
        private static List<ApplicationResponse> applications = new List<ApplicationResponse>();

        //Necessary to itterate through
        public static IEnumerable<ApplicationResponse> Applications => applications;

        //Adds application to list
        public static void AddApplication(ApplicationResponse application)
        {
            applications.Add(application);
        }
    }
}
