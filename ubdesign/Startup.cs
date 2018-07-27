using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ubdesign.Startup))]
namespace ubdesign
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
