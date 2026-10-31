using System.ComponentModel.DataAnnotations;

namespace SchoolApp.Validation
{
    // Our own rule for checking dates.
    public class NotFutureDateAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            // Reject dates later than today.
            if (value is DateTime date && date.Date > DateTime.Today)
            {
                return new ValidationResult(ErrorMessage ?? "The date can't be in the future.");
            }

            // Allow today's date, past dates, and empty dates.
            return ValidationResult.Success;
        }
    }
}
