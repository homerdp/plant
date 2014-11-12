using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Plant.Startup))]
namespace Plant
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
