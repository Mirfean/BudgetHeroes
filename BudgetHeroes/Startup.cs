using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BudgetHeroes.Startup))]
namespace BudgetHeroes
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
