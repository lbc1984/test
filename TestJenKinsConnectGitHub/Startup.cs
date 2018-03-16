using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestJenKinsConnectGitHub.Startup))]
namespace TestJenKinsConnectGitHub
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
