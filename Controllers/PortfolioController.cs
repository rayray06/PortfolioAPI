using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Portfolio.Object.DTO;
using Portfolio.Services;
using Portfolio.Object;

namespace API.Controllers
{
    [ApiController]
    [Route(Portfolio.Route.RialPayRoute.API.FULL_NAME)]
    public class PortfolioController : ControllerBase
    {
        private readonly IPortfolioService _myService;
        private readonly ILogger<PortfolioController> _logger;

        public PortfolioController(
            ILogger<PortfolioController> logger,
            IPortfolioService myService
            )
        {
            _myService = myService;
            _logger = logger;
        }
        
        [HttpGet,
        Route(Portfolio.Route.RialPayRoute.API.Skills.LIST)]
        public PortfolioResponseList<SkillCategoryDTO> FetchSkillsList()
        {
           return new PortfolioResponseList<SkillCategoryDTO>(_myService.FetchSkills().ConvertAll((cs) => new SkillCategoryDTO(cs)));
        }

        [HttpGet,
        Route(Portfolio.Route.RialPayRoute.API.Education.LIST)]
        public PortfolioResponseList<EducationDTO> FetchEducationList()
        {
            return new PortfolioResponseList<EducationDTO>(_myService.FetchEducation().ConvertAll((e) => new EducationDTO(e)));
        }

        [HttpGet,
        Route(Portfolio.Route.RialPayRoute.API.Experience.LIST)]
        public PortfolioResponseList<ExperienceDTO> FetchExperienceList()
        {
            return new PortfolioResponseList<ExperienceDTO>(_myService.FetchExperience().ConvertAll((e) => new ExperienceDTO(e)));
        }


    }
}
