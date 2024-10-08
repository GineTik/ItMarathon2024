namespace ItMarathon.Dal.Common.Contracts;

/// <summary>
/// Interface for managing unit of work pattern, providing repositories and saving changes.
/// </summary>
public interface IUnitOfWork
{
    /// <summary>
    /// Gets the repository for managing AppUser entities.
    /// </summary>
    IAppUserRepository AppUsers { get; }

    /// <summary>
    /// Gets the repository for managing PropertyDefinition entities.
    /// </summary>
    IPropertyDefinitionRepository PropertyDefinitions { get; }

    /// <summary>
    /// Gets the repository for managing Property entities.
    /// </summary>
    IPropertyRepository Properties { get; }

    /// <summary>
    /// Gets the repository for managing PropertyValue entities.
    /// </summary>
    IPropertyValueRepository PropertyValues { get; }

    /// <summary>
    /// Gets the repository for managing ProposalPhoto entities.
    /// </summary>
    IProposalPhotoRepository ProposalPhotos { get; }

    /// <summary>
    /// Gets the repository for managing Proposal entities.
    /// </summary>
    IProposalRepository Proposals { get; }

    /// <summary>
    /// Gets the repository for managing Request entities.
    /// </summary>
    IRequestRepository Requests { get; }

    /// <summary>
    /// Saves all changes made in the context to the database.
    /// </summary>
    /// <param name="cancellationToken">A token to cancel the asynchronous operation.</param>
    /// <returns>True if the changes were successfully saved; otherwise, false.</returns>
    Task<bool> SaveChangesAsync(CancellationToken cancellationToken = default);
}