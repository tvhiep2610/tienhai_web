using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TIENHAI.Startup))]
namespace TIENHAI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
