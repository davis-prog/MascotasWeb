using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(RegistroMascotasWeb.Startup))]

namespace RegistroMascotasWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }

    }
}