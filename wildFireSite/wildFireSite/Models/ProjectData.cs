using System;
using System.Collections.Generic;

namespace WildFire.Models
{

    public class ProjectData
    {
        public int id{ get; set; }
        public string nameProject { get; set; }
        public string description { get; set; }
        public string subject { get; set; }
        public int fundingGoal { get; set; }
        public string deadLine { get; set; }
        public string techSkills{ get; set; }
        public double fundAchieved {get; set;}



    }
}