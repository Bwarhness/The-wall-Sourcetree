using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(theWall.Startup))]
namespace theWall
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
