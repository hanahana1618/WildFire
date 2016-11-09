using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ForgingAhead.Models {
    //this is the basis of the database
    public class Character {

        [RequiredAttribute]
        [KeyAttribute]
        public string Name { get; set; }


        [RequiredAttribute]
        [RangeAttribute(1, 100)]
        public int Intelligence { get; set; }
        public List<Equipment> Equipment { get; set; }

        public List<Character> Characters { get; set; }
    }
}



// fornt end validation: asp-validation-summary="All"