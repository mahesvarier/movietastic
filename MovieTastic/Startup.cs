using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MovieTastic.Startup))]
namespace MovieTastic
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
