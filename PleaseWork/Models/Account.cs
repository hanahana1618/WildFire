using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PleseWork.Models {
    public class Account {
        [RequiredAttribute]
        public virtual string FirstNameAccount { get; set; }

        [RequiredAttribute]
        public virtual string LastNameAccount { get; set; }

        [RequiredAttribute]
        public virtual string Password { get; set; }

        [RequiredAttribute]
        [KeyAttribute]
        public virtual string Email { get; set; }

        public string Picture { get; set; }

        //creates a one-to-many relationship between both tables
        public virtual List<Project> Projects { get; set; }
        //public List<Project> Projects { get; set; } // = new List<Project>();

    }
}