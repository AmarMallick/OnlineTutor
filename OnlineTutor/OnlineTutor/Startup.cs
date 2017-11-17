using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OnlineTutor.Startup))]
namespace OnlineTutor
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
