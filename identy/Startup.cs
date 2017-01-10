using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(identy.Startup))]
namespace identy
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
