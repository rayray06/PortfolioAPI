using System;
using System.Collections.Generic;

namespace Portfolio
{
    public class SkillCategoryTable: BaseEntity
    {
        public string Name { get; set; }
        public virtual List<SkillTable> Skills { get; set; }
    }
}