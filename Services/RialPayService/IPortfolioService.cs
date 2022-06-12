using Portfolio.Object;
using System.Collections.Generic;
using Portfolio.Object.BDD;
namespace Portfolio.Services
{


    public interface IPortfolioService
    {
        public List<SkillCategoryTable> FetchSkills();
        
    }

}