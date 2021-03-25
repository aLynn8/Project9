using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
//Aubrey Farnbach (Wright) Section 2 Group 1
namespace Project3.Models
{
    public class ApplicationResponse
    {
        //Gets and sets the variable values when the form is submitted
        [Key]
        public int ApplicationResponseID { get; set; }
        public String Category { get; set; }
        public String Title { get; set; }
        public int Year { get; set; }
        public String Director { get; set; }
        public String Rating { get; set; }
        public Boolean Edited { get; set; }
        public String Lent_To { get; set; }
        public String Notes { get; set; }

    }
}