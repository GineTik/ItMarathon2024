using ItMarathon.Dal.Common.Contracts;
using ItMarathon.Dal.Context;
using ItMarathon.Dal.Entities;
using Microsoft.EntityFrameworkCore;

namespace ItMarathon.Dal.Repositories;

public class RequestRepository(ApplicationDbContext repositoryContext) :
    RepositoryBase<Request>(repositoryContext), IRequestRepository
{
    public async Task<IEnumerable<Request>> GetAllRequestsAsync(bool trackChanges)
        => await FindAll(trackChanges).ToListAsync();

    public async Task<Request?> GetRequestAsync(long requestId, bool trackChanges)
        => await FindByCondition(request => request.Id.Equals(requestId), trackChanges).SingleOrDefaultAsync();

    public void CreateRequest(Request request) => Create(request);

    public void DeleteRequest(Request request) => Delete(request);
}