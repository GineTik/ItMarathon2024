using ItMarathon.Dal.Entities;

namespace ItMarathon.Dal.Common.Contracts;

/// <summary>
/// Interface for managing ProposalPhoto entities in the repository.
/// </summary>
public interface IProposalPhotoRepository
{
    /// <summary>
    /// Retrieves a ProposalPhoto entity by its ID.
    /// </summary>
    /// <param name="proposalPhotoId">The ID of the proposal photo.</param>
    /// <param name="trackChanges">Indicates whether to track changes in the Entity Framework context.</param>
    /// <returns>The ProposalPhoto entity, or null if not found.</returns>
    Task<ProposalPhoto?> GetProposalPhotoAsync(long proposalPhotoId, bool trackChanges);

    /// <summary>
    /// Creates a new ProposalPhoto entity.
    /// </summary>
    /// <param name="proposalPhoto">The ProposalPhoto entity.</param>
    void CreateProposalPhoto(ProposalPhoto proposalPhoto);

    /// <summary>
    /// Deletes a ProposalPhoto entity.
    /// </summary>
    /// <param name="proposalPhoto">The ProposalPhoto entity.</param>
    void DeleteProposalPhoto(ProposalPhoto proposalPhoto);
}