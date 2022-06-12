using Microsoft.AspNetCore.Http;
namespace Portfolio.Exceptions{
    public class PortfolioDAOException: PortfolioException
    {
        private const int statusCode = StatusCodes.Status500InternalServerError;
        
        public PortfolioDAOException(int errorCode): base(  null, 
                                                        errorCode, 
                                                        statusCode) { }
        public PortfolioDAOException(   string message, 
                                    int    errorCode): base(message, 
                                                            errorCode, 
                                                            statusCode) { }
    }
}