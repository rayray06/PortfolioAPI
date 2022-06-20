using System;
using System.Collections.Generic;
using System.Linq;
using Portfolio;
using Portfolio.Route;
using Portfolio.AccessLayer;
using Portfolio.Settings;
using Portfolio.Exceptions;
using System.Security.Cryptography;
using System.Text;
using System.Net;
using System.Net.Mail;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Security.Claims;



namespace Portfolio.AccessLayer
{
    public class ExperienceTableAccessLayer : AccessLayer<PortfolioContext, ExperienceTable>
    {
        public ExperienceTableAccessLayer(
            PortfolioContext myDbContext
            ) : base(myDbContext) { }



        public override List<ExperienceTable> List()
        {
            return _context.Experience.Include(e => e.Skills).OrderByDescending(e => e.StartDate).ToList();
        }

        public override ExperienceTable Add()
        {
            throw new NotImplementedException();
        }



        public override bool Validate(ExperienceTable entity)
        {
            throw new NotImplementedException();
        }

        public override ExperienceTable Get()
        {
            throw new NotImplementedException();
        }

        public override void Remove()
        {
            throw new NotImplementedException();
        }

        public override void Update()
        {
            throw new NotImplementedException();
        }

    }

}