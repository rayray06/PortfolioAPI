﻿using System;
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

        public PortfolioResponseList<SkillCategoryDTO> FetchSkillsList()
        {
           return new PortfolioResponseList<SkillCategoryDTO>(_myService.FetchSkills().ConvertAll((cs) => new SkillCategoryDTO(cs)));
        }

    }
}
