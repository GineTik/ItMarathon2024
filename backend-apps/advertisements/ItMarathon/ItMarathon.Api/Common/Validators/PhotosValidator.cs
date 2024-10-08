using ItMarathon.Api.Dtos.PhotoDtos;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace ItMarathon.Api.Common.Validators;

/// <summary>
/// Provides validation for phonos within a proposal.
/// </summary>
public static class PhotosValidator
{
    /// <summary>
    /// Validates a collection of photo DTOs and adds errors to the model state if validation fails on creating.
    /// </summary>
    /// <param name="photos">The collection of photos to validate. Each photo should be represented by a <see cref="CreateProposalPhotoDto"/> object.</param>
    /// <param name="modelState">The <see cref="ModelStateDictionary"/> to which validation errors are added.</param>
    public static void ValidatePhotosCreating(IEnumerable<CreateProposalPhotoDto>? photos, ModelStateDictionary modelState)
    {
        ValidatePhotos(photos, modelState, p => string.IsNullOrWhiteSpace(p.Image));
    }

    /// <summary>
    /// Validates a collection of photo DTOs and adds errors to the model state if validation fails on updating.
    /// </summary>
    /// <param name="photos">The collection of photos to validate. Each photo should be represented by an <see cref="ProposalPhotoDto"/> object.</param>
    /// <param name="modelState">The <see cref="ModelStateDictionary"/> to which validation errors are added.</param>
    public static void ValidatePhotosUpdating(IEnumerable<ProposalPhotoDto>? photos, ModelStateDictionary modelState)
    {
        ValidatePhotos(photos, modelState, p => p.Image is not null && string.IsNullOrWhiteSpace(p.Image));
    }

    private static void ValidatePhotos<T>(IEnumerable<T>? photos, ModelStateDictionary modelState, Func<T, bool> imageValidationFunc)
    {
        if (photos is not null)
        {
            if (photos.Count() > 4)
            {
                modelState.AddModelError("Photos", "Cannot add more than 4 photos");
            }

            if (photos.Any(imageValidationFunc))
            {
                modelState.AddModelError("Photos", "Cannot add an empty photo");
            }
        }
    }
}
