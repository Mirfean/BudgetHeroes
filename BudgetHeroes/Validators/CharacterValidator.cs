using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace BudgetHeroes.Validators
{
    public class CharacterValidator : ValidationAttribute
    {
        protected override ValidationResult IsValid(object x, ValidationContext validationContext)
        {
            if(x != null)
            {
                string charac = x.ToString();
              // Grrr...nie bangla  if (Regex.IsMatch(charac, @"[Evil]|[Good]|[Undecided]|[Potato]", RegexOptions.IgnoreCase))
                if (charac.Contains("Evil") || charac.Contains("Good") || charac.Contains("Undecided") || charac.Contains("Potato"))
                {
                    return ValidationResult.Success;
                }
                else
                {
                    return new ValidationResult("Dammit! You failed with that?!");
                }
            }
            else
            {
                return new ValidationResult("" + validationContext.DisplayName + "is required");
            }
        }

    }
}