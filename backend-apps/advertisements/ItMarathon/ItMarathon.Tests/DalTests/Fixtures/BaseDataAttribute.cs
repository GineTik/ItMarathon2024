using AutoFixture;
using AutoFixture.AutoMoq;
using AutoFixture.Xunit2;
using ItMarathon.Dal.Context;
using Microsoft.EntityFrameworkCore;

namespace ItMarathon.Tests.DalTests.Fixtures;

public abstract class BaseDataAttribute : AutoDataAttribute
{
    protected BaseDataAttribute()
        : base(() => FixtureFactory(out _))
    {
    }

    protected BaseDataAttribute(Action<IFixture> configureFixture)
        : base(() => FixtureFactory(out var f, configureFixture))
    {
    }

    private static IFixture FixtureFactory(out IFixture resultFixture, Action<IFixture> configureFixture = null!)
    {
        var fixture = new Fixture();

        fixture.Customize(new AutoMoqCustomization { ConfigureMembers = true });
        fixture.Behaviors.Remove(fixture.Behaviors.OfType<ThrowingRecursionBehavior>().FirstOrDefault());
        fixture.Behaviors.Add(new OmitOnRecursionBehavior());

        var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                    .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                    .Options;

        var dbContext = new ApplicationDbContext(options);
        fixture.Inject(dbContext);

        configureFixture?.Invoke(fixture);
        resultFixture = fixture;

        return fixture;
    }
}