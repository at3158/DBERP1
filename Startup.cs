using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DBERP1.Startup))]
namespace DBERP1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
