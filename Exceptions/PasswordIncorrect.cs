using System;
using Portfolio.Local;

using Microsoft.AspNetCore.Http;

namespace Portfolio.Exceptions
{
    class PasswordIncorrectException : PortfolioException
    {
        
        public PasswordIncorrectException(): base("Password Incorrect",STRING.Exception.SIGNUP.CLIENT.PASSWORDINCORRECT,StatusCodes.Status403Forbidden) {}
        public PasswordIncorrectException(string message): base("Password Incorrect : " + message,STRING.Exception.SIGNUP.CLIENT.PASSWORDINCORRECT,StatusCodes.Status403Forbidden) {}

    }
}