using ItMarathon.Dal.Common.Contracts;
using ItMarathon.Dal.Context;
using ItMarathon.Dal.Entities;
using Microsoft.EntityFrameworkCore;

namespace ItMarathon.Dal.Repositories;

public class AppUserRepository(ApplicationDbContext repositoryContext) :
    RepositoryBase<AppUser>(repositoryContext), IAppUserRepository
{
    public async Task<IEnumerable<AppUser>> GetAllAppUsersAsync(bool trackChanges)
        => await FindAll(trackChanges).ToListAsync();

    public async Task<AppUser?> GetAppUserAsync(long userId, bool trackChanges)
        => await FindByCondition(user => user.Id.Equals(userId), trackChanges).SingleOrDefaultAsync();

    public async Task<AppUser?> GetAppUserByTokenAsync(string token, bool trackChanges)
        => await FindAll(trackChanges)
                .Where(user => user.AccessTokens!.Any(accessToken => accessToken.Token == token))
                .Include(user => user.AccessTokens)
                .SingleOrDefaultAsync();

    public void CreateAppUser(AppUser user) => Create(user);

    public void DeleteAppUser(AppUser user) => Delete(user);
}