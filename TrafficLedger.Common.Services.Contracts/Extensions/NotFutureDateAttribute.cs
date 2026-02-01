using System.ComponentModel.DataAnnotations;

namespace TrafficLedger.Common.Services.Contracts.Extensions
{
    public class NotFutureDateAttribute : ValidationAttribute
    {
        public NotFutureDateAttribute()
        {
            ErrorMessage = "Дата не может быть в будущем.";
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value is DateTimeOffset dto)
            {
                if (dto.Date > DateTimeOffset.UtcNow.Date)
                {
                    return new ValidationResult("Дата не может быть в будущем.");
                }
            }

            return ValidationResult.Success!;
        }
    }
}