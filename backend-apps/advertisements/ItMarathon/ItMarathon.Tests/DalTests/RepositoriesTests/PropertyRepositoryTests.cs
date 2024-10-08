using FluentAssertions;
using ItMarathon.Dal.Context;
using ItMarathon.Dal.Entities;
using ItMarathon.Dal.Repositories;
using ItMarathon.Tests.DalTests.Fixtures;
using Microsoft.EntityFrameworkCore;

namespace ItMarathon.Tests.DalTests.RepositoriesTests;

public class PropertyRepositoryTests
{
    [Theory]
    [PropertyFixture]
    public async Task GetAllPropertiesAsync_ShouldReturnAllProperties(ApplicationDbContext context)
    {
        // Arrange
        var repository = new PropertyRepository(context);
        var initialPropertiesCount = await context.Properties.CountAsync();

        // Act
        var result = await repository.GetAllPropertiesAsync(false);

        // Assert
        result.Should().NotBeNullOrEmpty();
        result.Count().Should().Be(initialPropertiesCount);
    }

    [Theory]
    [PropertyFixture]
    public async Task GetPropertyAsync_ShouldReturnPropertyById(ApplicationDbContext context)
    {
        // Arrange
        var repository = new PropertyRepository(context);
        var existingProperty = await context.Properties.FirstOrDefaultAsync();

        // Act
        var result = await repository.GetPropertyAsync(existingProperty!.Id, false);

        // Assert
        result.Should().NotBeNull();
        result?.Id.Should().Be(existingProperty.Id);
    }

    [Theory]
    [PropertyFixture]
    public async Task CreateProperty_ShouldAddNewPropertyToDatabase(ApplicationDbContext context, Property propertyToCreate)
    {
        // Arrange
        var repository = new PropertyRepository(context);
        var initialPropertiesCount = await context.Properties.CountAsync();

        // Act
        repository.CreateProperty(propertyToCreate);
        await context.SaveChangesAsync();

        // Assert
        context.Properties.Should().Contain(propertyToCreate);
        (await context.Properties.CountAsync()).Should().Be(initialPropertiesCount + 1);
    }

    [Theory]
    [PropertyFixture]
    public async Task DeleteProperty_ShouldRemovePropertyFromDatabase(ApplicationDbContext context)
    {
        // Arrange
        var repository = new PropertyRepository(context);
        var propertyToDelete = await context.Properties.FirstAsync();
        var initialPropertiesCount = await context.Properties.CountAsync();

        // Act
        repository.DeleteProperty(propertyToDelete);
        await context.SaveChangesAsync();

        // Assert
        context.Properties.Should().NotContain(propertyToDelete);
        (await context.Properties.CountAsync()).Should().Be(initialPropertiesCount - 1);
    }

    [Theory]
    [PropertyFixture]
    public async Task GetPropertyAsync_WhenPropertyDoesNotExist_ShouldReturnNull(ApplicationDbContext context)
    {
        // Arrange
        var repository = new PropertyRepository(context);
        var nonExistentPropertyId = -1L;

        // Act
        var result = await repository.GetPropertyAsync(nonExistentPropertyId, false);

        // Assert
        result.Should().BeNull();
    }

    [Theory]
    [PropertyFixture]
    public async Task GetPropertyByProposalAsync_ShouldReturnPropertiesByProposalId(ApplicationDbContext context)
    {
        // Arrange
        var repository = new PropertyRepository(context);
        var existingProperty = await context.Properties.FirstOrDefaultAsync();
        var proposalId = existingProperty?.ProposalId;

        // Act
        var result = await repository.GetPropertyByProposalAsync(proposalId!.Value, false);

        // Assert
        result.Should().NotBeNullOrEmpty();
        result.All(p => p.ProposalId == proposalId).Should().BeTrue();
    }
}