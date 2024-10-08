using FluentAssertions;
using ItMarathon.Dal.Context;
using ItMarathon.Dal.Entities;
using ItMarathon.Dal.Repositories;
using ItMarathon.Tests.DalTests.Fixtures;
using Microsoft.EntityFrameworkCore;

namespace ItMarathon.Tests.DalTests.RepositoriesTests;

public class PropertyDefinitionRepositoryTests
{
    [Theory]
    [PropertyDefinitionFixture]
    public async Task GetAllPropertyDefinitionsAsync_ShouldReturnAllDefinitions(ApplicationDbContext context)
    {
        // Arrange
        var repository = new PropertyDefinitionRepository(context);
        var initialCount = await context.PropertiesDefinition.CountAsync();

        // Act
        var result = await repository.GetAllPropertyDefinitionsAsync(false);

        // Assert
        result.Should().NotBeNullOrEmpty();
        result.Count().Should().Be(initialCount);
    }

    [Theory]
    [PropertyDefinitionFixture]
    public async Task GetPropertyDefinitionAsync_ShouldReturnDefinitionById(ApplicationDbContext context)
    {
        // Arrange
        var repository = new PropertyDefinitionRepository(context);
        var existingDefinition = await context.PropertiesDefinition.FirstOrDefaultAsync();

        // Act
        var result = await repository.GetPropertyDefinitionAsync(existingDefinition!.Id, false);

        // Assert
        result.Should().NotBeNull();
        result?.Id.Should().Be(existingDefinition.Id);
    }

    [Theory]
    [PropertyDefinitionFixture]
    public async Task CreatePropertyDefinition_ShouldAddNewDefinitionToDatabase(ApplicationDbContext context, PropertyDefinition propertyDefinition)
    {
        // Arrange
        var repository = new PropertyDefinitionRepository(context);
        var initialCount = await context.PropertiesDefinition.CountAsync();

        // Act
        repository.CreatePropertyDefinition(propertyDefinition);
        await context.SaveChangesAsync();

        // Assert
        context.PropertiesDefinition.Should().Contain(propertyDefinition);
        (await context.PropertiesDefinition.CountAsync()).Should().Be(initialCount + 1);
    }

    [Theory]
    [PropertyDefinitionFixture]
    public async Task DeletePropertyDefinition_ShouldRemoveDefinitionFromDatabase(ApplicationDbContext context)
    {
        // Arrange
        var repository = new PropertyDefinitionRepository(context);
        var propertyDefinitionToDelete = await context.PropertiesDefinition.FirstAsync();
        var initialCount = await context.PropertiesDefinition.CountAsync();

        // Act
        repository.DeletePropertyDefinition(propertyDefinitionToDelete);
        await context.SaveChangesAsync();

        // Assert
        context.PropertiesDefinition.Should().NotContain(propertyDefinitionToDelete);
        (await context.PropertiesDefinition.CountAsync()).Should().Be(initialCount - 1);
    }

    [Theory]
    [PropertyDefinitionFixture]
    public async Task GetPropertyDefinitionAsync_WhenDefinitionDoesNotExist_ShouldReturnNull(ApplicationDbContext context)
    {
        // Arrange
        var repository = new PropertyDefinitionRepository(context);
        var nonExistentDefinitionId = -1L;

        // Act
        var result = await repository.GetPropertyDefinitionAsync(nonExistentDefinitionId, false);

        // Assert
        result.Should().BeNull();
    }

    [Theory]
    [PropertyDefinitionFixture]
    public async Task GetMandatoryPropertyDefinitionsAsync_ShouldReturnAllMandatoryDefinitions(ApplicationDbContext context)
    {
        // Arrange
        var repository = new PropertyDefinitionRepository(context);

        // Act
        var result = await repository.GetMandatoryPropertyDefinitionsAsync(false);

        // Assert
        result.Should().NotBeNullOrEmpty();
        result.Should().OnlyContain(pd => pd.IsMandatory);
    }
}
