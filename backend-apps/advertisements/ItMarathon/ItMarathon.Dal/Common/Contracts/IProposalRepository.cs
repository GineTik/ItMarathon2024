using ItMarathon.Dal.Entities;
using Microsoft.AspNetCore.OData.Query;

namespace ItMarathon.Dal.Common.Contracts;

/// <summary>
/// Interface for managing Proposal entities in the repository.
/// </summary>
public interface IProposalRepository : IRepositoryBase<Proposal>
{
    /// <summary>
    /// Retrieves list of Proposals entities.
    /// </summary>
    /// <param name="trackChanges">Indicates whether to track changes in the Entity Framework context.</param>
    /// <returns>A paginated list of Proposal entities.</returns>
    Task<IQueryable<Proposal>> GetProposalsAsync(bool trackChanges);

    /// <summary>
    /// Retrieves a Proposal entity by its ID.
    /// </summary>
    /// <param name="proposalId">The ID of the proposal.</param>
    /// <param name="trackChanges">Indicates whether to track changes in the Entity Framework context.</param>
    /// <returns>The Proposal entity, or null if not found.</returns>
    Task<Proposal?> GetProposalAsync(long proposalId, bool trackChanges);

    /// <summary>
    /// Creates a new Proposal entity.
    /// </summary>
    /// <param name="proposal">The Proposal entity.</param>
    void CreateProposal(Proposal proposal);

    /// <summary>
    /// Deletes a Proposal entity.
    /// </summary>
    /// <param name="proposal">The Proposal entity.</param>
    void DeleteProposal(Proposal proposal);
}