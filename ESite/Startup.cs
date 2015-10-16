using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ESite.Startup))]
namespace ESite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
