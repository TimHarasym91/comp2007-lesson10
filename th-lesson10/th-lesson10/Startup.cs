using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(th_lesson10.Startup))]
namespace th_lesson10
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
