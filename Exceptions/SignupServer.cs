using System;
using Microsoft.AspNetCore.Http;
using Portfolio.Local;

namespace Portfolio.Exceptions
{
    class SignupServerException : PortfolioException
    {
        
        public SignupServerException(): base("Serveur Error",STRING.Exception.SIGNUP.SERVER.SIGNUPERROR,StatusCodes.Status500InternalServerError) {}

    }
}