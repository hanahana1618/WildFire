using System.Collections.Generic;
using WildFire.Models;

namespace WildFire {
    public static class GlobalVariables
    {
        //makes the default of the list a new one if when called there isnt a list created
        public static System.Collections.Generic.List<Character> Characters { get; set; } = new List<Character>();
    }
}
