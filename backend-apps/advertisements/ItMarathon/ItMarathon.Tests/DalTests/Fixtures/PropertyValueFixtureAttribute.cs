using AutoFixture;
using ItMarathon.Dal.Context;
using ItMarathon.Dal.Entities;

namespace ItMarathon.Tests.DalTests.Fixtures;

public class PropertyValueFixtureAttribute : BaseDataAttribute
{
    public PropertyValueFixtureAttribute()
        : base(ConfigureFixture)
    {
    }

    private static void ConfigureFixture(IFixture fixture)
    {
        var dbContext = fixture.Create<ApplicationDbContext>();

        dbContext.PropertyValues.AddRange(fixture.CreateMany<PropertyValue>(2));
        dbContext.SaveChanges();

        fixture.Inject(dbContext);
    }
}