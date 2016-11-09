using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System;

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

        //creates a one-to-many relationship between both tables
        public List<Project> Projects { get; set; }
        //public List<Project> Projects { get; set; } // = new List<Project>();

    }

    public class Project {
        [RequiredAttribute]
        [KeyAttribute] //makes the field unique
        public string NameProject { get; set; }

        [RequiredAttribute]
        public string Description { get; set; }

        [RequiredAttribute]
        public string Subject { get; set; }

        public string PictureProject { get; set; }

        public int Funding { get; set; }

        public string Skills { get; set; }
    
        [RequiredAttribute]
        public int PercentageAchieved { get; set; }

        public ICollection<Account> Accounts { get; set; }
    }
}