using ItMarathon.Dal.Common.Contracts;
using ItMarathon.Dal.Context;
using ItMarathon.Dal.Entities;
using Microsoft.EntityFrameworkCore;

namespace ItMarathon.Dal.Repositories;

public class PropertyRepository(ApplicationDbContext repositoryContext) :
    RepositoryBase<Property>(repositoryContext), IPropertyRepository
{
    public async Task<IEnumerable<Property>> GetAllPropertiesAsync(bool trackChanges)
        => await FindAll(trackChanges).ToListAsync();

    public async Task<Property?> GetPropertyAsync(long propertyId, bool trackChanges)
        => await FindByCondition(property => property.Id.Equals(propertyId), trackChanges).SingleOrDefaultAsync();

    public void CreateProperty(Property property) => Create(property);

    public void DeleteProperty(Property property) => Delete(property);

    public async Task<IEnumerable<Property>> GetPropertyByProposalAsync(long proposalId, bool trackChanges)
        => await FindByCondition(property => property.ProposalId.Equals(proposalId), trackChanges).ToListAsync();
}