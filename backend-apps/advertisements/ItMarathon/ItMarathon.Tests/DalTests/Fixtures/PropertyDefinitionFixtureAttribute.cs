using AutoFixture;
using ItMarathon.Dal.Context;
using ItMarathon.Dal.Entities;

namespace ItMarathon.Tests.DalTests.Fixtures;

public class PropertyDefinitionFixtureAttribute : BaseDataAttribute
{
    public PropertyDefinitionFixtureAttribute()
        : base(ConfigureFixture)
    {
    }

    private static void ConfigureFixture(IFixture fixture)
    {
        var dbContext = fixture.Create<ApplicationDbContext>();

        dbContext.PropertiesDefinition.Add(fixture.Build<PropertyDefinition>()
            .With(pd => pd.IsMandatory, false)
            .Create());

        dbContext.PropertiesDefinition.Add(fixture.Build<PropertyDefinition>()
            .With(pd => pd.IsMandatory, true)
            .Create());

        dbContext.SaveChanges();

        fixture.Inject(dbContext);
    }
}