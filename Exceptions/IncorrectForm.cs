using System;
using Microsoft.AspNetCore.Http;
using Portfolio.Local;

namespace Portfolio.Exceptions
{
    class IncorrectFormException : PortfolioException
    {
        
        public IncorrectFormException(): base("Erreur dans le formulaire envoyée",STRING.Exception.SIGNUP.CLIENT.INCORRECTFORM,StatusCodes.Status403Forbidden) {}

    }
}