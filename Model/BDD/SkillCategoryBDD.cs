using System;
using System.Collections.Generic;

namespace Portfolio.Object.BDD
{
    public class SkillCategoryTable: BaseEntity
    {
        public string Name { get; set; }
        public virtual List<SkillTable> Skills { get; set; }
    }
}