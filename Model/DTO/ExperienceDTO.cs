using System;
using System.Collections.Generic;
using Portfolio.Object.BDD;

namespace Portfolio.Object.DTO
{
    public class ExperienceDTO
    {
        public ExperienceDTO(ExperienceTable baseObject)
        {
            this.Title = baseObject.Title;
            this.Company = baseObject.Company;
            this.StartDate = baseObject.StartDate;
            this.EndDate = baseObject.EndDate;
            this.Description = baseObject.Description;
            this.GitLink = baseObject.GitLink;
            this.Skills = baseObject.Skills.ConvertAll((s) => new SkillDTO(s));
            
        }

        public string Title { get; set; }
        public string Company { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Description { get; set; }
        public string GitLink { get; set; }
        public List<SkillDTO> Skills { get; set; }
    }
}