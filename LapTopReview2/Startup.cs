using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LapTopReview2.Startup))]
namespace LapTopReview2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
