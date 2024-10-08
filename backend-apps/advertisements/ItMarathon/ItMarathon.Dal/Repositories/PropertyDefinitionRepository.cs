using ItMarathon.Dal.Common.Contracts;
using ItMarathon.Dal.Context;
using ItMarathon.Dal.Entities;
using Microsoft.EntityFrameworkCore;

namespace ItMarathon.Dal.Repositories;

public class PropertyDefinitionRepository(ApplicationDbContext repositoryContext) :
    RepositoryBase<PropertyDefinition>(repositoryContext), IPropertyDefinitionRepository
{
    public async Task<IEnumerable<PropertyDefinition>> GetAllPropertyDefinitionsAsync(bool trackChanges)
    {
        return await FindAll(trackChanges)
            .Include(pd => pd.PropertyValues!)
            .ThenInclude(pd => pd!.ParentPropertyValue)
            .ToListAsync();
    }

    public async Task<PropertyDefinition?> GetPropertyDefinitionAsync(long propertyDefinitionId, bool trackChanges)
    {
        return await FindByCondition(pd => pd.Id.Equals(propertyDefinitionId), trackChanges)
            .Include(pd => pd.PropertyValues!)
                        .ThenInclude(pd => pd.ParentPropertyValue)
            .FirstOrDefaultAsync(pd => pd.Id == propertyDefinitionId);
    }

    public async Task<IEnumerable<PropertyDefinition>> GetMandatoryPropertyDefinitionsAsync(bool trackChanges)
    {
        return await FindByCondition(pd => pd.IsMandatory.Equals(true), trackChanges)
            .ToListAsync();
    }

    public void CreatePropertyDefinition(PropertyDefinition propertyDefinition) => Create(propertyDefinition);

    public void DeletePropertyDefinition(PropertyDefinition propertyDefinition) => Delete(propertyDefinition);
}