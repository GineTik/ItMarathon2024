using AutoFixture;
using ItMarathon.Dal.Context;
using ItMarathon.Dal.Entities;

namespace ItMarathon.Tests.DalTests.Fixtures;

public class PropertyFixtureAttribute : BaseDataAttribute
{
    public PropertyFixtureAttribute()
        : base(ConfigureFixture)
    {
    }

    private static void ConfigureFixture(IFixture fixture)
    {
        var dbContext = fixture.Create<ApplicationDbContext>();

        dbContext.Properties.AddRange(fixture.CreateMany<Property>(2));
        dbContext.SaveChanges();

        fixture.Inject(dbContext);
    }
}