using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CDUUserhandling.Startup))]
namespace CDUUserhandling
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
