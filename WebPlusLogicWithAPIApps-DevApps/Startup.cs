using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebPlusLogicWithAPIApps_DevApps.Startup))]
namespace WebPlusLogicWithAPIApps_DevApps
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
