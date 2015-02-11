using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PegaMusic.Startup))]
namespace PegaMusic
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
