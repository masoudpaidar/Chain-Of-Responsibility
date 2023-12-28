using PiplineDesignPattern.PipLine;

namespace PiplineDesignPattern.MiddlewarePipeline;

public class Cors: Handler,IHandler
{
    public void Build(CancellationToken cancellationToken, HttpContext httpContext)
    {
        Console.BackgroundColor = ConsoleColor.Yellow;
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Start Cors");
        base.Next(cancellationToken,httpContext);
        Console.WriteLine("Finish Cors");
    }
}