using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Yeoman.Models {
    public class Account {
        [RequiredAttribute]
        [KeyAttribute] //makes the field unique
        public string NameAccount { get; set; }

        [RequiredAttribute]
        public string Password { get; set; }

        [RequiredAttribute]
        [KeyAttribute]
        public string Email { get; set; }

        public string Picture { get; set; }

        //creates a many-to-many relationship between both tables
        public List<Project> Projects { get; set; }

    }
}