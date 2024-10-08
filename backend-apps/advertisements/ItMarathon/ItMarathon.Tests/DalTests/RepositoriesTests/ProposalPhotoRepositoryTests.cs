using FluentAssertions;
using ItMarathon.Dal.Context;
using ItMarathon.Dal.Entities;
using ItMarathon.Dal.Repositories;
using ItMarathon.Tests.DalTests.Fixtures;
using Microsoft.EntityFrameworkCore;

namespace ItMarathon.Tests.DalTests.RepositoriesTests;

public class ProposalPhotoRepositoryTests
{
    [Theory]
    [ProposalPhotoFixture]
    public async Task GetProposalPhotoAsync_ShouldReturnPhotoById(ApplicationDbContext context)
    {
        // Arrange
        var repository = new ProposalPhotoRepository(context);
        var existingPhoto = await context.ProposalsPhoto.FirstOrDefaultAsync();

        // Act
        var result = await repository.GetProposalPhotoAsync(existingPhoto!.Id, false);

        // Assert
        result.Should().NotBeNull();
        result?.Id.Should().Be(existingPhoto.Id);
    }

    [Theory]
    [ProposalPhotoFixture]
    public async Task CreateProposalPhoto_ShouldAddNewPhotoToDatabase(ApplicationDbContext context, ProposalPhoto photoToCreate)
    {
        // Arrange
        var repository = new ProposalPhotoRepository(context);
        var initialCount = await context.ProposalsPhoto.CountAsync();

        // Act
        repository.CreateProposalPhoto(photoToCreate);
        await context.SaveChangesAsync();

        // Assert
        context.ProposalsPhoto.Should().Contain(photoToCreate);
        (await context.ProposalsPhoto.CountAsync()).Should().Be(initialCount + 1);
    }

    [Theory]
    [ProposalPhotoFixture]
    public async Task DeleteProposalPhoto_ShouldRemovePhotoFromDatabase(ApplicationDbContext context)
    {
        // Arrange
        var repository = new ProposalPhotoRepository(context);
        var photoToDelete = await context.ProposalsPhoto.FirstAsync();
        var initialCount = await context.ProposalsPhoto.CountAsync();

        // Act
        repository.DeleteProposalPhoto(photoToDelete);
        await context.SaveChangesAsync();

        // Assert
        context.ProposalsPhoto.Should().NotContain(photoToDelete);
        (await context.ProposalsPhoto.CountAsync()).Should().Be(initialCount - 1);
    }

    [Theory]
    [ProposalPhotoFixture]
    public async Task GetProposalPhotoAsync_WhenPhotoDoesNotExist_ShouldReturnNull(ApplicationDbContext context)
    {
        // Arrange
        var repository = new ProposalPhotoRepository(context);
        var nonExistentPhotoId = -1L;

        // Act
        var result = await repository.GetProposalPhotoAsync(nonExistentPhotoId, false);

        // Assert
        result.Should().BeNull();
    }
}