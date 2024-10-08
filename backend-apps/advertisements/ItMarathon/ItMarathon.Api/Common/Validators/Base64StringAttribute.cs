using System.Buffers.Text;
using System.ComponentModel.DataAnnotations;

namespace ItMarathon.Api.Common.Validators;

/// <summary>
/// Validation attribute to check if a string is a valid Base64-encoded value.
/// </summary>
[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter, AllowMultiple = false)]
public class Base64StringAttribute(bool nullable) : ValidationAttribute
{
    /// <inheritdoc/>
    protected override ValidationResult IsValid(object? value, ValidationContext validationContext)
    {
        if (value is null)
        {
            return nullable ? ValidationResult.Success! : new ValidationResult("The field image must not be null.");
        }

        if (value is string base64String)
        {
            if (base64String.StartsWith("data:image"))
            {
                int commaIndex = base64String.IndexOf(',');

                if (commaIndex == -1 || commaIndex + 1 == base64String.Length)
                {
                    return new ValidationResult("The field is not a valid Base64 string.");
                }

                var base64Data = base64String.Split(',')[1];
                base64String = base64Data;
            }

            if (Base64.IsValid(base64String))
            {
                return ValidationResult.Success!;
            }
        }

        return new ValidationResult("The field is not a valid Base64 string.");
    }
}