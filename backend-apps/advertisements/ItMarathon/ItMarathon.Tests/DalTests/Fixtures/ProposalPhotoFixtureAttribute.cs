using AutoFixture;
using ItMarathon.Dal.Context;
using ItMarathon.Dal.Entities;

namespace ItMarathon.Tests.DalTests.Fixtures;

public class ProposalPhotoFixtureAttribute : BaseDataAttribute
{
    public ProposalPhotoFixtureAttribute()
        : base(ConfigureFixture)
    {
    }

    private static void ConfigureFixture(IFixture fixture)
    {
        var dbContext = fixture.Create<ApplicationDbContext>();

        dbContext.ProposalsPhoto.AddRange(fixture.CreateMany<ProposalPhoto>(2));
        dbContext.SaveChanges();

        fixture.Inject(dbContext);
    }
}