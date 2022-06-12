using Portfolio.Object;
using System.Collections.Generic;
using Portfolio;
namespace Portfolio.Services
{


    public interface IPortfolioService
    {
        public List<SkillCategoryTable> FetchSkills();
        
    }

}