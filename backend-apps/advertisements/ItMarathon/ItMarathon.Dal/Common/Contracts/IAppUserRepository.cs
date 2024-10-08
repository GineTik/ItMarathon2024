using ItMarathon.Dal.Entities;

namespace ItMarathon.Dal.Common.Contracts;

/// <summary>
/// Interface for managing AppUser entities in the repository.
/// </summary>
public interface IAppUserRepository
{
    /// <summary>
    /// Retrieves all AppUser entities.
    /// </summary>
    /// <param name="trackChanges">Indicates whether to track changes in the Entity Framework context.</param>
    /// <returns>Collection of AppUser entities.</returns>
    Task<IEnumerable<AppUser>> GetAllAppUsersAsync(bool trackChanges);

    /// <summary>
    /// Retrieves an AppUser entity by userId.
    /// </summary>
    /// <param name="userId">The ID of the user.</param>
    /// <param name="trackChanges">Indicates whether to track changes in the Entity Framework context.</param>
    /// <returns>The AppUser entity, or null if not found.</returns>
    Task<AppUser?> GetAppUserAsync(long userId, bool trackChanges);

    /// <summary>
    /// Retrieves an AppUser entity by token.
    /// </summary>
    /// <param name="token">The token of the user.</param>
    /// <param name="trackChanges">Indicates whether to track changes in the Entity Framework context.</param>
    /// <returns>The AppUser entity, or null if not found.</returns>
    Task<AppUser?> GetAppUserByTokenAsync(string token, bool trackChanges);

    /// <summary>
    /// Creates a new AppUser entity.
    /// </summary>
    /// <param name="user">The AppUser entity.</param>
    void CreateAppUser(AppUser user);

    /// <summary>
    /// Deletes an AppUser entity.
    /// </summary>
    /// <param name="user">The AppUser entity.</param>
    void DeleteAppUser(AppUser user);
}