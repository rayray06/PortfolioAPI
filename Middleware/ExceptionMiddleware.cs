using System;
using System.Net.Mime;
using System.Text.Json;
using System.Threading.Tasks;
using Portfolio.Local;
using Portfolio.Exceptions;
using Portfolio.Object;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace PortfolioMiddlewares
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate              _next;
        private readonly ILogger<ExceptionMiddleware> _logger;
    
        public ExceptionMiddleware(
            RequestDelegate              next, 
            ILogger<ExceptionMiddleware> logger
        ) {
            _logger = logger;
            _next   = next;
        }
    
        public async Task InvokeAsync(
            HttpContext httpContext
        ) {
            try
            {
                await _next(httpContext);
            }
            catch (PortfolioException exception)
            {
                _logger.LogError(string.Format("RialyPay managed exception: {0} - {1}",
                                                exception.ErrorCode, 
                                                exception.Message));

                await HandleAPIExceptionAsync(httpContext, exception);
            }
            catch (Exception exception)
            {
                _logger.LogError(string.Format("Something went wrong: {0}", 
                                                exception));

                await HandleExceptionAsync(httpContext, exception);
            }
        }
    
        private static Task HandleExceptionAsync(
            HttpContext context, 
            Exception exception
        ) {
#if DEBUG
            string content = exception.ToString();
#else
            string content = "Internal Server Error.";
#endif

            context
                .Response
                .StatusCode = StatusCodes.Status500InternalServerError;

            context
                .Response
                .ContentType = MediaTypeNames.Application.Json;

            return context
                    .Response
                    .WriteAsync( JsonSerializer.Serialize(new PortfolioResponse
                    {
                        Message = content
                    }));
        }

        private static Task HandleAPIExceptionAsync(
            HttpContext    context, 
            PortfolioException pacException
        ) {
            context
                .Response
                .StatusCode = pacException.StatusCode;

            context
                .Response
                .ContentType = MediaTypeNames.Application.Json;

            if (pacException.StatusCode == StatusCodes.Status401Unauthorized)
                context
                    .Response
                    .Headers
                    .Add(STRING.Exception.AUTH_HEADER, 
                        string.Format("Code: {0}", 
                                        pacException.ErrorCode));

            if (pacException.StatusCode == StatusCodes.Status204NoContent)
                return Task.CompletedTask;
                
            return context
                    .Response
                    .WriteAsync(JsonSerializer.Serialize(new PortfolioResponse
                    {
                        Message = string.Format("ecode: {0} -- {1}",
                                                pacException.ErrorCode, 
                                                pacException.Message)
                    }));
        }
    }
}