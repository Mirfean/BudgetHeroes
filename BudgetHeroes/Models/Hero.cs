using BudgetHeroes.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BudgetHeroes.Models
{
    public class Hero
    {
        
        public int HeroId { get; set; }
        [Required]
        public string Name { get; set; }

        [CharacterValidator]
        public string Character { get; set; }
        [Required]
        public string Power { get; set; }

        public int TeamId { get; set; }

        public virtual Team Team { get; set; }
    }
}