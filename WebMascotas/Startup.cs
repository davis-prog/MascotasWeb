using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(WebMascotas.Startup))]

namespace WebMascotas
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }

    }
}