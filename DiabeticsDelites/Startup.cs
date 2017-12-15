using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DiabeticsDelites.Startup))]
namespace DiabeticsDelites
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
