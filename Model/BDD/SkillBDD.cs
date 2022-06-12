using System;
using System.Collections.Generic;

namespace Portfolio
{
    public class SkillTable: BaseEntity
    {
        public string Name { get; set; }
        public int LevelOfExperience { get; set; }
        public virtual List<SkillCategoryTable> Categories { get; set; }
        public virtual List<ExperienceTable> Experiences { get; set; }
    }
}