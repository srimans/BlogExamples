using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ccAvenue.Startup))]
namespace ccAvenue
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
