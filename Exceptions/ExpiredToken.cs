using System;
using Microsoft.AspNetCore.Http;
using Portfolio.Local;

namespace Portfolio.Exceptions
{
    class ExpiredTokenException : PortfolioException
    {
        
        public ExpiredTokenException(): base("Mauvais Token",STRING.Exception.TOKEN.CLIENT.EXPIREDTOKEN,StatusCodes.Status403Forbidden) {}

    }
}