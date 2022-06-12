using System;
using System.Collections.Generic;

namespace Portfolio
{
    public class EducationTable : BaseEntity
    {
        public string Title { get; set; }
        public string School { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Description { get; set; }
        
    }
}