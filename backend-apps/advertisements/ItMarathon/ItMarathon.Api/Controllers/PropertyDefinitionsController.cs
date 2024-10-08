using ItMarathon.Api.Common;
using ItMarathon.Api.Common.Contracts;
using ItMarathon.Api.Dtos.PropertyDefinitionDtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

namespace ItMarathon.Api.Controllers;

/// <summary>
/// Controller for PropertyDefinitions operations.
/// </summary>
[Route("api/property-definitions")]
[ApiController]
[Produces(MediaTypeNames.Application.Json)]
public class PropertyDefinitionsController(IPropertyDefinitionService propertyDefinitionService) : ControllerBase
{
    /// <summary>
    /// Get all property definitions.
    /// </summary>
    /// <returns>A list of property definitions.</returns>
    /// <response code="200">Returns a list of all property definitions.</response>
    [AllowAnonymous]
    [HttpGet]
    public async Task<ActionResult<IEnumerable<PropertyDefinitionDto>>> GetPropertyDefinitions()
    {
        var propertyDefinitions = await propertyDefinitionService
            .GetPropertyDefinitionsAsync();

        return Ok(propertyDefinitions);
    }

    /// <summary>
    /// Get a specific property definition by ID.
    /// </summary>
    /// <param name="id">The ID of the property definition to retrieve.</param>
    /// <returns>The property definition with the specified ID.</returns>
    /// <response code="200">Returns the property definition with the specified ID.</response>
    /// <response code="404">If the property definition is not found.</response>
    [AllowAnonymous]
    [HttpGet("{id}")]
    public async Task<ActionResult<PropertyDefinitionDto>> GetPropertyDefinition(long id)
    {
        var propertyDefinition = await propertyDefinitionService
            .GetPropertyDefinitionByIdAsync(id);

        return propertyDefinition is null ? NotFound() : Ok(propertyDefinition);
    }

    /// <summary>
    /// Create a new property definition.
    /// </summary>
    /// <param name="propertyDefinition">The property definition to create.</param>
    /// <returns>The created property definition.</returns>
    /// <response code="201">The property definition was created successfully.</response>
    /// <response code="400">If the request is invalid.</response>
    /// <response code="401">Unauthorized user cannot create a property definition.</response>
    /// <response code="403">Only user with SuperUser permission
    /// can create property definition.</response>
    [Authorize(Policy = Consts.Authorization.SuperUserPolicy)]
    [HttpPost]
    public async Task<ActionResult<PropertyDefinitionDto>> CreatePropertyDefinition(CreatePropertyDefinitionDto propertyDefinition)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var newPropertyDefinition = await propertyDefinitionService
            .CreatePropertyDefinitionAsync(propertyDefinition);

        return Created(nameof(GetPropertyDefinition), newPropertyDefinition);
    }

    /// <summary>
    /// Update an existing property definition.
    /// </summary>
    /// <param name="id">The ID of the property definition to update.</param>
    /// <param name="propertyDefinition">The updated property definition.</param>
    /// <returns>The updated property definition if the update was successful.</returns>
    /// <response code="200">The property definition was updated successfully and the updated entity is returned.</response>
    /// <response code="400">If the ID in the request does not match the ID of the property definition.</response>
    /// <response code="403">Only user with SuperUser permission
    /// can update property definition.</response>
    /// <response code="401">Unauthorized user cannot update a property definition.</response>
    /// <response code="404">If the property definition is not found.</response>
    [Authorize(Policy = Consts.Authorization.SuperUserPolicy)]
    [HttpPut("{id}")]
    public async Task<ActionResult<PropertyDefinitionDto>> UpdatePropertyDefinition(long id, UpdatePropertyDefinitionDto propertyDefinition)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var updatedPropertyDefinition = await propertyDefinitionService
            .UpdatePropertyDefinitionAsync(id, propertyDefinition);

        return updatedPropertyDefinition is null ? NotFound() : Ok(updatedPropertyDefinition);
    }

    /// <summary>
    /// Delete a property definition by ID.
    /// </summary>
    /// <param name="id">The ID of the property definition to delete.</param>
    /// <returns>No content if the deletion was successful.</returns>
    /// <response code="204">The property definition was deleted successfully.</response>
    /// <response code="403">Only user with SuperUser permission
    /// can delete property definition.</response>
    /// <response code="401">Unauthorized user cannot delete a property definition.</response>
    /// <response code="404">If the property definition is not found.</response>
    [Authorize(Policy = Consts.Authorization.SuperUserPolicy)]
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeletePropertyDefinition(long id)
    {
        var propertyDefinition = await propertyDefinitionService
            .DeletePropertyDefinitionAsync(id);

        return propertyDefinition is null ? NotFound(propertyDefinition) : NoContent();
    }
}
