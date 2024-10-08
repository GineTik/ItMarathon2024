using AutoFixture;
using ItMarathon.Dal.Context;
using ItMarathon.Dal.Entities;

namespace ItMarathon.Tests.DalTests.Fixtures;

public class ProposalFixtureAttribute : BaseDataAttribute
{
    public ProposalFixtureAttribute()
        : base(ConfigureFixture)
    {
    }

    private static void ConfigureFixture(IFixture fixture)
    {
        var dbContext = fixture.Create<ApplicationDbContext>();

        dbContext.Proposals.AddRange(fixture.CreateMany<Proposal>(2));
        dbContext.SaveChanges();

        fixture.Inject(dbContext);
    }
}