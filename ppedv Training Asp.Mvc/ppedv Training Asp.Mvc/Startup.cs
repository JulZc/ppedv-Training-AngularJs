using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ppedv_Training_Asp.Mvc.Startup))]
namespace ppedv_Training_Asp.Mvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
