using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(gryphtech_a.Startup))]
namespace gryphtech_a
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
