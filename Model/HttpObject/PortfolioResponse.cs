using System.Collections.Generic;
using Portfolio.Exceptions;

namespace Portfolio.Object
{
    public abstract class PortfolioResponseBase
    {
        public string Message { get; set; }
        public int Status { get; set; }
        public int Code { get; set; }
    }

    public class PortfolioResponse: PortfolioResponseBase
    {
        public PortfolioResponse() 
        {
            Status = 200;
            Code = 0;
        }
        
        public PortfolioResponse(string message)
        {
            Message = message;
            Status = 200;
            Code = 0;
        }

        public PortfolioResponse(PortfolioException exec)
        {
            Message = exec.Message;
            Status = exec.StatusCode;
            Code = exec.ErrorCode;
        }
    }

    public class PortfolioResponse<T> : PortfolioResponse
    {
        public T Content { get; set; }

        public PortfolioResponse()          { }
        public PortfolioResponse(PortfolioException exec):base(exec){}
        public PortfolioResponse(T content)
        {
            Content = content;
        }
    }

    public class PortfolioResponseList<T> : PortfolioResponse
    {
        public IEnumerable<T> Content { get; set; }

        public PortfolioResponseList()                      { }
        
        public PortfolioResponseList(PortfolioException exec):base(exec){}
        public PortfolioResponseList(IEnumerable<T> content)
        {
            Content = content;
        }
    }
}