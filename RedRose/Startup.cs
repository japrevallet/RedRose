using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RedRose.Startup))]
namespace RedRose
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
