using System;
using Microsoft.AspNetCore.Http;
namespace Portfolio.Exceptions{   
   public class PortfolioException: Exception
    {
        public int ErrorCode  { get; set; }
        public int StatusCode { get; set; }

        public PortfolioException(
            string message,
            int    errorCode,
            int    statusCode
        ) 
            : base(message)
        {
            ErrorCode  = errorCode;
            StatusCode = statusCode;

            if (message != null && 
                StatusCode == StatusCodes.Status204NoContent)
                    StatusCode = StatusCodes.Status400BadRequest;
        }
    }
}