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
		Master change.

            ConfigureAuth(app);
        }

        Master change 1.
        Master change 2.

    }
}
