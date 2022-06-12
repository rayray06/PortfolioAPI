using System;
using System.Collections.Generic;
using Portfolio;

namespace Portfolio.Object.DTO
{
    public class SkillCategoryDTO
    {

        public SkillCategoryDTO(SkillCategoryTable baseObject)
        {
            this.Name = baseObject.Name;
            this.RelatedSkills = baseObject.Skills.ConvertAll<SkillDTO>((s) => new SkillDTO(s));
        }

        public string Name { get; set; }
        public List<SkillDTO> RelatedSkills { get; set; }

    }
}