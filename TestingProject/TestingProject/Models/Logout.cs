using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TestingProject.Models
{
    public class Logout
    {

        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }

    }
}