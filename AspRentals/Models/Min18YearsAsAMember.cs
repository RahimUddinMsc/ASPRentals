using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace AspRentals.Models
{
    public class Min18YearsAsAMember : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = (Customer)validationContext.ObjectInstance;

            if (customer.MembershipTypeId == MembershipType.Unknown || customer.MembershipTypeId == MembershipType.PayAsYouGo)
                return ValidationResult.Success;

            if (customer.DateOfBirth == null)
                return new ValidationResult("Birthdate required");

            var age = DateTime.Today.Year - customer.DateOfBirth.Value.Year;

            return (age >= 18) 
                ? ValidationResult.Success 
                : new ValidationResult("You must be over 18 to have a membership");
        }

        
    }
}