using FluentAssertions;
using ItMarathon.Dal.Context;
using ItMarathon.Dal.Entities;
using ItMarathon.Dal.Repositories;
using ItMarathon.Tests.DalTests.Fixtures;
using Microsoft.EntityFrameworkCore;

namespace ItMarathon.Tests.DalTests.RepositoriesTests;

public class PropertyValueRepositoryTests
{
    [Theory]
    [PropertyValueFixture]
    public async Task GetAllPropertyValuesAsync_ShouldReturnAllPropertyValues(ApplicationDbContext context)
    {
        // Arrange
        var repository = new PropertyValueRepository(context);
        var initialCount = await context.PropertyValues.CountAsync();

        // Act
        var result = await repository.GetAllPropertyValuesAsync(false);

        // Assert
        result.Should().NotBeNullOrEmpty();
        result.Count().Should().Be(initialCount);
    }

    [Theory]
    [PropertyValueFixture]
    public async Task GetPropertyValueAsync_ShouldReturnPropertyValueById(ApplicationDbContext context)
    {
        // Arrange
        var repository = new PropertyValueRepository(context);
        var existingValue = await context.PropertyValues.FirstOrDefaultAsync();

        // Act
        var result = await repository.GetPropertyValueAsync(existingValue!.Id, false);

        // Assert
        result.Should().NotBeNull();
        result?.Id.Should().Be(existingValue.Id);
    }

    [Theory]
    [PropertyValueFixture]
    public async Task CreatePropertyValue_ShouldAddNewPropertyValueToDatabase(ApplicationDbContext context, PropertyValue valueToCreate)
    {
        // Arrange
        var repository = new PropertyValueRepository(context);
        var initialCount = await context.PropertyValues.CountAsync();

        // Act
        repository.CreatePropertyValue(valueToCreate);
        await context.SaveChangesAsync();

        // Assert
        context.PropertyValues.Should().Contain(valueToCreate);
        (await context.PropertyValues.CountAsync()).Should().Be(initialCount + 1);
    }

    [Theory]
    [PropertyValueFixture]
    public async Task DeletePropertyValue_ShouldRemovePropertyValueFromDatabase(ApplicationDbContext context)
    {
        // Arrange
        var repository = new PropertyValueRepository(context);
        var valueToDelete = await context.PropertyValues.FirstAsync();
        var initialCount = await context.PropertyValues.CountAsync();

        // Act
        repository.DeletePropertyValue(valueToDelete);
        await context.SaveChangesAsync();

        // Assert
        context.PropertyValues.Should().NotContain(valueToDelete);
        (await context.PropertyValues.CountAsync()).Should().Be(initialCount - 1);
    }

    [Theory]
    [PropertyValueFixture]
    public async Task GetPropertyValueAsync_WhenPropertyValueDoesNotExist_ShouldReturnNull(ApplicationDbContext context)
    {
        // Arrange
        var repository = new PropertyValueRepository(context);
        var nonExistentValueId = -1L;

        // Act
        var result = await repository.GetPropertyValueAsync(nonExistentValueId, false);

        // Assert
        result.Should().BeNull();
    }
}