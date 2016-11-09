using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace WebApplication.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        [RequiredAttribute]
        public virtual string FirstNameAccount { get; set; }

        [RequiredAttribute]
        public virtual string LastNameAccount { get; set; }

        [RequiredAttribute]
        public virtual string Password { get; set; }

        [RequiredAttribute]
        [KeyAttribute]
        public override string Email { get; set; }

        public string Picture { get; set; }

        //creates a one-to-many relationship between both tables
        public virtual List<Project> Projects { get; set; }
        //public List<Project> Projects { get; set; } // = new List<Project>();
    }
}
