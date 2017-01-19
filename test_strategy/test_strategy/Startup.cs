using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(test_strategy.Startup))]
namespace test_strategy
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
