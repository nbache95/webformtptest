using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(webformtptest.Startup))]
namespace webformtptest
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
