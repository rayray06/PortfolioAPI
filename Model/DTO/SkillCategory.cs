using System;
using System.Collections.Generic;
using System.Linq;
using Portfolio;

namespace Portfolio.Object.DTO
{
    public class SkillCategoryDTO
    {

        public SkillCategoryDTO(SkillCategoryTable baseObject)
        {
            this.Name = baseObject.Name;
            this.RelatedSkills = baseObject.Skills.ConvertAll((s) => new SkillDTO(s)).OrderByDescending(s => s.LevelOfExperience).ToList();
            
        }

        public string Name { get; set; }
        public List<SkillDTO> RelatedSkills { get; set; }

    }
}