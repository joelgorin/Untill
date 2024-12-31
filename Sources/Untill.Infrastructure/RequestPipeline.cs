using Microsoft.AspNetCore.Builder;

using Untill.Infrastructure.Common.Middleware;

namespace Untill.Infrastructure;

public static class RequestPipeline
{
    public static IApplicationBuilder UseInfrastructure(this IApplicationBuilder app)
    {
        app.UseMiddleware<EventualConsistencyMiddleware>();
        return app;
    }
}