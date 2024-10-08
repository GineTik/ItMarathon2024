using AutoFixture.Xunit2;
using AutoMapper;
using FluentAssertions;
using ItMarathon.Api.Common.Contracts;
using ItMarathon.Api.Dtos.PropertyDtos;
using ItMarathon.Api.Dtos.ProposalDtos;
using ItMarathon.Api.Services;
using ItMarathon.Dal.Common.Contracts;
using ItMarathon.Dal.Entities;
using ItMarathon.Tests.ApiTests.Fixtures;
using Microsoft.AspNetCore.Http;
using Moq;

namespace ItMarathon.Tests.ApiTests.ServicesTests;

public class ProposalServiceTests
{
    [Theory]
    [AutoServiceData]
    public async Task GetAllProposalsAsync_ShouldReturnProposals(
        [Frozen] Mock<IProposalRepository> proposalRepositoryMock,
        ProposalService proposalService)
    {
        // Arrange
        var httpContext = new DefaultHttpContext();
        var request = httpContext.Request;

        // Act
        await proposalService.GetAllProposalsAsync();

        // Assert
        proposalRepositoryMock.Verify(r => r.GetProposalsAsync(false), Times.Once);
    }

    [Theory]
    [AutoServiceData]
    public async Task GetProposalByIdAsync_ShouldReturnProposal(
        [Frozen] Mock<IProposalRepository> proposalRepositoryMock,
        ProposalService proposalService,
        long proposalId)
    {
        // Act
        await proposalService.GetProposalByIdAsync(proposalId);

        // Assert
        proposalRepositoryMock.Verify(r => r.GetProposalAsync(proposalId, false), Times.Once);
    }

    [Theory]
    [AutoServiceData]
    public async Task DeleteProposalAsync_ShouldDeleteProposal(
        [Frozen] Mock<IProposalRepository> proposalRepositoryMock,
        [Frozen] Mock<IUnitOfWork> unitOfWorkMock,
        ProposalService proposalService,
        long proposalId)
    {
        // Act
        await proposalService.DeleteProposalAsync(proposalId);

        // Assert
        proposalRepositoryMock.Verify(r => r.GetProposalAsync(proposalId, true), Times.Once);
        proposalRepositoryMock.Verify(r => r.DeleteProposal(It.IsAny<Proposal>()), Times.Once);
        unitOfWorkMock.Verify(u => u.SaveChangesAsync(It.IsAny<CancellationToken>()), Times.Once);
    }

    [Theory]
    [AutoServiceData]
    public async Task DeleteProposalAsync_WhenProposalNotFound_ShouldReturnNull(
        [Frozen] Mock<IProposalRepository> proposalRepositoryMock,
        [Frozen] Mock<IUnitOfWork> unitOfWorkMock,
        ProposalService proposalService,
        long proposalId)
    {
        // Arrange
        proposalRepositoryMock.Setup(r => r.GetProposalAsync(proposalId, true)).ReturnsAsync((Proposal?)null);
        unitOfWorkMock.Setup(u => u.Proposals).Returns(proposalRepositoryMock.Object);

        // Act
        var result = await proposalService.DeleteProposalAsync(proposalId);

        // Assert
        result.Should().BeNull();
    }

    [Fact]
    public async Task CreateProposalAsync_ShouldCreateProposal()
    {
        // Arrange
        var proposalRepositoryMock = new Mock<IProposalRepository>();
        var unitOfWorkMock = new Mock<IUnitOfWork>();
        var mapperMock = new Mock<IMapper>();
        var blobServiceMock = new Mock<IAzureBlobService>();
        var proposalService = new ProposalService(unitOfWorkMock.Object, mapperMock.Object, blobServiceMock.Object);
        CreateProposalDto createProposalDto = new();

        var proposalId = 1L;
        var createdProposal = new Proposal { Id = proposalId };
        var createdProposalDto = new ProposalDto { Id = proposalId };

        mapperMock.Setup(m => m.Map<Proposal>(createProposalDto)).Returns(createdProposal);
        mapperMock.Setup(m => m.Map<ProposalDto>(createdProposal)).Returns(createdProposalDto);
        proposalRepositoryMock.Setup(r => r.GetProposalAsync(createdProposal.Id, false)).ReturnsAsync(createdProposal);
        unitOfWorkMock.Setup(u => u.Proposals).Returns(proposalRepositoryMock.Object);

        // Act
        var result = await proposalService.CreateProposalAsync(createProposalDto, proposalId);

        // Assert
        proposalRepositoryMock.Verify(r => r.CreateProposal(It.IsAny<Proposal>()), Times.Once);
        unitOfWorkMock.Verify(u => u.SaveChangesAsync(It.IsAny<CancellationToken>()), Times.Once);
        result.Should().BeEquivalentTo(createdProposalDto);
    }

    [Fact]
    public async Task UpdateProposalAsync_ShouldUpdateProposal()
    {
        // Arrange
        var proposalRepositoryMock = new Mock<IProposalRepository>();
        var unitOfWorkMock = new Mock<IUnitOfWork>();
        var mapperMock = new Mock<IMapper>();
        var blobServiceMock = new Mock<IAzureBlobService>();
        var proposalService = new ProposalService(unitOfWorkMock.Object, mapperMock.Object, blobServiceMock.Object);

        var proposalId = 1L;
        UpdateProposalDto updateProposalDto = new();
        Proposal existingProposal = new()
        {
            Id = proposalId,
            Photos = new ProposalPhoto[]
            {
                new() { Id = 1, Url = "existing-photo-url" }
            },
            Properties = new Property[]
            {
                new() { Id = 1, CustomValue = "Existing Property" }
            }
        };
        var updatedProposal = new Proposal { Id = proposalId };
        var updatedProposalDto = new ProposalDto { Id = proposalId };
        var newProperty = new Property { CustomValue = "New Property" };

        proposalRepositoryMock.Setup(r => r.GetProposalAsync(proposalId, true)).ReturnsAsync(existingProposal);
        proposalRepositoryMock.Setup(r => r.GetProposalAsync(proposalId, false)).ReturnsAsync(updatedProposal);
        mapperMock.Setup(m => m.Map<Property>(It.IsAny<UpdatePropertyDto>())).Returns(newProperty);
        mapperMock.Setup(m => m.Map<ProposalDto>(updatedProposal)).Returns(updatedProposalDto);
        unitOfWorkMock.Setup(u => u.Proposals).Returns(proposalRepositoryMock.Object);
        unitOfWorkMock.Setup(u => u.Properties).Returns(Mock.Of<IPropertyRepository>());
        unitOfWorkMock.Setup(u => u.ProposalPhotos).Returns(Mock.Of<IProposalPhotoRepository>());

        // Act
        await proposalService.UpdateProposalAsync(proposalId, updateProposalDto);

        // Assert
        proposalRepositoryMock.Verify(r => r.GetProposalAsync(proposalId, true), Times.Once);
        proposalRepositoryMock.Verify(r => r.Update(It.IsAny<Proposal>()), Times.Once);
        unitOfWorkMock.Verify(u => u.SaveChangesAsync(It.IsAny<CancellationToken>()), Times.Once);
    }
}