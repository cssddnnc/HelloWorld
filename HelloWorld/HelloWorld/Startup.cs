using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HelloWorld.Startup))]
namespace HelloWorld
{
    public partial class Startup
    {
        Private branch change.
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
