using PiplineDesignPattern.PipLine;

namespace PiplineDesignPattern.MiddlewarePipeline;

public class RouteMiddleware : Handler,IHandler
{
    public void Build(CancellationToken cancellationToken , HttpContext httpContext)
    {
        Console.BackgroundColor = ConsoleColor.Green;
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Start Route");
        Console.WriteLine("Finish Route");
    }
}