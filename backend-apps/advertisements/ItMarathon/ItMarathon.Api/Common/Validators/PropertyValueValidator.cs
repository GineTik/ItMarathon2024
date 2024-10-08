using ItMarathon.Api.Dtos.PropertyDtos;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace ItMarathon.Api.Common.Validators
{
    /// <summary>
    /// Provides validation for property values within a proposal.
    /// </summary>
    public static class PropertyValueValidator
    {
        /// <summary>
        /// Validates each property in a proposal to ensure that each has either a predefined value or a custom value, but not both.
        /// </summary>
        /// <param name="propertyDtos">The collection of properties to validate.</param>
        /// <param name="modelState">The model state dictionary where validation errors are added.</param>
        public static void ValidateCustomAndPredefinedValues(IEnumerable<CreatePropertyDto> propertyDtos, ModelStateDictionary modelState)
        {
            foreach (var property in propertyDtos)
            {
                var hasCustomValue = !string.IsNullOrEmpty(property.CustomValue);
                var hasPredefinedValue = property.PredefinedValueId > 0;

                if (hasCustomValue == hasPredefinedValue)
                {
                    modelState.AddModelError("Properties", "Each property must contain either a predefined value ID or a custom value");
                }
            }
        }
    }
}
