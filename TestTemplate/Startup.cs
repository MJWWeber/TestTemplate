using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestTemplate.Startup))]
namespace TestTemplate
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
