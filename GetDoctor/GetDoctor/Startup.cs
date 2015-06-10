using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Getdoctor.Startup))]
namespace Getdoctor
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
