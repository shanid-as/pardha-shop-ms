using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PSMS.Startup))]
namespace PSMS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
