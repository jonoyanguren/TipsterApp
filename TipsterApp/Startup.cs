using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TipsterApp.Startup))]
namespace TipsterApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
