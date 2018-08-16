using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OBBS.Startup))]
namespace OBBS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
