using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(learning_mvc.Startup))]
namespace learning_mvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
