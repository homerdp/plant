using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BestProject.Startup))]
namespace BestProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
