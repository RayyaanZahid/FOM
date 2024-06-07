public class XmlMiddleware
{
    private readonly RequestDelegate _next;

    public XmlMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task Invoke(HttpContext context)
    {
        context.Response.ContentType = "application/xml";
        await _next(context);
    }
}
