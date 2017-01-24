using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BudgetHeroes.Models
{
    public class Team
    {
        public Team()
        {
            Members = new List<Hero>();
        }
        public int TeamId { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Power { get; set; }

        public virtual ICollection<Hero> Members { get; set; }
    }
}