using System.ComponentModel.DataAnnotations;

namespace WebApplication.Models {
    public class Project {
        [RequiredAttribute]
        [KeyAttribute] //makes the field unique
        public virtual string NameProject { get; set; }

        [RequiredAttribute]
        public virtual string Description { get; set; }

        [RequiredAttribute]
        public virtual string Subject { get; set; }

        public virtual string PictureProject { get; set; }

        public virtual int Funding { get; set; }

        public virtual string Skills { get; set; }
    
        [RequiredAttribute]
        public virtual int PercentageAchieved { get; set; }

        public virtual Player Player { get; set; }
    }
}