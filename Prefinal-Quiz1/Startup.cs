using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Prefinal_Quiz1.Startup))]
namespace Prefinal_Quiz1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
