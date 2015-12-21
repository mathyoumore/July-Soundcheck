using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JulySoundcheck.Startup))]
namespace JulySoundcheck
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
