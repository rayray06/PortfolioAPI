using System;
using System.Collections.Generic;
using Portfolio.Object.BDD;

namespace Portfolio.Object.DTO
{
    public class SkillDTO
    {
        public SkillDTO(SkillTable baseObject)
        {
            this.Name = baseObject.Name;
            this.LevelOfExperience = baseObject.LevelOfExperience;
        }

        public string Name { get; set; }
        public int LevelOfExperience { get; set; }

    }
}