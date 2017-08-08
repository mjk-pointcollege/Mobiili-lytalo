using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MobiiliÄlytalo.Startup))]
namespace MobiiliÄlytalo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
