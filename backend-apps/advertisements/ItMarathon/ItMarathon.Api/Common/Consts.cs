namespace ItMarathon.Api.Common
{
    /// <summary>
    /// Provides a storage of constant values used throughout the application.
    /// </summary>
    public static class Consts
    {
        /// <summary>
        /// Contains constants related to authorization policies and claims.
        /// </summary>
        public static class Authorization
        {
            /// <summary>
            /// The name of the policy for users with SuperUser access.
            /// </summary>
            public const string SuperUserPolicy = "SuperUser";

            /// <summary>
            /// The claim type used to indicate if a user is a SuperUser.
            /// </summary>
            public const string IsSuperUserClaim = "IsSuperUser";

            /// <summary>
            /// The claim type used to store the unique identifier of the user.
            /// </summary>
            public const string UserIdClaim = "UserId";
        }
    }
}
