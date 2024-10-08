using ItMarathon.Dal.Entities;

namespace ItMarathon.Dal.Common.Contracts;

/// <summary>
/// Interface for managing Request entities in the repository.
/// </summary>
public interface IRequestRepository
{
    /// <summary>
    /// Retrieves all Request entities.
    /// </summary>
    /// <param name="trackChanges">Indicates whether to track changes in the Entity Framework context.</param>
    /// <returns>Collection of Request entities.</returns>
    Task<IEnumerable<Request>> GetAllRequestsAsync(bool trackChanges);

    /// <summary>
    /// Retrieves a Request entity by its ID.
    /// </summary>
    /// <param name="requestId">The ID of the request.</param>
    /// <param name="trackChanges">Indicates whether to track changes in the Entity Framework context.</param>
    /// <returns>The Request entity, or null if not found.</returns>
    Task<Request?> GetRequestAsync(long requestId, bool trackChanges);

    /// <summary>
    /// Creates a new Request entity.
    /// </summary>
    /// <param name="request">The Request entity.</param>
    void CreateRequest(Request request);

    /// <summary>
    /// Deletes a Request entity.
    /// </summary>
    /// <param name="request">The Request entity.</param>
    void DeleteRequest(Request request);
}