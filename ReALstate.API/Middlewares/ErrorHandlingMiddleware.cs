using ReALstate.Domain.Exceptions;

namespace ReALstate.API.Middlewares
{
    public class ErrorHandlingMiddleware : IMiddleware
	{
        // This method is called by the runtime. Use this method to configure the HTTP request pipeline.
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
		{

            // If an exception is thrown, the middleware will catch it and return a response with the appropriate status code and message.
            try
            {
                await next.Invoke(context);
            }
            catch (NotFoundException ex)
            {
                context.Response.StatusCode = 404;
                await context.Response.WriteAsync(ex.Message);
            }
            catch (Exception ex)
            {
                context.Response.StatusCode = 500;
                await context.Response.WriteAsync("Server error!");

            }
        }
    }
}