using System;
using Microsoft.AspNetCore.Http;
using Portfolio.Local;

namespace Portfolio.Exceptions
{
    class WrongTokenException : PortfolioException
    {
        
        public WrongTokenException(): base("Une erreur a été détecté avec votre Token",STRING.Exception.TOKEN.CLIENT.WRONGTOKEN,StatusCodes.Status403Forbidden) {}

    }
}