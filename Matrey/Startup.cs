using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Matrey.Startup))]
namespace Matrey
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
