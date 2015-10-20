using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EBus.Site.Startup))]
namespace EBus.Site
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
