using Portfolio.Object;
using Portfolio.Settings;
using Portfolio;
using System;
using System.Net.Mail;
using System.Net;
using System.Web;
using System.Linq;
using Portfolio.Exceptions;
using System.Security.Claims; 
using Microsoft.IdentityModel.Tokens;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.DependencyInjection;
using System.IdentityModel.Tokens.Jwt;
using Portfolio.Data.AccessObjects;
using Portfolio.Object.BDD;
using Portfolio.Route;
using System.Text;
using System.Collections.Generic;


namespace Portfolio.Services
{


    public class PortfolioService : IPortfolioService
    {
        private readonly IDataAccessObject           _dataAccessObject ;
        public PortfolioService(
            IServiceProvider services        
            ){
            _dataAccessObject = services.GetRequiredService<IDataAccessObject>();
            IOptions<SettingData> settingData = services.GetRequiredService<IOptions<SettingData>>();

        }

        public List<SkillCategoryTable> FetchSkills()
        {
            return _dataAccessObject.List<SkillCategoryTable>();
        }

        private static DateTime _convertFromUnixTimestamp(double timestamp)
        {
            DateTime origin = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            return origin.AddSeconds(timestamp);
        }
        private static double   _convertToUnixTimestamp(DateTime date)
        {
            DateTime origin = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            TimeSpan diff = date.ToUniversalTime() - origin;
            return Math.Floor(diff.TotalMilliseconds);
        }
    }

}