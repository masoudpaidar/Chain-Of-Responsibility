using PiplineDesignPattern.CustomException;
using PiplineDesignPattern.PipLine;

namespace PiplineDesignPattern.MiddlewarePipeline;

public class ExceptionMiddleware : Handler , IHandler
{
    public void Build(CancellationToken cancellationToken , HttpContext httpContext)
    {
        try
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Exception Middleware Start......");

            if (httpContext.Country == "A")
                throw new ForbiddenException("access denied for this user ");
            
            
            base.Next(cancellationToken,httpContext);
        }
        catch (AppException e )
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($" exception message is : {e.Message} The statusCode is {e.ApiStatusCode} ");
            throw;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
    
}