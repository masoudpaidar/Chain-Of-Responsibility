namespace PiplineDesignPattern.PipLine;

public interface IHandler
{
    void Build(CancellationToken cancellationToken, HttpContext httpContext);
    IHandler AddMiddleware(IHandler next);
}