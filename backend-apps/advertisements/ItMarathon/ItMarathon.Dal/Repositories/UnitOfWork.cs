using ItMarathon.Dal.Common.Contracts;
using ItMarathon.Dal.Context;

namespace ItMarathon.Dal.Repositories;

internal sealed class UnitOfWork(ApplicationDbContext dbContext) : IUnitOfWork
{
    private readonly ApplicationDbContext _dbContext = dbContext;

    public IAppUserRepository AppUsers { get; set; }
        = new AppUserRepository(dbContext);

    public IPropertyDefinitionRepository PropertyDefinitions { get; set; }
        = new PropertyDefinitionRepository(dbContext);

    public IPropertyRepository Properties { get; set; }
        = new PropertyRepository(dbContext);

    public IPropertyValueRepository PropertyValues { get; set; }
        = new PropertyValueRepository(dbContext);

    public IProposalPhotoRepository ProposalPhotos { get; set; }
        = new ProposalPhotoRepository(dbContext);

    public IProposalRepository Proposals { get; set; }
        = new ProposalRepository(dbContext);

    public IRequestRepository Requests { get; set; }
        = new RequestRepository(dbContext);

    public async Task<bool> SaveChangesAsync(CancellationToken cancellationToken = default) =>
        await _dbContext.SaveChangesAsync(cancellationToken) > 0;
}
