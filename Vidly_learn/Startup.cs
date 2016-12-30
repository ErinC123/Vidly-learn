using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Vidly_learn.Startup))]
namespace Vidly_learn
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
