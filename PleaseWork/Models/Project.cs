using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PleaseWork.Models {
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

        public List<Account> Accounts { get; set; }

    }
}