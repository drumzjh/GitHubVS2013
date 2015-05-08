using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GitSetup.Startup))]
namespace GitSetup
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
