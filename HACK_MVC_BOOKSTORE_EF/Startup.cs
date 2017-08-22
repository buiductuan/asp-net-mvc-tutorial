using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HACK_MVC_BOOKSTORE_EF.Startup))]
namespace HACK_MVC_BOOKSTORE_EF
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
