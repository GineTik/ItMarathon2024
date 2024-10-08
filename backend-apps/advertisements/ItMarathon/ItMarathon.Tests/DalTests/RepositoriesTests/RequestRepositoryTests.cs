using FluentAssertions;
using ItMarathon.Dal.Context;
using ItMarathon.Dal.Entities;
using ItMarathon.Dal.Repositories;
using ItMarathon.Tests.DalTests.Fixtures;
using Microsoft.EntityFrameworkCore;

namespace ItMarathon.Tests.DalTests.RepositoriesTests;

public class RequestRepositoryTests
{
    [Theory]
    [RequestFixture]
    public async Task GetAllRequestsAsync_ShouldReturnAllRequests(ApplicationDbContext context)
    {
        // Arrange
        var repository = new RequestRepository(context);
        var initialCount = await context.Requests.CountAsync();

        // Act
        var result = await repository.GetAllRequestsAsync(false);

        // Assert
        result.Should().NotBeNullOrEmpty();
        result.Count().Should().Be(initialCount);
    }

    [Theory]
    [RequestFixture]
    public async Task GetRequestAsync_ShouldReturnRequestById(ApplicationDbContext context)
    {
        // Arrange
        var repository = new RequestRepository(context);
        var existingRequest = await context.Requests.FirstOrDefaultAsync();

        // Act
        var result = await repository.GetRequestAsync(existingRequest!.Id, false);

        // Assert
        result.Should().NotBeNull();
        result?.Id.Should().Be(existingRequest.Id);
    }

    [Theory]
    [RequestFixture]
    public async Task CreateRequest_ShouldAddNewRequestToDatabase(ApplicationDbContext context, Request requestToCreate)
    {
        // Arrange
        var repository = new RequestRepository(context);
        var initialCount = await context.Requests.CountAsync();

        // Act
        repository.CreateRequest(requestToCreate);
        await context.SaveChangesAsync();

        // Assert
        context.Requests.Should().Contain(requestToCreate);
        (await context.Requests.CountAsync()).Should().Be(initialCount + 1);
    }

    [Theory]
    [RequestFixture]
    public async Task DeleteRequest_ShouldRemoveRequestFromDatabase(ApplicationDbContext context)
    {
        // Arrange
        var repository = new RequestRepository(context);
        var requestToDelte = await context.Requests.FirstAsync();
        var initialCount = await context.Requests.CountAsync();

        // Act
        repository.DeleteRequest(requestToDelte);
        await context.SaveChangesAsync();

        // Assert
        context.Requests.Should().NotContain(requestToDelte);
        (await context.Requests.CountAsync()).Should().Be(initialCount - 1);
    }

    [Theory]
    [RequestFixture]
    public async Task GetAppUserAsync_WhenUserDoesNotExist_ShouldReturnNull(ApplicationDbContext context)
    {
        // Arrange
        var repository = new RequestRepository(context);
        var nonExistentRequestId = -1L;

        // Act
        var result = await repository.GetRequestAsync(nonExistentRequestId, false);

        // Assert
        result.Should().BeNull();
    }
}