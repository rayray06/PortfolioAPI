using System;
using System.Collections.Generic;
using Portfolio.Object.BDD;

namespace Portfolio.Object.BDD
{
    public class ExperienceTable : BaseEntity
    {
        public string Title { get; set; }
        public string Company { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Description { get; set; }
        public string GitLink { get; set; }
        public virtual List<SkillTable> Skills { get; set; }
        
    }
}