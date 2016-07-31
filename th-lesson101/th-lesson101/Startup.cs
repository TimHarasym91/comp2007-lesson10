using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(th_lesson101.Startup))]
namespace th_lesson101
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
