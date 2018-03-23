using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ArtsHub.Startup))]
namespace ArtsHub
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
