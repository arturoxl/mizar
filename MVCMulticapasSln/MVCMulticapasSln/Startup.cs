using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCMulticapasSln.Startup))]
namespace MVCMulticapasSln
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
