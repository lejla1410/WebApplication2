using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication2.Validate
{
    public class MyValidates :ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            

            if (value.ToString().Contains("@"))
                    
                return ValidationResult.Success;
            else
                return new ValidationResult("Email nie jest prawidłowy");
        }
    }
}