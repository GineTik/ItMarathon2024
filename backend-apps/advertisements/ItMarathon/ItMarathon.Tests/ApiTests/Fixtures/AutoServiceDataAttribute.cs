using AutoFixture;
using AutoFixture.AutoMoq;
using AutoFixture.Xunit2;

namespace ItMarathon.Tests.ApiTests.Fixtures;

public class AutoServiceDataAttribute : AutoDataAttribute
{
    public AutoServiceDataAttribute()
        : base(FixtureFactory)
    {
    }

    public static IFixture FixtureFactory()
    {
        var fixture = new Fixture();
        fixture.Behaviors.Remove(fixture.Behaviors.OfType<ThrowingRecursionBehavior>().FirstOrDefault());
        fixture.Behaviors.Add(new OmitOnRecursionBehavior());

        fixture.Customize(new AutoMoqCustomization() { ConfigureMembers = true });

        return fixture;
    }
}