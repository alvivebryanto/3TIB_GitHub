using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_3TIB_GitHub.Startup))]
namespace _3TIB_GitHub
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
