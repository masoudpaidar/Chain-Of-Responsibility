namespace PiplineDesignPattern.PipLine;

public abstract class Handler
{
    private IHandler _next { get; set; }
    
    public virtual void Next(CancellationToken cancellationToken, HttpContext httpContext)
    {
        _next.Build(cancellationToken,httpContext);
    } 
    
    public IHandler AddMiddleware(IHandler next)
    {
        _next = next;
        return _next;
    }
}