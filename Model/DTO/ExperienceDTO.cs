using System;
using System.Collections.Generic;
using Portfolio;

namespace Portfolio.Object.DTO
{
    public class ExperienceDTO
    {
        public ExperienceDTO(ExperienceTable baseObject)
        {
            this.Title = baseObject.Title;
            this.Company = baseObject.Company;
            this.StartDate = baseObject.StartDate.ToString("MM/yyyy");
            this.EndDate = baseObject.EndDate.ToString("MM/yyyy");
            this.Description = baseObject.Description;
            this.GitLink = baseObject.GitLink;
            if (baseObject.Skills.Count > 0)
            {
                this.Skills = baseObject.Skills.ConvertAll((s) => new SkillDTO(s));
            }
            else 
            {
                this.Skills = new List<SkillDTO>();
            }
        }

        public string Title { get; set; }
        public string Company { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string Description { get; set; }
        public string GitLink { get; set; }
        public List<SkillDTO> Skills { get; set; }
    }
}