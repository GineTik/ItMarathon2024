using ItMarathon.Dal.Common.Contracts;
using ItMarathon.Dal.Context;
using ItMarathon.Dal.Entities;
using Microsoft.EntityFrameworkCore;

namespace ItMarathon.Dal.Repositories;

public class PropertyValueRepository(ApplicationDbContext repositoryContext) :
    RepositoryBase<PropertyValue>(repositoryContext), IPropertyValueRepository
{
    public async Task<IEnumerable<PropertyValue>> GetAllPropertyValuesAsync(bool trackChanges)
        => await FindAll(trackChanges).ToListAsync();

    public async Task<PropertyValue?> GetPropertyValueAsync(long propertyValueId, bool trackChanges)
        => await FindByCondition(property => property.Id.Equals(propertyValueId), trackChanges).SingleOrDefaultAsync();

    public void CreatePropertyValue(PropertyValue propertyValue) => Create(propertyValue);

    public void DeletePropertyValue(PropertyValue propertyValue) => Delete(propertyValue);
}
