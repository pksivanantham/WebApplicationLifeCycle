using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LifeCycleControllerFactory.Startup))]
namespace LifeCycleControllerFactory
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
