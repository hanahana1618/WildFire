using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Yeoman.Models {
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser {
        [RequiredAttribute]
        public string FirstNameAccount { get; set; }

        [RequiredAttribute]
        public string LastNameAccount { get; set; }

        [RequiredAttribute]
        public string Password { get; set; }

        [RequiredAttribute]
        [KeyAttribute]
        public override string Email { get; set; }

        public string Picture { get; set; }

        //creates a many-to-many relationship between both tables
        public List<Project> Projects { get; set; }
    }
}
