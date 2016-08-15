using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(myAbacus.Startup))]
namespace myAbacus
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
