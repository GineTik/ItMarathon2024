using ItMarathon.Api.Common;

namespace ItMarathon.Api.Utilities;

/// <summary>
/// Provides utility methods for authorization.
/// </summary>
public static class AuthUtility
{
    /// <summary>
    /// Retrieves the current user's ID from the HTTP context claims.
    /// </summary>
    /// <param name="context">The HttpContext which contains the user information.</param>
    /// <returns>Returns the user ID from the claims.</returns>
    public static long GetCurrentUserId(HttpContext context)
    {
        var userId = Convert.ToInt64(context.User.Claims
            .First(c => c.Type == Consts.Authorization.UserIdClaim).Value);

        return userId;
    }
}
