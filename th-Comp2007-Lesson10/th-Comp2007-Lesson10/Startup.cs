using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(th_Comp2007_Lesson10.Startup))]
namespace th_Comp2007_Lesson10
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
