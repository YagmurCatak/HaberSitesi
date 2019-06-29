using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HaberSitesi.Startup))]
namespace HaberSitesi
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
