using System;
using System.Collections.Generic;
using Portfolio;

namespace Portfolio.Object.DTO
{
    public class EducationDTO
    {
        public EducationDTO(EducationTable baseObject)
        {
            this.Title = baseObject.Title;
            this.School = baseObject.School;
            this.Description = baseObject.Description;
            this.StartDate = baseObject.StartDate.ToString("MM/yyyy");
            this.EndDate = baseObject.EndDate.ToString("MM/yyyy");

        }

        public string Title { get; set; }
        public string Description { get; set; }
        public string School { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }

    }
}