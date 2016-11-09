using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Yeoman.Models {
    public class Project {
        [RequiredAttribute]
        public string NameProject { get; set; }

        


        public List<Project> Projects { get; set; }
    }
}