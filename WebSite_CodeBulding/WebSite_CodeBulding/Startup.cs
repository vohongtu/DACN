using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebSite_CodeBulding.Startup))]
namespace WebSite_CodeBulding
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
