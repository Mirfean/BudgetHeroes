namespace BudgetHeroes.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using BudgetHeroes.Models;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;

    internal sealed class Configuration : DbMigrationsConfiguration<BudgetHeroes.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        bool AddUserAndRole(BudgetHeroes.Models.ApplicationDbContext context)
        {
            IdentityResult ir;
            var rm = new RoleManager<IdentityRole>
                (new RoleStore<IdentityRole>(context));
            ir = rm.Create(new IdentityRole("canEdit"));
            var um = new UserManager<ApplicationUser>(
                new UserStore<ApplicationUser>(context));
            var user = new ApplicationUser()
            {
                UserName = "Czoko@BHeroes.com",
            };
            ir = um.Create(user, "P_assw0rd1");
            if (ir.Succeeded == false)
                return ir.Succeeded;
            ir = um.AddToRole(user.Id, "canEdit");
            return ir.Succeeded;
        }

        protected override void Seed(BudgetHeroes.Models.ApplicationDbContext context)
        {
            AddUserAndRole(context);
            context.Teams.AddOrUpdate(p => p.Name,
            new Team
            {
            Name = "Hamsters of Satan",
            City = "Wejherowo",
            Power = "Losing with old women in market"
            },
            new Team
            {
            Name = "Old Butter",
            City = "Bobrowiczki",
            Power = "Won vs Najman"
            }
            
            );
            context.Heroes.AddOrUpdate(p => p.Name,
            new Hero
            {
            Name = "Marcel Spoonhands",
            Character = "Evil",
            Power = "His fingers are spoons",
            TeamId = 2
            },
            new Hero
            {
            Name = "Jane Hammerbutt",
            Character = "Good",
            Power = "She smash enemies with her butt",
            TeamId = 1
            },
            new Hero
            {
            Name = "Bob",
            Character = "Undecided",
            Power = "Spits snails",
            TeamId = 2
            });

        }
    }
}
