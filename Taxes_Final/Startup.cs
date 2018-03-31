using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Taxes_Final.Startup))]
namespace Taxes_Final
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
