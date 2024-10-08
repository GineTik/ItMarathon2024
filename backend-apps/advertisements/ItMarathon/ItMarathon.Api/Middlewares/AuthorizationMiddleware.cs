using ItMarathon.Api.Common;
using ItMarathon.Dal.Common.Contracts;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace ItMarathon.Api.Middlewares;

/// <summary>
/// Middleware to handle authorization, ensuring that
/// users cannot access protected resources without a valid token.
/// </summary>
/// <param name="next">The delegate representing the remaining middleware in the request pipeline.</param>
public class AuthorizationMiddleware(RequestDelegate next)
{
    /// <summary>
    /// Invokes the middleware asynchronously.
    /// </summary>
    /// <param name="context">Encapsulates all HTTP-specific information about an individual HTTP request.</param>
    /// <param name="unitOfWork">The unit of work and repository pattern utility for database access.</param>
    /// <returns>A task that represents the completion of middleware execution.</returns>
    public async Task InvokeAsync(HttpContext context, IUnitOfWork unitOfWork)
    {
        var endpoint = context.GetEndpoint();

        if (endpoint?.Metadata.GetMetadata<IAllowAnonymous>() is not null)
        {
            await next(context);
            return;
        }

        var authHeader = context.Request.Headers.Authorization
            .FirstOrDefault();

        if (string.IsNullOrEmpty(authHeader) || !authHeader.StartsWith("Bearer "))
        {
            context.Response.StatusCode = 401;
            return;
        }

        var token = authHeader.Split(" ")[1];

        if (token is null || await IsTokenExpired(token, unitOfWork))
        {
            context.Response.StatusCode = 401;
            return;
        }

        var user = await unitOfWork.AppUsers
            .GetAppUserByTokenAsync(token, false);

        if (user is null)
        {
            context.Response.StatusCode = 400;
            return;
        }

        if (endpoint?.Metadata.GetMetadata<IAuthorizeData>()?.Policy
            is Consts.Authorization.SuperUserPolicy
            && !user.IsSuperuser)
        {
            context.Response.StatusCode = 403;
            return;
        }

        var claims = new List<Claim>()
        {
            new(Consts.Authorization.UserIdClaim, user.Id.ToString()),
            new(Consts.Authorization.IsSuperUserClaim, user.IsSuperuser.ToString())
        };
        var claimsPrincipal = new ClaimsPrincipal(new ClaimsIdentity(claims));
        context.User = claimsPrincipal;
        await next(context);
    }

    private static async Task<bool> IsTokenExpired(string token, IUnitOfWork unitOfWork)
    {
        var user = await unitOfWork.AppUsers
            .GetAppUserByTokenAsync(token, false);

        if (user is null)
        {
            return true;
        }

        var actualToken = user!.AccessTokens!
            .OrderByDescending(s => s.CreatedAt)
            .FirstOrDefault();

        return actualToken!.CreatedAt.AddSeconds(3600) < DateTime.UtcNow;
    }
}
