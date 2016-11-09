using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PleseWork.Models;

namespace PleseWork.Models {
    public class Account {
        [RequiredAttribute]
        public string FirstNameAccount { get; set; }

        [RequiredAttribute]
        public string LastNameAccount { get; set; }

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