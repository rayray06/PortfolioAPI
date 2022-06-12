using System;
using Microsoft.AspNetCore.Http;
using Portfolio.Local;

namespace Portfolio.Exceptions{
    class MailInUseException : PortfolioException
    {
        
        public MailInUseException(): base("Mail déjà utilisé",STRING.Exception.SIGNUP.CLIENT.MAILINUSE,StatusCodes.Status403Forbidden) {}
        public MailInUseException(string mail): base(mail + " déjà utlisé",STRING.Exception.SIGNUP.CLIENT.MAILINUSE,StatusCodes.Status403Forbidden) {}

    }
}