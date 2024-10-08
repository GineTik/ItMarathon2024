using ItMarathon.Dal.Common.Contracts;
using ItMarathon.Dal.Context;
using ItMarathon.Dal.Entities;
using Microsoft.EntityFrameworkCore;

namespace ItMarathon.Dal.Repositories;

public class ProposalPhotoRepository(ApplicationDbContext repositoryContext) :
    RepositoryBase<ProposalPhoto>(repositoryContext), IProposalPhotoRepository
{
    public async Task<ProposalPhoto?> GetProposalPhotoAsync(long proposalPhotoId, bool trackChanges)
        => await FindByCondition(c => c.Id.Equals(proposalPhotoId), trackChanges).SingleOrDefaultAsync();

    public void CreateProposalPhoto(ProposalPhoto proposalPhoto) => Create(proposalPhoto);

    public void DeleteProposalPhoto(ProposalPhoto proposalPhoto) => Delete(proposalPhoto);
}
