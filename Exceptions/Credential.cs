using System;
using Microsoft.AspNetCore.Http;
using Portfolio.Local;

namespace Portfolio.Exceptions
{
    class CredentialException : PortfolioException
    {
        
        public CredentialException(): base("Login ou Mot de passe Incorrect",STRING.Exception.LOGIN.CLIENT.WRONGCREDENTIAL,StatusCodes.Status403Forbidden) {}

    }
}