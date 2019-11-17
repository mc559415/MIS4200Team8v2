using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MIS4200Team8v2.Startup))]
namespace MIS4200Team8v2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
