using PiplineDesignPattern.PipLine;

namespace PiplineDesignPattern.MiddlewarePipeline;

public class AuthorizedMiddleware : Handler,IHandler
{
    public void Build(CancellationToken cancellationToken, HttpContext httpContext)
    {
        Console.BackgroundColor = ConsoleColor.Red;
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Starting auth");
        // Validate
        base.Next(cancellationToken,httpContext);
        Console.WriteLine("Finish auth");
    }
}