using FluentAssertions;
using ItMarathon.Dal.Context;
using ItMarathon.Dal.Entities;
using ItMarathon.Dal.Repositories;
using ItMarathon.Tests.DalTests.Fixtures;
using Microsoft.EntityFrameworkCore;

namespace ItMarathon.Tests.DalTests.RepositoriesTests;

public class AppUserRepositoryTests
{
    [Theory]
    [AppUserFixture]
    public async Task GetAllAppUsersAsync_ShouldReturnAllUsers(ApplicationDbContext context)
    {
        // Arrange
        var repository = new AppUserRepository(context);
        var initialCount = await context.AppUsers.CountAsync();

        // Act
        var result = await repository.GetAllAppUsersAsync(false);

        // Assert
        result.Should().NotBeNullOrEmpty();
        result.Count().Should().Be(initialCount);
    }

    [Theory]
    [AppUserFixture]
    public async Task GetAppUserAsync_ShouldReturnUserById(ApplicationDbContext context)
    {
        // Arrange
        var repository = new AppUserRepository(context);
        var existingAppUser = await context.AppUsers.FirstOrDefaultAsync();

        // Act
        var result = await repository.GetAppUserAsync(existingAppUser!.Id, false);

        // Assert
        result.Should().NotBeNull();
        result?.Id.Should().Be(existingAppUser.Id);
    }

    [Theory]
    [AppUserFixture]
    public async Task CreateAppUser_ShouldAddNewUserToDatabase(ApplicationDbContext context, AppUser userToCreate)
    {
        // Arrange
        var repository = new AppUserRepository(context);
        var initialCount = await context.AppUsers.CountAsync();

        // Act
        repository.CreateAppUser(userToCreate);
        await context.SaveChangesAsync();

        // Assert
        context.AppUsers.Should().Contain(userToCreate);
        (await context.AppUsers.CountAsync()).Should().Be(initialCount + 1);
    }

    [Theory]
    [AppUserFixture]
    public async Task DeleteAppUser_ShouldRemoveUserFromDatabase(ApplicationDbContext context)
    {
        // Arrange
        var repository = new AppUserRepository(context);
        var appUserToDelte = await context.AppUsers.FirstAsync();
        var initialCount = await context.AppUsers.CountAsync();

        // Act
        repository.DeleteAppUser(appUserToDelte);
        await context.SaveChangesAsync();

        // Assert
        context.AppUsers.Should().NotContain(appUserToDelte);
        (await context.AppUsers.CountAsync()).Should().Be(initialCount - 1);
    }

    [Theory]
    [AppUserFixture]
    public async Task GetAppUserAsync_WhenUserDoesNotExist_ShouldReturnNull(ApplicationDbContext context)
    {
        // Arrange
        var repository = new AppUserRepository(context);
        var nonExistentUserId = -1L;

        // Act
        var result = await repository.GetAppUserAsync(nonExistentUserId, false);

        // Assert
        result.Should().BeNull();
    }

    [Theory]
    [AppUserFixture]
    public async Task GetAppUserByTokenAsync_WhenTokenExists_ShouldReturnUser(ApplicationDbContext context)
    {
        // Arrange
        var repository = new AppUserRepository(context);
        var userWithValidToken = await context.AppUsers
                                             .Include(u => u.AccessTokens)
                                             .FirstOrDefaultAsync(u => u.AccessTokens!.Any());
        var validToken = userWithValidToken!.AccessTokens!.First().Token;

        // Act
        var result = await repository.GetAppUserByTokenAsync(validToken, false);

        // Assert
        result.Should().NotBeNull();
        result?.Id.Should().Be(userWithValidToken.Id);
    }

    [Theory]
    [AppUserFixture]
    public async Task GetAppUserByTokenAsync_WhenTokenDoesNotExist_ShouldReturnNull(ApplicationDbContext context)
    {
        // Arrange
        var repository = new AppUserRepository(context);
        var nonExistentToken = "non-existent-token";

        // Act
        var result = await repository.GetAppUserByTokenAsync(nonExistentToken, false);

        // Assert
        result.Should().BeNull();
    }
}