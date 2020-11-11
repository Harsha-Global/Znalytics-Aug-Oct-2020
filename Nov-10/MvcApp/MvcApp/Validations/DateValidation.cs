using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MvcApp.Validations
{
    /// <summary>
    /// Requirement: The date of joining should be a past date. Should not be future date.
    /// </summary>
    public class DateValidationAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            //check whether the textbox is not null
            if (value != null)
            {
                DateTime dt = Convert.ToDateTime(value);
                if (dt <= DateTime.Now)
                {
                    return ValidationResult.Success; //valid
                }
                else
                {
                    return new ValidationResult("Date of Joining can't be future date");
                }
            }
            else
            {
                return ValidationResult.Success;
            }
        }
    }
}