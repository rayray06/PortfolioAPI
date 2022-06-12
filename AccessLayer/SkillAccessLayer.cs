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
    public class SkillAccessLayer : AccessLayer<PortfolioContext, SkillTable>
    {
        public SkillAccessLayer(
            PortfolioContext myDbContext
            ) : base(myDbContext) { }



        public override List<SkillTable> List()
        {
            throw new NotImplementedException();
        }

        public override SkillTable Add()
        {
            throw new NotImplementedException();
        }



        public override bool Validate(SkillTable entity)
        {
            throw new NotImplementedException();
        }

        public override SkillTable Get()
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