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
    public class EducationTableAccessLayer : AccessLayer<PortfolioContext, EducationTable>
    {
        public EducationTableAccessLayer(
            PortfolioContext myDbContext
            ) : base(myDbContext) { }



        public override List<EducationTable> List()
        {
            return _context.Education.OrderByDescending(e => e.StartDate).ToList();
        }

        public override EducationTable Add()
        {
            throw new NotImplementedException();
        }



        public override bool Validate(EducationTable entity)
        {
            throw new NotImplementedException();
        }

        public override EducationTable Get()
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