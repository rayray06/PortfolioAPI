using System;
using System.Collections.Generic;
using Portfolio;

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