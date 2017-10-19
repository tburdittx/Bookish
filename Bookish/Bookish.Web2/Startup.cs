using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Bookish.Web2.Startup))]
namespace Bookish.Web2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
