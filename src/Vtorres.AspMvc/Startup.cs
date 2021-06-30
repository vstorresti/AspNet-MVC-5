using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Vtorres.AspMvc.Startup))]
namespace Vtorres.AspMvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
