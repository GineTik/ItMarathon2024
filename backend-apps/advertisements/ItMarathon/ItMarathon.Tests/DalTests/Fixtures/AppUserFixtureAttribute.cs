using AutoFixture;
using ItMarathon.Dal.Context;
using ItMarathon.Dal.Entities;

namespace ItMarathon.Tests.DalTests.Fixtures;

public class AppUserFixtureAttribute : BaseDataAttribute
{
    public AppUserFixtureAttribute()
        : base(ConfigureFixture)
    {
    }

    private static void ConfigureFixture(IFixture fixture)
    {
        var dbContext = fixture.Create<ApplicationDbContext>();

        dbContext.AppUsers.AddRange(fixture.CreateMany<AppUser>(2));
        dbContext.SaveChanges();

        fixture.Inject(dbContext);
    }
}
