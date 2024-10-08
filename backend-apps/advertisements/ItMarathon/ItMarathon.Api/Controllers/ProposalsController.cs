using AutoMapper;
using ItMarathon.Api.Common.Contracts;
using ItMarathon.Api.Common.Validators;
using ItMarathon.Api.Dtos.ProposalDtos;
using ItMarathon.Api.Utilities;
using ItMarathon.Dal.Common;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;
using ItMarathon.Dal.Entities;
using Microsoft.AspNetCore.OData.Query;

namespace ItMarathon.Api.Controllers;

/// <summary>
/// Controller with operations related to proposals.
/// </summary>
[Route("api/proposals")]
[ApiController]
[Produces(MediaTypeNames.Application.Json)]
public class ProposalsController(IProposalService proposalService, IMapper mapper) : ControllerBase
{
    /// <summary>
    /// Retrieves all proposals.
    /// </summary>
    /// <returns>All Proposals.</returns>
    /// <response code="200">Returns all Proposals.</response>
    [AllowAnonymous]
    [HttpGet]
    [EnableQuery]
    public async Task<IQueryable<ProposalDto>> GetAllProposals()
    {
        return await proposalService.GetAllProposalsAsync();
    }

    /// <summary>
    /// Get a specific proposal by ID.
    /// </summary>
    /// <param name="id">The ID of the proposal to retrieve.</param>
    /// <returns>The proposal with the specified ID.</returns>
    /// <response code="200">Returns the proposal with the specified ID.</response>
    /// <response code="404">If the proposal is not found.</response>
    [AllowAnonymous]
    [HttpGet("{id}")]
    public async Task<ActionResult<ProposalDto>> GetProposal(long id)
    {
        var proposal = await proposalService.GetProposalByIdAsync(id);

        return proposal is null ? NotFound() : Ok(proposal);
    }

    /// <summary>
    /// Creates a new proposal.
    /// </summary>
    /// <param name="proposalDto">The proposal data transfer object containing
    /// the details of the proposal to create.</param>
    /// <returns>The created proposal.</returns>
    /// <response code="201">Returns the newly created proposal.</response>
    /// <response code="400">If the proposal dto contains invalid data and fails to validate; 
    /// returns the validation errors.</response>
    /// <response code="401">Unauthorized user cannot create a new proposal.</response>
    [HttpPost]
    public async Task<ActionResult<ProposalDto>> CreateProposal(ProposalDto proposalDto)
    {
        PropertyValueValidator.
           ValidateCustomAndPredefinedValues(mapper.Map<CreateProposalDto>(proposalDto).Properties!, ModelState);

        PhotosValidator
            .ValidatePhotosCreating(mapper.Map<CreateProposalDto>(proposalDto).Photos, ModelState);

        var propertyDefinitionIds = new HashSet<long>(mapper.Map<CreateProposalDto>(proposalDto).Properties?.Select(p => p.PropertyDefinitionId) ?? Array.Empty<long>());
        await proposalService.ValidateMandatoryPropertyDefinitions(propertyDefinitionIds, ModelState);
        await proposalService.ValidatePropertiesAsync(mapper.Map<CreateProposalDto>(proposalDto).Properties!, ModelState);

        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var newProposal = await proposalService
            .CreateProposalAsync(mapper.Map<CreateProposalDto>(proposalDto), AuthUtility.GetCurrentUserId(HttpContext));

        return Created(nameof(GetProposal), newProposal);
    }

    /// <summary>
    /// Updates an existing proposal.
    /// </summary>
    /// <param name="id">The ID of the proposal to update.</param>
    /// <param name="proposalDto">The proposal data transfer object containing the updated details.</param>
    /// <returns>The updated proposal.</returns>
    /// <response code="200">Returns the updated proposal.</response>
    /// <response code="400">If the proposal dto contains invalid data and fails to validate; 
    /// returns the validation errors.</response>
    /// <response code="401">Unauthorized user cannot update a proposal.</response>
    /// <response code="403">If user does not have permission to update this proposal.</response>
    /// <response code="404">If the proposal is not found.</response>
    [HttpPut]
    public async Task<ActionResult<ProposalDto>> UpdateProposal(long id, ProposalDto proposalDto)
    {
        var currentUserId = AuthUtility.GetCurrentUserId(HttpContext);
        var proposal = await proposalService.GetProposalByIdAsync(id);

        if (proposal is null)
        {
            return NotFound();
        }

        if (currentUserId != proposal.AppUser!.Id)
        {
            return Forbid();
        }

        PropertyValueValidator
            .ValidateCustomAndPredefinedValues(mapper.Map<UpdateProposalDto>(proposalDto).Properties!, ModelState);

        PhotosValidator
            .ValidatePhotosUpdating(mapper.Map<UpdateProposalDto>(proposalDto).Photos, ModelState);

        var propertyDefinitionIds = new HashSet<long>(mapper.Map<UpdateProposalDto>(proposalDto).Properties?
            .Select(p => p.PropertyDefinitionId) ?? Array.Empty<long>());
        await proposalService.ValidateMandatoryPropertyDefinitions(propertyDefinitionIds, ModelState);
         await proposalService.ValidatePropertiesAsync(mapper.Map<UpdateProposalDto>(proposalDto).Properties!, ModelState);

        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var updatedProposal = await proposalService.UpdateProposalAsync(id, mapper.Map<UpdateProposalDto>(proposalDto));

        return updatedProposal is null ? NotFound() : Ok(updatedProposal);
    }

    /// <summary>
    /// Deletes a proposal by its ID.
    /// </summary>
    /// <param name="id">The ID of the proposal to delete.</param>
    /// <returns>An IActionResult indicating the result of the operation.</returns>
    /// <response code="204">Indicates that the proposal was successfully deleted.</response>
    /// <response code="401">Unauthorized user cannot delete a proposal.</response>
    /// <response code="403">If user does not have permission to delete this proposal.</response>
    /// <response code="404">If the proposal is not found.</response>
    [HttpDelete]
    public async Task<IActionResult> DeleteProposal(long id)
    {
        var currentUserId = AuthUtility.GetCurrentUserId(HttpContext);
        var deletedProposal = await proposalService.GetProposalByIdAsync(id);

        if (deletedProposal is null)
        {
            return NotFound();
        }

        if (currentUserId != deletedProposal.AppUser!.Id)
        {
            return Forbid();
        }

        var proposal = await proposalService.DeleteProposalAsync(id);

        return proposal is null ? NotFound(proposal) : NoContent();
    }
}
