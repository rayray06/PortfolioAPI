using System;
using System.Collections.Generic;
using System.Linq;
using Portfolio;
using Portfolio.Object.BDD;
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
    public class SkillCategoryAccessLayer : AccessLayer<PortfolioContext, SkillCategoryTable>
    {
        public SkillCategoryAccessLayer(
            PortfolioContext myDbContext
            ) : base(myDbContext) { }



        public override List<SkillCategoryTable> List()
        {
            return _context.SkillCategory.Include(c => c.Skills).ToList();
        }

        public override SkillCategoryTable Add()
        {
            throw new NotImplementedException();
        }



        public override bool Validate(SkillCategoryTable entity)
        {
            throw new NotImplementedException();
        }

        public override SkillCategoryTable Get()
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