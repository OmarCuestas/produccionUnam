using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebDemoUNAM.Startup))]
namespace WebDemoUNAM
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
