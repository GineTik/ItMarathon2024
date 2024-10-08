using AutoFixture.Xunit2;
using AutoMapper;
using ItMarathon.Api.Dtos.PropertyDefinitionDtos;
using ItMarathon.Api.Services;
using ItMarathon.Dal.Common.Contracts;
using ItMarathon.Dal.Entities;
using ItMarathon.Tests.ApiTests.Fixtures;
using Moq;

namespace ItMarathon.Tests.ApiTests.ServicesTests;

public class PropertyDefinitionServiceTests
{
    [Theory]
    [AutoServiceData]
    public async Task GetPropertyDefinitionsAsync_ShouldReturnPropertyDefinitions(
        [Frozen] Mock<IPropertyDefinitionRepository> propertyDefinitionRepositoryMock,
        PropertyDefinitionService propertyDefinitionService)
    {
        // Act
        await propertyDefinitionService.GetPropertyDefinitionsAsync();

        // Assert
        propertyDefinitionRepositoryMock.Verify(r => r.GetAllPropertyDefinitionsAsync(false), Times.Once);
    }

    [Theory]
    [AutoServiceData]
    public async Task GetPropertyDefinitionByIdAsync_ShouldReturnPropertyDefinition(
        [Frozen] Mock<IPropertyDefinitionRepository> propertyDefinitionRepositoryMock,
        PropertyDefinitionService propertyDefinitionService,
        long propertyDefinitionId)
    {
        // Act
        await propertyDefinitionService.GetPropertyDefinitionByIdAsync(propertyDefinitionId);

        // Assert
        propertyDefinitionRepositoryMock.Verify(r => r.GetPropertyDefinitionAsync(propertyDefinitionId, false), Times.Once);
    }

    [Theory]
    [AutoServiceData]
    public async Task CreatePropertyDefinitionAsync_ShouldCreatePropertyDefinition(
        [Frozen] Mock<IPropertyDefinitionRepository> propertyDefinitionRepositoryMock,
        [Frozen] Mock<IUnitOfWork> unitOfWorkMock,
        PropertyDefinitionService propertyDefinitionService,
        CreatePropertyDefinitionDto createPropertyDefinitionDto)
    {
        // Act
        await propertyDefinitionService.CreatePropertyDefinitionAsync(createPropertyDefinitionDto);

        // Assert
        propertyDefinitionRepositoryMock.Verify(r => r.CreatePropertyDefinition(It.IsAny<PropertyDefinition>()), Times.Once);
        unitOfWorkMock.Verify(u => u.SaveChangesAsync(It.IsAny<CancellationToken>()), Times.Once);
    }

    [Theory]
    [AutoServiceData]
    public async Task DeletePropertyDefinitionAsync_ShouldDeletePropertyDefinition(
        [Frozen] Mock<IPropertyDefinitionRepository> propertyDefinitionRepositoryMock,
        [Frozen] Mock<IUnitOfWork> unitOfWorkMock,
        PropertyDefinitionService propertyDefinitionService,
        long propertyDefinitionId)
    {
        // Arrange
        propertyDefinitionRepositoryMock.Setup(r => r.GetPropertyDefinitionAsync(propertyDefinitionId, false))
            .ReturnsAsync(new PropertyDefinition());

        // Act
        await propertyDefinitionService.DeletePropertyDefinitionAsync(propertyDefinitionId);

        // Assert
        propertyDefinitionRepositoryMock.Verify(r => r.GetPropertyDefinitionAsync(propertyDefinitionId, false), Times.Once);
        propertyDefinitionRepositoryMock.Verify(r => r.DeletePropertyDefinition(It.IsAny<PropertyDefinition>()), Times.Once);
        unitOfWorkMock.Verify(u => u.SaveChangesAsync(It.IsAny<CancellationToken>()), Times.Once);
    }

    [Fact]
    public async Task UpdatePropertyDefinitionAsync_ShouldUpdatePropertyDefinition()
    {
        // Arrange
        var propertyDefinitionRepositoryMock = new Mock<IPropertyDefinitionRepository>();
        var unitOfWorkMock = new Mock<IUnitOfWork>();
        var mapperMock = new Mock<IMapper>();
        var propertyDefinitionId = 1L;

        var propertyDefinition = new PropertyDefinition();
        var updatePropertyDefinitionDto = new UpdatePropertyDefinitionDto();

        unitOfWorkMock.Setup(u => u.PropertyDefinitions).Returns(propertyDefinitionRepositoryMock.Object);
        propertyDefinitionRepositoryMock.Setup(r => r.GetPropertyDefinitionAsync(propertyDefinitionId, true))
            .ReturnsAsync(propertyDefinition);

        var propertyDefinitionService = new PropertyDefinitionService(unitOfWorkMock.Object, mapperMock.Object);

        // Act
        await propertyDefinitionService.UpdatePropertyDefinitionAsync(propertyDefinitionId, updatePropertyDefinitionDto);

        // Assert
        propertyDefinitionRepositoryMock.Verify(r => r.GetPropertyDefinitionAsync(propertyDefinitionId, true), Times.Once);
        propertyDefinitionRepositoryMock.Verify(r => r.Update(It.IsAny<PropertyDefinition>()), Times.Once);
        unitOfWorkMock.Verify(u => u.SaveChangesAsync(It.IsAny<CancellationToken>()), Times.Once);
    }
}